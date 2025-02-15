using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PantheonSupportTool
{
    public partial class MainForm : Form
    {
        private readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PantheonSupportTool.log");

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeLogger()
        {
            try
            {
                string oldLogFilePath = logFilePath + ".old";
                if (File.Exists(logFilePath))
                {
                    File.Delete(oldLogFilePath);
                    File.Move(logFilePath, oldLogFilePath);
                }

                File.Create(logFilePath).Close();
                Trace.Listeners.Add(new TextWriterTraceListener(logFilePath));
                Trace.AutoFlush = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing logger: {ex.Message}");
            }
        }

        private void LogMessage(string message) => Trace.WriteLine($"{DateTime.Now} - {message}");

        private void BackupFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string backupPath = filePath + ".backup";
                    File.Delete(backupPath);
                    File.Move(filePath, backupPath);
                    MessageBox.Show($"File renamed to {Path.GetFileName(backupPath)} successfully.");
                }
                else
                {
                    MessageBox.Show($"File not found: {Path.GetFileName(filePath)}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RemoveFilesInDirectory(string directory, bool dryRun)
        {
            if (!Directory.Exists(directory))
            {
                LogMessage($"Directory {directory} does not exist.");
                return;
            }

            try
            {
                foreach (var item in Directory.GetFileSystemEntries(directory))
                {
                    try
                    {
                        if (File.Exists(item))
                        {
                            if (!dryRun) File.Delete(item);
                            LogMessage($"{(dryRun ? "Would delete" : "Deleted")} file: {item}");
                        }
                        else if (Directory.Exists(item))
                        {
                            if (!dryRun) Directory.Delete(item, true);
                            LogMessage($"{(dryRun ? "Would delete" : "Deleted")} directory: {item}");
                        }
                    }
                    catch (Exception ex)
                    {
                        LogMessage($"Failed to delete {item}. Reason: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error accessing directory {directory}. Reason: {ex.Message}");
            }
        }

        private void RemoveShaderCache(bool dryRun, bool backup)
        {
            string[] shaderCacheDirectories = new string[]
            {
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NVIDIA", "DXCache"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NVIDIA", "GLCache"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AMD", "DxCache"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UnrealEngine", "ShaderCache"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Unity", "Caches"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp", "NVIDIA Corporation", "NV_Cache"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp", "DXCache"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp", "D3DSCache"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp", "AMD", "GLCache"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Unreal Engine", "Common", "DerivedDataCache"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Unity", "Asset Store-5.x"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft", "CLR_v4.0"),
            };

            bool foundDirectories = false;

            foreach (string directory in shaderCacheDirectories)
            {
                if (Directory.Exists(directory) && Directory.GetFileSystemEntries(directory).Length > 0)
                {
                    foundDirectories = true;
                    LogMessage($"Found shader cache in directory: {directory}");

                    if (backup) BackupFile(directory);
                    RemoveFilesInDirectory(directory, dryRun);
                }
            }

            if (foundDirectories)
            {
                LogMessage("Shader cache cleanup completed.");
                MessageBox.Show("Shader cache has been successfully cleared.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LogMessage("No shader cache directories found with files to delete.");
                MessageBox.Show("No shader cache directories were found to clear.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearShaderCacheButton_Click(object sender, EventArgs e)
        {
            InitializeLogger();
            Thread cleanupThread = new Thread(() =>
            {
                LogMessage("Starting shader cache cleanup...");
                RemoveShaderCache(dryRun: false, backup: false);
            });
            cleanupThread.Start();
        }


        private void ResetSettingsButton_Click(object sender, EventArgs e)
        {
            string userProfilePath = Environment.GetEnvironmentVariable("USERPROFILE");
            string settingsFilePath = Path.Combine(userProfilePath, @"AppData\LocalLow\Visionary Realms\Pantheon\Settings\Settings.json");
            BackupFile(settingsFilePath);
        }

        private void ResetChatColorsButton_Click(object sender, EventArgs e)
        {
            string userProfilePath = Environment.GetEnvironmentVariable("USERPROFILE");
            string chatColorsFilePath = Path.Combine(userProfilePath, @"AppData\LocalLow\Visionary Realms\Pantheon\Settings\ChatColors.json");
            BackupFile(chatColorsFilePath);
        }

        private void DisableScalingButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userProfilePath = Environment.GetEnvironmentVariable("USERPROFILE");
                string filePath = Path.Combine(userProfilePath, @"AppData\LocalLow\Visionary Realms\Pantheon\Settings\Settings.json");

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Settings.json file not found.");
                    return;
                }

                string jsonContent = File.ReadAllText(filePath);
                bool modified = false;
                string[] settings = { "AllowFSR2", "DynamicResolution" };

                foreach (string setting in settings)
                {
                    string target = $"\"{setting}\": 1";
                    int index = jsonContent.IndexOf(target);

                    if (index != -1)
                    {
                        jsonContent = jsonContent.Replace(target, $"\"{setting}\": 0");
                        modified = true;
                    }
                }

                if (modified)
                {
                    File.WriteAllText(filePath, jsonContent);
                    MessageBox.Show("AllowFSR2 and DynamicResolution have been set to 0.");
                }
                else
                {
                    MessageBox.Show("Both settings are either not present or already set to 0.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CrashLogsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), @"Visionary Realms\Pantheon\Crashes");

                if (Directory.Exists(tempPath))
                {
                    Process.Start("explorer.exe", tempPath);
                }
                else
                {
                    MessageBox.Show("The directory does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CrashLogsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening email client: {ex.Message}");
            }
        }
    }
}
