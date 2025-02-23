using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using JsonHandler;
using System.Collections.Generic;

namespace PantheonSupportTool
{
    public partial class MainForm : Form
    {
        private readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PantheonSupportTool.log");
        private readonly JsonFileHandler jsonHandler;
        private bool isLoadingSettings = false;

        private readonly string settingsFilePath = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "AppData", "LocalLow", "Visionary Realms", "Pantheon", "Settings", "Settings.json");
        private readonly string chatColorsFilePath = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "AppData", "LocalLow", "Visionary Realms", "Pantheon", "Settings", "ChatColors.json");
        private readonly string crashLogsFilePath = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), "Visionary Realms", "Pantheon", "Crashes");

        public MainForm()
        {
            InitializeComponent();

            this.Text = $"Pantheon Support Tool v{Program.AppInfo.Version}";
            SetDefaultComboBoxSelections();

            jsonHandler = new JsonFileHandler(settingsFilePath);

            InitializeLogger();
            LogMessage("Note: Be sure to close Pantheon before making any changes. If the game is open, any changes made will be lost.");

            LoadSettingsFromJson();
            HookControlEvents();
        }

        private void SetDefaultComboBoxSelections()
        {
            comboBoxAntiAliasing.SelectedIndex = 1;
            comboBoxQualityLevel.SelectedIndex = 1;
            comboBoxVSync.SelectedIndex = 1;
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

        private void LogMessage(string message)
        {
            string logEntry = $"{DateTime.Now.ToString("yyy-MM-dd HH:mm:ss")} - {message}";
            Trace.WriteLine(logEntry);
            textBox.AppendText(logEntry + Environment.NewLine);
        }

        private Dictionary<string, (string JsonKey, int DefaultValue)> controlToJsonKeyMap = new Dictionary<string, (string, int)>
        {
            { "checkBoxShowMyNameplate", ("ShowMyNameplate", 0) },
            { "checkBoxDetailMeshes", ("GrassEnabled", 1) },
            //{ "checkBoxClimbKeyToClimb", ("HoldClimbKeyToClimb", 0) },
            //{ "checkBoxForceAnisotrphicFiltering", ("ForceAnisotrphicFiltering", 0) },
            //{ "checkBoxInvertMouse", ("InvertMouse", 0) },
            { "checkBoxFullScreenEnabled", ("FullScreenEnabled", 1) },
            { "checkBoxHardwareCursor", ("HardwareCursor", 1) },
            //{ "checkBoxMuteAudio", ("MuteAudio", 0) },
            //{ "checkBoxMuteMusic", ("MuteMusic", 0) },
            { "sliderLODDistance", ("LODDistance", 50) },
            { "sliderClipDistance", ("ClipDistance", 50) },
            { "sliderShadowDrawDistance", ("ShadowDrawDistance", 33) },
            //{ "sliderDetailDistance", ("DetailDistance", 50) },
            { "sliderCombatMusicVolume", ("CombatMusicVolume", 100) },
            //{ "sliderMouseSensitivity", ("MouseSensitivity", 50) },
            { "sliderNameplateDistance", ("NameplateDistance", 50) },
            { "checkBoxDynamicResolution", ("DynamicResolution", 0) },
            { "checkBoxAllowAmbientOcclusion", ("AllowAmbientOcclusion", 1) },
            //{ "checkBoxAllowScreenSpaceGlobalIllumination", ("AllowScreenSpaceGlobalIllumination", 1) },
            { "comboBoxVSync", ("VSync", 1) },
            //{ "comboBoxResolution", ("Resolution", 0) }, // otherwise will save -1 with control disabled
            { "comboBoxQualityLevel", ("QualityLevel", 1) },
            //{ "comboBoxDisplayMonitor", ("DisplayMonitor", 0) }, // otherwise will save -1 with control disabled
            //{ "comboBoxLanguage", ("Language", 0) },
            //{ "comboBoxShowEnduranceBar", ("ShowEnduranceBar", 0) },
            //{ "comboBoxShowFractionalSkillups", ("ShowFractionalSkillups", 0) },
            //{ "comboBoxShowSkillups", ("ShowSkillups", 0) },
            //{ "comboBoxShowItemsReceived", ("ShowItemsReceived", 0) },
            //{ "comboBoxAutomaticallyEnableAutoAttack", ("AutomaticallyEnableAutoAttack", 0) },
            { "sliderMasterVolume", ("MasterVolume", 100) },
            { "sliderAmbientVolume", ("AmbientVolume", 100) },
            { "sliderSFXVolume", ("SFXVolume", 100) },
            { "sliderLocomotionVolume", ("LocomotionVolume", 100) },
            { "sliderUISFXVolume", ("UISFXVolume", 100) },
            { "sliderMusicVolume", ("MusicVolume", 100) },
            //{ "comboBoxInteractionTooltips", ("InteractionTooltips", 0) },
            { "sliderChatFontSize", ("ChatFontSize", 14) },
            { "sliderTooltipsScale", ("TooltipsScale", 100) },
            { "checkBoxDisableSky", ("DisableSky", 0) },
            { "checkBoxDisableClickToClearTargets", ("DisableClickToClearTargets", 0) },
            { "comboBoxAntiAliasing", ("AntiAliasing", 1) },
            { "checkBoxAllowFSR2", ("AllowFSR2", 0) }
        };

        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;
                foreach (Control child in GetAllControls(control))
                {
                    yield return child;
                }
            }
        }

        private void LoadSettingsFromJson()
        {
            isLoadingSettings = true; // Set true

            foreach (var control in GetAllControls(this))
            {
                if (controlToJsonKeyMap.TryGetValue(control.Name, out var jsonInfo))
                {
                    var settingValue = jsonHandler.GetValue(jsonInfo.JsonKey);
                    if (settingValue == null)
                    {
                        settingValue = jsonInfo.DefaultValue;
                    }

                    if (control is TrackBar slider && settingValue is int intValue)
                    {
                        slider.Value = intValue;
                    }
                    else if (control is ComboBox comboBox && settingValue is int comboBoxValue && comboBoxValue >= 0 && comboBoxValue < comboBox.Items.Count)
                    {
                        comboBox.SelectedIndex = comboBoxValue;
                    }
                    else if (control is CheckBox checkBox && settingValue is int checkBoxValue)
                    {
                        checkBox.Checked = checkBoxValue == 1;
                    }
                }
            }

            isLoadingSettings = false; // Reset after loading is done
        }

        private void SaveSettingsToJson()
        {
            foreach (var control in GetAllControls(this))
            {
                if (controlToJsonKeyMap.TryGetValue(control.Name, out var jsonInfo))
                {
                    object valueToSave = null;

                    if (control is TrackBar slider)
                    {
                        valueToSave = slider.Value;
                    }
                    else if (control is ComboBox comboBox)
                    {
                        valueToSave = comboBox.SelectedIndex;
                    }
                    else if (control is CheckBox checkBox)
                    {
                        valueToSave = checkBox.Checked ? 1 : 0;
                    }

                    if (valueToSave != null)
                    {
                        jsonHandler.SetValue(jsonInfo.JsonKey, valueToSave);
                        LogMessage($"\"{jsonInfo.JsonKey}\": {valueToSave}");
                    }
                }
            }

            LogMessage("Settings successfully saved.");
        }

        private void HookControlEvents()
        {
            foreach (var control in GetAllControls(this))
            {
                if (controlToJsonKeyMap.TryGetValue(control.Name, out var jsonInfo))
                {
                    switch (control)
                    {
                        case TrackBar slider:
                            slider.ValueChanged += (sender, e) =>
                            {
                                if (!isLoadingSettings)
                                {
                                    LogAndSave(jsonInfo.JsonKey, slider.Value);
                                }
                            };
                            break;

                        case ComboBox comboBox:
                            comboBox.SelectedIndexChanged += (sender, e) =>
                            {
                                if (!isLoadingSettings)
                                {
                                    LogAndSave(jsonInfo.JsonKey, comboBox.SelectedIndex);
                                }
                            };
                            break;

                        case CheckBox checkBox:
                            checkBox.CheckedChanged += (sender, e) =>
                            {
                                if (!isLoadingSettings)
                                {
                                    LogAndSave(jsonInfo.JsonKey, checkBox.Checked ? 1 : 0);
                                }
                            };
                            break;
                    }
                }
            }
        }

        private void LogAndSave(string key, object value)
        {
            jsonHandler.SetValue(key, value);
            LogMessage($"\"{key}\": {value}");
        }

        private void BackupFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"The file '{Path.GetFileName(filePath)}' does not exist.");
                return;
            }

            try
            {
                // Read the file content to check if it's an empty JSON
                string fileContent = File.ReadAllText(filePath).Trim();

                // Check if the content is exactly '{}'
                if (fileContent == "{}")
                {
                    MessageBox.Show($"The file '{Path.GetFileName(filePath)}' is already empty.");
                    return;
                }

                string backupPath = filePath + ".backup";
                if (File.Exists(backupPath))
                {
                    File.Delete(backupPath);
                }
                File.Move(filePath, backupPath);
                LogMessage($"{Path.GetFileName(filePath)} has been reset. The original file has been renamed to {Path.GetFileName(backupPath)}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during backup: {ex.Message}");
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
                            if (!dryRun)
                            {
                                File.Delete(item);
                            }
                            LogMessage($"{(dryRun ? "Would delete" : "Deleted")} file: {item}");
                        }
                        else if (Directory.Exists(item))
                        {
                            if (!dryRun)
                            {
                                Directory.Delete(item, true);
                            }
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

                    if (backup)
                    {
                        BackupFile(directory);
                    }
                    RemoveFilesInDirectory(directory, dryRun);
                }
            }

            if (foundDirectories)
            {
                LogMessage("Shader cache cleanup completed.");
            }
            else
            {
                LogMessage("No shader cache directories found with files to delete.");
            }
        }

        private async void ClearShaderCacheButton_Click(object sender, EventArgs e)
        {
            LogMessage("Starting shader cache cleanup...");
            await Task.Run(() => RemoveShaderCache(dryRun: false, backup: false));
        }

        private void ResetSettingsButton_Click(object sender, EventArgs e)
        {
            BackupFile(settingsFilePath);
            LoadSettingsFromJson();
        }

        private void ResetChatColorsButton_Click(object sender, EventArgs e)
        {
            BackupFile(chatColorsFilePath);
        }

        private void DisableScalingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBoxDynamicResolution.Checked || this.checkBoxAllowFSR2.Checked)
                {
                    this.checkBoxDynamicResolution.Checked = false;
                    this.checkBoxAllowFSR2.Checked = false;
                }
                else
                {
                    MessageBox.Show("DLSS/FSR2 is already disabled.");
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
                if (Directory.Exists(crashLogsFilePath))
                {
                    Process.Start("explorer.exe", crashLogsFilePath);
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
