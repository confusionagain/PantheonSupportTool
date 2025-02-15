using System.Windows.Forms;
using static PantheonSupportTool.Program;

namespace PantheonSupportTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClearShaderCache = new System.Windows.Forms.Button();
            this.labelClearShaderCache = new System.Windows.Forms.Label();
            this.buttonResetSettings = new System.Windows.Forms.Button();
            this.buttonDisableScaling = new System.Windows.Forms.Button();
            this.labelResetSettings = new System.Windows.Forms.Label();
            this.buttonCrashLogs = new System.Windows.Forms.Button();
            this.labelDisableScaling = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelResetChatColors = new System.Windows.Forms.Label();
            this.buttonResetChatColors = new System.Windows.Forms.Button();
            this.linkLabelCrashLogs = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonClearShaderCache
            // 
            this.buttonClearShaderCache.Location = new System.Drawing.Point(12, 262);
            this.buttonClearShaderCache.Name = "ClearShaderCacheButton";
            this.buttonClearShaderCache.Size = new System.Drawing.Size(240, 48);
            this.buttonClearShaderCache.TabIndex = 7;
            this.buttonClearShaderCache.Text = "Clear Shader Cache";
            this.buttonClearShaderCache.UseVisualStyleBackColor = true;
            this.buttonClearShaderCache.Click += new System.EventHandler(this.ClearShaderCacheButton_Click);
            // 
            // labelClearShaderCache
            // 
            this.labelClearShaderCache.Location = new System.Drawing.Point(258, 264);
            this.labelClearShaderCache.MaximumSize = new System.Drawing.Size(320, 48);
            this.labelClearShaderCache.Name = "ClearShaderCacheLabel";
            this.labelClearShaderCache.Size = new System.Drawing.Size(320, 48);
            this.labelClearShaderCache.TabIndex = 8;
            this.labelClearShaderCache.Text = "Attempts to delete any cached shaders found on your computer. A log file will be " +
    "generated with details. This may help with stutter and possibly resolve some cra" +
    "shes.";
            // 
            // buttonResetSettings
            // 
            this.buttonResetSettings.Location = new System.Drawing.Point(12, 88);
            this.buttonResetSettings.Name = "ResetSettingsButton";
            this.buttonResetSettings.Size = new System.Drawing.Size(240, 48);
            this.buttonResetSettings.TabIndex = 1;
            this.buttonResetSettings.Text = "Reset Graphics Settings";
            this.buttonResetSettings.UseVisualStyleBackColor = true;
            this.buttonResetSettings.Click += new System.EventHandler(this.ResetSettingsButton_Click);
            // 
            // buttonDisableScaling
            // 
            this.buttonDisableScaling.Location = new System.Drawing.Point(12, 204);
            this.buttonDisableScaling.Name = "DisableScalingButton";
            this.buttonDisableScaling.Size = new System.Drawing.Size(240, 48);
            this.buttonDisableScaling.TabIndex = 5;
            this.buttonDisableScaling.Text = "Disable DLSS/FSR2";
            this.buttonDisableScaling.UseVisualStyleBackColor = true;
            this.buttonDisableScaling.Click += new System.EventHandler(this.DisableScalingButton_Click);
            // 
            // labelResetSettings
            // 
            this.labelResetSettings.Location = new System.Drawing.Point(258, 90);
            this.labelResetSettings.MaximumSize = new System.Drawing.Size(320, 48);
            this.labelResetSettings.Name = "ResetSettingsLabel";
            this.labelResetSettings.Size = new System.Drawing.Size(320, 48);
            this.labelResetSettings.TabIndex = 2;
            this.labelResetSettings.Text = "Settings.json will be deleted and your audio/graphics settings will be reset on n" +
    "ext launch.";
            // 
            // buttonCrashLogs
            // 
            this.buttonCrashLogs.Location = new System.Drawing.Point(12, 378);
            this.buttonCrashLogs.Name = "CrashLogsButton";
            this.buttonCrashLogs.Size = new System.Drawing.Size(240, 48);
            this.buttonCrashLogs.TabIndex = 10;
            this.buttonCrashLogs.Text = "Open Crash Log Folder";
            this.buttonCrashLogs.UseVisualStyleBackColor = true;
            this.buttonCrashLogs.Click += new System.EventHandler(this.CrashLogsButton_Click);
            // 
            // labelDisableScaling
            // 
            this.labelDisableScaling.Location = new System.Drawing.Point(258, 206);
            this.labelDisableScaling.MaximumSize = new System.Drawing.Size(320, 48);
            this.labelDisableScaling.Name = "DisableScalingLabel";
            this.labelDisableScaling.Size = new System.Drawing.Size(320, 48);
            this.labelDisableScaling.TabIndex = 6;
            this.labelDisableScaling.Text = "Settings.json will be edited and the values for DynamicResolution and AllowFSR2 w" +
    "ill be set to 0. Fixes crashes on login for players with AMD (and 10/16/GTX TITA" +
    "N series Nvidia) GPUs.";
            // 
            // labelTop
            // 
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.Red;
            this.labelTop.Location = new System.Drawing.Point(12, 13);
            this.labelTop.MaximumSize = new System.Drawing.Size(600, 48);
            this.labelTop.Name = "TopLabel";
            this.labelTop.Size = new System.Drawing.Size(600, 48);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Please ensure that Pantheon.exe is closed before making any of these changes. If " +
    "the game is open, many of these fixes will not work.";
            // 
            // labelResetChatColors
            // 
            this.labelResetChatColors.Location = new System.Drawing.Point(258, 148);
            this.labelResetChatColors.MaximumSize = new System.Drawing.Size(320, 48);
            this.labelResetChatColors.Name = "labelResetChatColors";
            this.labelResetChatColors.Size = new System.Drawing.Size(320, 48);
            this.labelResetChatColors.TabIndex = 4;
            this.labelResetChatColors.Text = "ChatColors.json will be deleted and your chat colors will be reset on next launch" +
    ". Fixes issues with chat turning black.";
            // 
            // buttonResetChatColors
            // 
            this.buttonResetChatColors.Location = new System.Drawing.Point(12, 146);
            this.buttonResetChatColors.Name = "ResetChatColorsButton";
            this.buttonResetChatColors.Size = new System.Drawing.Size(240, 48);
            this.buttonResetChatColors.TabIndex = 3;
            this.buttonResetChatColors.Text = "Reset Chat Colors";
            this.buttonResetChatColors.UseVisualStyleBackColor = true;
            this.buttonResetChatColors.Click += new System.EventHandler(this.ResetChatColorsButton_Click);
            // 
            // linkLabelCrashLogs
            // 
            this.linkLabelCrashLogs.LinkArea = new System.Windows.Forms.LinkArea(13, 27);
            this.linkLabelCrashLogs.Location = new System.Drawing.Point(261, 380);
            this.linkLabelCrashLogs.MaximumSize = new System.Drawing.Size(320, 48);
            this.linkLabelCrashLogs.Name = "CrashLogsLinkLabel";
            this.linkLabelCrashLogs.Size = new System.Drawing.Size(320, 48);
            this.linkLabelCrashLogs.TabIndex = 11;
            this.linkLabelCrashLogs.TabStop = true;
            this.linkLabelCrashLogs.Text = "Please email support@visionaryrealms.com with any details you may have about unresolved crashes, along with a file attachment of an archive of your related logs.";
            this.linkLabelCrashLogs.UseCompatibleTextRendering = true;
            this.linkLabelCrashLogs.Links.Clear();
            this.linkLabelCrashLogs.Links.Add(13, 27, "mailto:support@visionaryrealms.com");
            this.linkLabelCrashLogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CrashLogsLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 437);
            this.Controls.Add(this.linkLabelCrashLogs);
            this.Controls.Add(this.labelResetChatColors);
            this.Controls.Add(this.buttonResetChatColors);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.labelDisableScaling);
            this.Controls.Add(this.buttonCrashLogs);
            this.Controls.Add(this.labelResetSettings);
            this.Controls.Add(this.buttonDisableScaling);
            this.Controls.Add(this.buttonResetSettings);
            this.Controls.Add(this.labelClearShaderCache);
            this.Controls.Add(this.buttonClearShaderCache);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pantheon Support Tool v" + AppInfo.Version;
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label labelTop; 
        private System.Windows.Forms.Button buttonClearShaderCache;
        private System.Windows.Forms.Label labelClearShaderCache;
        private System.Windows.Forms.Button buttonResetSettings;
        private System.Windows.Forms.Label labelResetSettings;
        private System.Windows.Forms.Button buttonDisableScaling;
        private System.Windows.Forms.Label labelDisableScaling;
        private System.Windows.Forms.Button buttonCrashLogs;
        private System.Windows.Forms.Button buttonResetChatColors;
        private System.Windows.Forms.Label labelResetChatColors;
        private System.Windows.Forms.LinkLabel linkLabelCrashLogs;
    }
}

