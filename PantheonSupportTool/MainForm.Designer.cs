using System.Windows.Forms;
using System.Drawing;

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
            this.tabControl = new System.Windows.Forms.TabControl();

            this.tabGraphics = new System.Windows.Forms.TabPage();
            this.labelLODDistance = new System.Windows.Forms.Label();
            this.sliderLODDistance = new System.Windows.Forms.TrackBar();
            this.labelClipDistance = new System.Windows.Forms.Label();
            this.sliderClipDistance = new System.Windows.Forms.TrackBar();
            this.labelShadowDistance = new System.Windows.Forms.Label();
            this.sliderShadowDrawDistance = new System.Windows.Forms.TrackBar();
            this.labelNameplateDistance = new System.Windows.Forms.Label();
            this.sliderNameplateDistance = new System.Windows.Forms.TrackBar();
            this.labelShowMyNameplate = new System.Windows.Forms.Label();
            this.checkBoxShowMyNameplate = new System.Windows.Forms.CheckBox();
            this.labelDynamicResolution = new System.Windows.Forms.Label();
            this.checkBoxDynamicResolution = new System.Windows.Forms.CheckBox();
            this.labelAllowFSR2 = new System.Windows.Forms.Label();
            this.checkBoxAllowFSR2 = new System.Windows.Forms.CheckBox();
            this.labelAntiAliasing = new System.Windows.Forms.Label();
            this.comboBoxAntiAliasing = new System.Windows.Forms.ComboBox();
            this.labelQualityLevel = new System.Windows.Forms.Label();
            this.comboBoxQualityLevel = new System.Windows.Forms.ComboBox();
            this.labelAllowAmbientOcclusion = new System.Windows.Forms.Label();
            this.checkBoxAllowAmbientOcclusion = new System.Windows.Forms.CheckBox();
            this.labelDisableSky = new System.Windows.Forms.Label();
            this.checkBoxDisableSky = new System.Windows.Forms.CheckBox();
            this.labelDetailMeshes = new System.Windows.Forms.Label();
            this.checkBoxDetailMeshes = new System.Windows.Forms.CheckBox();
            this.labelDisplayMonitor = new System.Windows.Forms.Label();
            this.comboBoxDisplayMonitor = new System.Windows.Forms.ComboBox();
            this.labelVSync = new System.Windows.Forms.Label();
            this.comboBoxVSync = new System.Windows.Forms.ComboBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.labelFullScreenEnabled = new System.Windows.Forms.Label();
            this.checkBoxFullScreenEnabled = new System.Windows.Forms.CheckBox();
            this.labelHardwareCursor = new System.Windows.Forms.Label();
            this.checkBoxHardwareCursor = new System.Windows.Forms.CheckBox();
            this.buttonResetSettings = new System.Windows.Forms.Button();

            this.tabAudio = new System.Windows.Forms.TabPage();
            this.labelMasterVolume = new System.Windows.Forms.Label();
            this.sliderMasterVolume = new System.Windows.Forms.TrackBar();
            this.labelAmbientVolume = new System.Windows.Forms.Label();
            this.sliderAmbientVolume = new System.Windows.Forms.TrackBar();
            this.labelSFXVolume = new System.Windows.Forms.Label();
            this.sliderSFXVolume = new System.Windows.Forms.TrackBar();
            this.labelLocomotionVolume = new System.Windows.Forms.Label();
            this.sliderLocomotionVolume = new System.Windows.Forms.TrackBar();
            this.labelUISFXVolume = new System.Windows.Forms.Label();
            this.sliderUISFXVolume = new System.Windows.Forms.TrackBar();
            this.labelMusicVolume = new System.Windows.Forms.Label();
            this.sliderMusicVolume = new System.Windows.Forms.TrackBar();
            this.labelCombatMusicVolume = new System.Windows.Forms.Label();
            this.sliderCombatMusicVolume = new System.Windows.Forms.TrackBar();
            
            this.tabUI = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();

            this.tabFixes = new System.Windows.Forms.TabPage();
            this.buttonResetChatColors = new System.Windows.Forms.Button();
            this.labelResetChatColors = new System.Windows.Forms.Label();
            this.buttonDisableScaling = new System.Windows.Forms.Button();
            this.labelDisableScaling = new System.Windows.Forms.Label();
            this.buttonClearShaderCache = new System.Windows.Forms.Button();
            this.labelClearShaderCache = new System.Windows.Forms.Label();
            this.buttonCrashLogs = new System.Windows.Forms.Button();
            this.linkLabelCrashLogs = new System.Windows.Forms.LinkLabel();

            this.textBox = new System.Windows.Forms.TextBox();

            this.tabControl.SuspendLayout();

            this.tabGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLODDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderClipDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderShadowDrawDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderNameplateDistance)).BeginInit();
            
            this.tabAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMasterVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAmbientVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSFXVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLocomotionVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUISFXVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMusicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderCombatMusicVolume)).BeginInit();

            this.tabUI.SuspendLayout();

            this.tabFixes.SuspendLayout();

            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGraphics);
            this.tabControl.Controls.Add(this.tabAudio);
            this.tabControl.Controls.Add(this.tabUI);
            this.tabControl.Controls.Add(this.tabFixes);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabControl.ItemSize = new System.Drawing.Size(100, 32);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(708, 392);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabGraphics
            // 
            this.tabGraphics.Controls.Add(this.labelLODDistance);
            this.tabGraphics.Controls.Add(this.sliderLODDistance);
            this.tabGraphics.Controls.Add(this.labelClipDistance);
            this.tabGraphics.Controls.Add(this.sliderClipDistance);
            this.tabGraphics.Controls.Add(this.labelShadowDistance);
            this.tabGraphics.Controls.Add(this.sliderShadowDrawDistance);
            this.tabGraphics.Controls.Add(this.labelNameplateDistance);
            this.tabGraphics.Controls.Add(this.sliderNameplateDistance);
            this.tabGraphics.Controls.Add(this.labelShowMyNameplate);
            this.tabGraphics.Controls.Add(this.checkBoxShowMyNameplate);
            this.tabGraphics.Controls.Add(this.labelDynamicResolution);
            this.tabGraphics.Controls.Add(this.checkBoxDynamicResolution);
            this.tabGraphics.Controls.Add(this.labelAllowFSR2);
            this.tabGraphics.Controls.Add(this.checkBoxAllowFSR2);
            this.tabGraphics.Controls.Add(this.labelAntiAliasing);
            this.tabGraphics.Controls.Add(this.comboBoxAntiAliasing);
            this.tabGraphics.Controls.Add(this.labelQualityLevel);
            this.tabGraphics.Controls.Add(this.comboBoxQualityLevel);
            this.tabGraphics.Controls.Add(this.labelAllowAmbientOcclusion);
            this.tabGraphics.Controls.Add(this.checkBoxAllowAmbientOcclusion);
            this.tabGraphics.Controls.Add(this.labelDisableSky);
            this.tabGraphics.Controls.Add(this.checkBoxDisableSky);
            this.tabGraphics.Controls.Add(this.labelDetailMeshes);
            this.tabGraphics.Controls.Add(this.checkBoxDetailMeshes);
            this.tabGraphics.Controls.Add(this.labelDisplayMonitor);
            this.tabGraphics.Controls.Add(this.comboBoxDisplayMonitor);
            this.tabGraphics.Controls.Add(this.labelVSync);
            this.tabGraphics.Controls.Add(this.comboBoxVSync);
            this.tabGraphics.Controls.Add(this.labelResolution);
            this.tabGraphics.Controls.Add(this.comboBoxResolution);
            this.tabGraphics.Controls.Add(this.labelFullScreenEnabled);
            this.tabGraphics.Controls.Add(this.checkBoxFullScreenEnabled);
            this.tabGraphics.Controls.Add(this.labelHardwareCursor);
            this.tabGraphics.Controls.Add(this.checkBoxHardwareCursor);
            this.tabGraphics.Controls.Add(this.buttonResetSettings);
            this.tabGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabGraphics.Location = new System.Drawing.Point(4, 36);
            this.tabGraphics.Name = "tabGraphics";
            this.tabGraphics.Size = new System.Drawing.Size(700, 352);
            this.tabGraphics.TabIndex = 1;
            this.tabGraphics.Text = "Graphics";
            // 
            // labelLODDistance
            // 
            this.labelLODDistance.AutoSize = true;
            this.labelLODDistance.Location = new System.Drawing.Point(14, 22);
            this.labelLODDistance.Name = "labelLODDistance";
            this.labelLODDistance.Size = new System.Drawing.Size(78, 13);
            this.labelLODDistance.TabIndex = 100;
            this.labelLODDistance.Text = "Level of Detail:";
            // 
            // sliderLODDistance
            // 
            this.sliderLODDistance.Location = new System.Drawing.Point(130, 18);
            this.sliderLODDistance.Maximum = 100;
            this.sliderLODDistance.Name = "sliderLODDistance";
            this.sliderLODDistance.Size = new System.Drawing.Size(200, 45);
            this.sliderLODDistance.TabIndex = 101;
            this.sliderLODDistance.Value = 50;
            // 
            // labelClipDistance
            // 
            this.labelClipDistance.AutoSize = true;
            this.labelClipDistance.Location = new System.Drawing.Point(14, 68);
            this.labelClipDistance.Name = "labelClipDistance";
            this.labelClipDistance.Size = new System.Drawing.Size(90, 13);
            this.labelClipDistance.TabIndex = 102;
            this.labelClipDistance.Text = "Far Clip Distance:";
            // 
            // sliderClipDistance
            // 
            this.sliderClipDistance.Location = new System.Drawing.Point(130, 64);
            this.sliderClipDistance.Maximum = 100;
            this.sliderClipDistance.Name = "sliderClipDistance";
            this.sliderClipDistance.Size = new System.Drawing.Size(200, 45);
            this.sliderClipDistance.TabIndex = 103;
            this.sliderClipDistance.Value = 50;
            // 
            // labelShadowDistance
            // 
            this.labelShadowDistance.AutoSize = true;
            this.labelShadowDistance.Location = new System.Drawing.Point(14, 114);
            this.labelShadowDistance.Name = "labelShadowDistance";
            this.labelShadowDistance.Size = new System.Drawing.Size(94, 13);
            this.labelShadowDistance.TabIndex = 104;
            this.labelShadowDistance.Text = "Shadow Distance:";
            // 
            // sliderShadowDrawDistance
            // 
            this.sliderShadowDrawDistance.Location = new System.Drawing.Point(130, 110);
            this.sliderShadowDrawDistance.Maximum = 100;
            this.sliderShadowDrawDistance.Name = "sliderShadowDrawDistance";
            this.sliderShadowDrawDistance.Size = new System.Drawing.Size(200, 45);
            this.sliderShadowDrawDistance.TabIndex = 105;
            this.sliderShadowDrawDistance.Value = 50;
            // 
            // labelNameplateDistance
            // 
            this.labelNameplateDistance.AutoSize = true;
            this.labelNameplateDistance.Location = new System.Drawing.Point(14, 160);
            this.labelNameplateDistance.Name = "labelNameplateDistance";
            this.labelNameplateDistance.Size = new System.Drawing.Size(106, 13);
            this.labelNameplateDistance.TabIndex = 106;
            this.labelNameplateDistance.Text = "Nameplate Distance:";
            // 
            // sliderNameplateDistance
            // 
            this.sliderNameplateDistance.Location = new System.Drawing.Point(130, 156);
            this.sliderNameplateDistance.Maximum = 100;
            this.sliderNameplateDistance.Name = "sliderNameplateDistance";
            this.sliderNameplateDistance.Size = new System.Drawing.Size(200, 45);
            this.sliderNameplateDistance.TabIndex = 107;
            this.sliderNameplateDistance.Value = 50;
            // 
            // checkBoxShowMyNameplate
            // 
            this.checkBoxShowMyNameplate.AutoSize = true;
            this.checkBoxShowMyNameplate.Location = new System.Drawing.Point(14, 205);
            this.checkBoxShowMyNameplate.Name = "checkBoxShowMyNameplate";
            this.checkBoxShowMyNameplate.TabIndex = 108;
            this.checkBoxShowMyNameplate.Text = "Show My Nameplate";
            this.checkBoxShowMyNameplate.UseVisualStyleBackColor = true;
            // 
            // checkBoxDynamicResolution
            // 
            this.checkBoxDynamicResolution.Checked = true;
            this.checkBoxDynamicResolution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDynamicResolution.AutoSize = true;
            this.checkBoxDynamicResolution.Location = new System.Drawing.Point(354, 21);
            this.checkBoxDynamicResolution.Name = "checkBoxDynamicResolution";
            this.checkBoxDynamicResolution.TabIndex = 109;
            this.checkBoxDynamicResolution.Text = "Enable Dynamic Resolution (DLSS)";
            this.checkBoxDynamicResolution.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllowFSR2
            // 
            this.checkBoxAllowFSR2.AutoSize = true;
            this.checkBoxAllowFSR2.Location = new System.Drawing.Point(354, 57);
            this.checkBoxAllowFSR2.Name = "checkBoxAllowFSR2";
            this.checkBoxAllowFSR2.TabIndex = 110;
            this.checkBoxAllowFSR2.Text = "Allow FSR2 Scaling";
            this.checkBoxAllowFSR2.UseVisualStyleBackColor = true;
            // 
            // labelAntiAliasing
            // 
            this.labelAntiAliasing.AutoSize = true;
            this.labelAntiAliasing.Location = new System.Drawing.Point(371, 94);
            this.labelAntiAliasing.Name = "labelAntiAliasing";
            this.labelAntiAliasing.Size = new System.Drawing.Size(106, 13);
            this.labelAntiAliasing.TabIndex = 111;
            this.labelAntiAliasing.Text = "Anti-Aliasing Method:";
            // 
            // comboBoxAntiAliasing
            // 
            this.comboBoxAntiAliasing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAntiAliasing.FormattingEnabled = true;
            this.comboBoxAntiAliasing.Items.AddRange(new object[] {
            "Disabled",
            "FXAA",
            "TAA",
            "SMAA"});
            this.comboBoxAntiAliasing.Location = new System.Drawing.Point(371, 110);
            this.comboBoxAntiAliasing.Name = "comboBoxAntiAliasing";
            this.comboBoxAntiAliasing.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAntiAliasing.TabIndex = 112;
            // 
            // labelQualityLevel
            // 
            this.labelQualityLevel.AutoSize = true;
            this.labelQualityLevel.Location = new System.Drawing.Point(373, 140);
            this.labelQualityLevel.Name = "labelQualityLevel";
            this.labelQualityLevel.Size = new System.Drawing.Size(80, 13);
            this.labelQualityLevel.TabIndex = 113;
            this.labelQualityLevel.Text = "Render Quality:";
            // 
            // comboBoxQualityLevel
            // 
            this.comboBoxQualityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQualityLevel.FormattingEnabled = true;
            this.comboBoxQualityLevel.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.comboBoxQualityLevel.Location = new System.Drawing.Point(371, 156);
            this.comboBoxQualityLevel.Name = "comboBoxQualityLevel";
            this.comboBoxQualityLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQualityLevel.TabIndex = 114;
            // 
            // checkBoxAllowAmbientOcclusion
            // 
            this.checkBoxAllowAmbientOcclusion.Checked = true;
            this.checkBoxAllowAmbientOcclusion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllowAmbientOcclusion.AutoSize = true;
            this.checkBoxAllowAmbientOcclusion.Location = new System.Drawing.Point(354, 201);
            this.checkBoxAllowAmbientOcclusion.Name = "checkBoxAllowAmbientOcclusion";
            this.checkBoxAllowAmbientOcclusion.TabIndex = 115;
            this.checkBoxAllowAmbientOcclusion.Text = "Enable Ambient Occlusion";
            this.checkBoxAllowAmbientOcclusion.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisableSky
            // 
            this.checkBoxDisableSky.AutoSize = true;
            this.checkBoxDisableSky.Location = new System.Drawing.Point(354, 237);
            this.checkBoxDisableSky.Name = "checkBoxDisableSky";
            this.checkBoxDisableSky.TabIndex = 116;
            this.checkBoxDisableSky.Text = "Disable Skybox";
            this.checkBoxDisableSky.UseVisualStyleBackColor = true;
            // 
            // checkBoxDetailMeshes
            // 
            this.checkBoxDetailMeshes.Checked = true;
            this.checkBoxDetailMeshes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDetailMeshes.AutoSize = true;
            this.checkBoxDetailMeshes.Location = new System.Drawing.Point(354, 273);
            this.checkBoxDetailMeshes.Name = "checkBoxDetailMeshes";
            this.checkBoxDetailMeshes.TabIndex = 117;
            this.checkBoxDetailMeshes.Text = "Enable Detail Meshes";
            this.checkBoxDetailMeshes.UseVisualStyleBackColor = true;
            // 
            // labelDisplayMonitor
            // 
            this.labelDisplayMonitor.AutoSize = true;
            this.labelDisplayMonitor.Enabled = false;
            this.labelDisplayMonitor.Location = new System.Drawing.Point(562, 94);
            this.labelDisplayMonitor.Name = "labelDisplayMonitor";
            this.labelDisplayMonitor.Size = new System.Drawing.Size(45, 13);
            this.labelDisplayMonitor.TabIndex = 118;
            this.labelDisplayMonitor.Text = "Monitor:";
            // 
            // comboBoxDisplayMonitor
            // 
            this.comboBoxDisplayMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisplayMonitor.Enabled = false;
            this.comboBoxDisplayMonitor.FormattingEnabled = true;
            this.comboBoxDisplayMonitor.Location = new System.Drawing.Point(560, 110);
            this.comboBoxDisplayMonitor.Name = "comboBoxDisplayMonitor";
            this.comboBoxDisplayMonitor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDisplayMonitor.TabIndex = 119;
            // 
            // labelVSync
            // 
            this.labelVSync.AutoSize = true;
            this.labelVSync.Location = new System.Drawing.Point(562, 140);
            this.labelVSync.Name = "labelVSync";
            this.labelVSync.Size = new System.Drawing.Size(75, 13);
            this.labelVSync.TabIndex = 120;
            this.labelVSync.Text = "V-Sync Count:";
            // 
            // comboBoxVSync
            // 
            this.comboBoxVSync.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVSync.FormattingEnabled = true;
            this.comboBoxVSync.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBoxVSync.Location = new System.Drawing.Point(560, 156);
            this.comboBoxVSync.Name = "comboBoxVSync";
            this.comboBoxVSync.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVSync.TabIndex = 121;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Enabled = false;
            this.labelResolution.Location = new System.Drawing.Point(562, 186);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(60, 13);
            this.labelResolution.TabIndex = 122;
            this.labelResolution.Text = "Resolution:";
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolution.Enabled = false;
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Items.AddRange(new object[] {
            ""});
            this.comboBoxResolution.Location = new System.Drawing.Point(560, 202);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(121, 21);
            this.comboBoxResolution.TabIndex = 123;
            // 
            // checkBoxFullScreenEnabled
            // 
            this.checkBoxFullScreenEnabled.Checked = true;
            this.checkBoxFullScreenEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFullScreenEnabled.AutoSize = true;
            this.checkBoxFullScreenEnabled.Location = new System.Drawing.Point(545, 237);
            this.checkBoxFullScreenEnabled.Name = "checkBoxFullScreenEnabled";
            this.checkBoxFullScreenEnabled.TabIndex = 124;
            this.checkBoxFullScreenEnabled.Text = "Full Screen";
            this.checkBoxFullScreenEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxHardwareCursor
            // 
            this.checkBoxHardwareCursor.Checked = true;
            this.checkBoxHardwareCursor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHardwareCursor.AutoSize = true;
            this.checkBoxHardwareCursor.Location = new System.Drawing.Point(545, 273);
            this.checkBoxHardwareCursor.Name = "checkBoxHardwareCursor";
            this.checkBoxHardwareCursor.TabIndex = 125;
            this.checkBoxHardwareCursor.Text = "Enable Hardware Cursor";
            this.checkBoxHardwareCursor.UseVisualStyleBackColor = true;
            // 
            // buttonResetSettings
            // 
            this.buttonResetSettings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonResetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetSettings.Location = new System.Drawing.Point(8, 306);
            this.buttonResetSettings.Name = "buttonResetSettings";
            this.buttonResetSettings.Size = new System.Drawing.Size(684, 36);
            this.buttonResetSettings.TabIndex = 126;
            this.buttonResetSettings.Text = "Reset to Defaults";
            this.buttonResetSettings.UseVisualStyleBackColor = false;
            this.buttonResetSettings.Click += new System.EventHandler(this.ResetSettingsButton_Click);
            // 
            // tabAudio
            // 
            this.tabAudio.Controls.Add(this.labelMasterVolume);
            this.tabAudio.Controls.Add(this.sliderMasterVolume);
            this.tabAudio.Controls.Add(this.labelAmbientVolume);
            this.tabAudio.Controls.Add(this.sliderAmbientVolume);
            this.tabAudio.Controls.Add(this.labelSFXVolume);
            this.tabAudio.Controls.Add(this.sliderSFXVolume);
            this.tabAudio.Controls.Add(this.labelLocomotionVolume);
            this.tabAudio.Controls.Add(this.sliderLocomotionVolume);
            this.tabAudio.Controls.Add(this.labelUISFXVolume);
            this.tabAudio.Controls.Add(this.sliderUISFXVolume);
            this.tabAudio.Controls.Add(this.labelMusicVolume);
            this.tabAudio.Controls.Add(this.sliderMusicVolume);
            this.tabAudio.Controls.Add(this.labelCombatMusicVolume);
            this.tabAudio.Controls.Add(this.sliderCombatMusicVolume);
            this.tabAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabAudio.Location = new System.Drawing.Point(4, 36);
            this.tabAudio.Name = "tabAudio";
            this.tabAudio.Size = new System.Drawing.Size(700, 352);
            this.tabAudio.TabIndex = 2;
            this.tabAudio.Text = "Audio";
            // 
            // labelMasterVolume
            // 
            this.labelMasterVolume.AutoSize = true;
            this.labelMasterVolume.Location = new System.Drawing.Point(14, 22);
            this.labelMasterVolume.Name = "labelMasterVolume";
            this.labelMasterVolume.Size = new System.Drawing.Size(80, 13);
            this.labelMasterVolume.TabIndex = 200;
            this.labelMasterVolume.Text = "Master Volume:";
            // 
            // sliderMasterVolume
            // 
            this.sliderMasterVolume.Location = new System.Drawing.Point(130, 18);
            this.sliderMasterVolume.Maximum = 100;
            this.sliderMasterVolume.Name = "sliderMasterVolume";
            this.sliderMasterVolume.Size = new System.Drawing.Size(200, 45);
            this.sliderMasterVolume.TabIndex = 201;
            this.sliderMasterVolume.Value = 100;
            // 
            // labelAmbientVolume
            // 
            this.labelAmbientVolume.AutoSize = true;
            this.labelAmbientVolume.Location = new System.Drawing.Point(14, 68);
            this.labelAmbientVolume.Name = "labelAmbientVolume";
            this.labelAmbientVolume.Size = new System.Drawing.Size(86, 13);
            this.labelAmbientVolume.TabIndex = 202;
            this.labelAmbientVolume.Text = "Ambient Volume:";
            // 
            // sliderAmbientVolume
            // 
            this.sliderAmbientVolume.Location = new System.Drawing.Point(130, 64);
            this.sliderAmbientVolume.Maximum = 100;
            this.sliderAmbientVolume.Name = "sliderAmbientVolume";
            this.sliderAmbientVolume.Size = new System.Drawing.Size(200, 45);
            this.sliderAmbientVolume.TabIndex = 203;
            this.sliderAmbientVolume.Value = 100;
            // 
            // labelSFXVolume
            // 
            this.labelSFXVolume.AutoSize = true;
            this.labelSFXVolume.Location = new System.Drawing.Point(14, 114);
            this.labelSFXVolume.Name = "labelSFXVolume";
            this.labelSFXVolume.Size = new System.Drawing.Size(68, 13);
            this.labelSFXVolume.TabIndex = 204;
            this.labelSFXVolume.Text = "SFX Volume:";
            // 
            // sliderSFXVolume
            // 
            this.sliderSFXVolume.Location = new System.Drawing.Point(130, 110);
            this.sliderSFXVolume.Maximum = 100;
            this.sliderSFXVolume.Name = "sliderSFXVolume";
            this.sliderSFXVolume.Size = new System.Drawing.Size(200, 45);
            this.sliderSFXVolume.TabIndex = 205;
            this.sliderSFXVolume.Value = 100;
            // 
            // labelLocomotionVolume
            // 
            this.labelLocomotionVolume.AutoSize = true;
            this.labelLocomotionVolume.Location = new System.Drawing.Point(14, 160);
            this.labelLocomotionVolume.Name = "labelLocomotionVolume";
            this.labelLocomotionVolume.Size = new System.Drawing.Size(103, 13);
            this.labelLocomotionVolume.TabIndex = 206;
            this.labelLocomotionVolume.Text = "Locomotion Volume:";
            // 
            // sliderLocomotionVolume
            // 
            this.sliderLocomotionVolume.Location = new System.Drawing.Point(130, 156);
            this.sliderLocomotionVolume.Maximum = 100;
            this.sliderLocomotionVolume.Name = "sliderLocomotionVolume";
            this.sliderLocomotionVolume.Size = new System.Drawing.Size(200, 45);
            this.sliderLocomotionVolume.TabIndex = 207;
            this.sliderLocomotionVolume.Value = 100;
            // 
            // labelUISFXVolume
            // 
            this.labelUISFXVolume.AutoSize = true;
            this.labelUISFXVolume.Location = new System.Drawing.Point(14, 206);
            this.labelUISFXVolume.Name = "labelUISFXVolume";
            this.labelUISFXVolume.Size = new System.Drawing.Size(82, 13);
            this.labelUISFXVolume.TabIndex = 208;
            this.labelUISFXVolume.Text = "UI SFX Volume:";
            // 
            // sliderUISFXVolume
            // 
            this.sliderUISFXVolume.Location = new System.Drawing.Point(130, 202);
            this.sliderUISFXVolume.Maximum = 100;
            this.sliderUISFXVolume.Name = "sliderUISFXVolume";
            this.sliderUISFXVolume.Size = new System.Drawing.Size(200, 45);
            this.sliderUISFXVolume.TabIndex = 209;
            this.sliderUISFXVolume.Value = 100;
            // 
            // labelMusicVolume
            // 
            this.labelMusicVolume.AutoSize = true;
            this.labelMusicVolume.Location = new System.Drawing.Point(14, 252);
            this.labelMusicVolume.Name = "labelMusicVolume";
            this.labelMusicVolume.Size = new System.Drawing.Size(76, 13);
            this.labelMusicVolume.TabIndex = 210;
            this.labelMusicVolume.Text = "Music Volume:";
            // 
            // sliderMusicVolume
            // 
            this.sliderMusicVolume.Location = new System.Drawing.Point(130, 248);
            this.sliderMusicVolume.Maximum = 100;
            this.sliderMusicVolume.Name = "sliderMusicVolume";
            this.sliderMusicVolume.Size = new System.Drawing.Size(200, 45);
            this.sliderMusicVolume.TabIndex = 211;
            this.sliderMusicVolume.Value = 100;
            // 
            // labelCombatMusicVolume
            // 
            this.labelCombatMusicVolume.AutoSize = true;
            this.labelCombatMusicVolume.Location = new System.Drawing.Point(14, 298);
            this.labelCombatMusicVolume.Name = "labelCombatMusicVolume";
            this.labelCombatMusicVolume.Size = new System.Drawing.Size(115, 13);
            this.labelCombatMusicVolume.TabIndex = 212;
            this.labelCombatMusicVolume.Text = "Combat Music Volume:";
            // 
            // sliderCombatMusicVolume
            // 
            this.sliderCombatMusicVolume.Location = new System.Drawing.Point(130, 294);
            this.sliderCombatMusicVolume.Maximum = 100;
            this.sliderCombatMusicVolume.Name = "sliderCombatMusicVolume";
            this.sliderCombatMusicVolume.Size = new System.Drawing.Size(200, 45);
            this.sliderCombatMusicVolume.TabIndex = 213;
            this.sliderCombatMusicVolume.Value = 100;
            // 
            // tabUI
            // 
            this.tabUI.Controls.Add(this.label1);
            this.tabUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabUI.Location = new System.Drawing.Point(4, 36);
            this.tabUI.Name = "tabUI";
            this.tabUI.Size = new System.Drawing.Size(700, 352);
            this.tabUI.TabIndex = 3;
            this.tabUI.Text = "UI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 55);
            this.label1.TabIndex = 300;
            this.label1.Text = "Not Yet Implemented";
            // 
            // tabFixes
            // 
            this.tabFixes.Controls.Add(this.buttonClearShaderCache);
            this.tabFixes.Controls.Add(this.labelClearShaderCache);
            this.tabFixes.Controls.Add(this.buttonDisableScaling);
            this.tabFixes.Controls.Add(this.labelDisableScaling);
            this.tabFixes.Controls.Add(this.buttonCrashLogs);
            this.tabFixes.Controls.Add(this.buttonResetChatColors);
            this.tabFixes.Controls.Add(this.labelResetChatColors);
            this.tabFixes.Controls.Add(this.linkLabelCrashLogs);
            this.tabFixes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabFixes.Location = new System.Drawing.Point(4, 36);
            this.tabFixes.Name = "tabFixes";
            this.tabFixes.Size = new System.Drawing.Size(700, 352);
            this.tabFixes.TabIndex = 4;
            this.tabFixes.Text = "Fixes";
            // 
            // buttonResetChatColors
            // 
            this.buttonResetChatColors.Location = new System.Drawing.Point(9, 10);
            this.buttonResetChatColors.Name = "buttonResetChatColors";
            this.buttonResetChatColors.Size = new System.Drawing.Size(240, 48);
            this.buttonResetChatColors.TabIndex = 400;
            this.buttonResetChatColors.Text = "Reset Chat Colors";
            this.buttonResetChatColors.UseVisualStyleBackColor = true;
            this.buttonResetChatColors.Click += new System.EventHandler(this.ResetChatColorsButton_Click);
            // 
            // labelResetChatColors
            // 
            this.labelResetChatColors.Location = new System.Drawing.Point(255, 12);
            this.labelResetChatColors.MaximumSize = new System.Drawing.Size(420, 48);
            this.labelResetChatColors.Name = "labelResetChatColors";
            this.labelResetChatColors.Size = new System.Drawing.Size(420, 48);
            this.labelResetChatColors.TabIndex = 401;
            this.labelResetChatColors.Text = "ChatColors.json will be deleted and your chat colors will be reset on next launch" +
    ". Fixes issues with chat turning black.";
            // 
            // buttonDisableScaling
            // 
            this.buttonDisableScaling.Location = new System.Drawing.Point(9, 68);
            this.buttonDisableScaling.Name = "buttonDisableScaling";
            this.buttonDisableScaling.Size = new System.Drawing.Size(240, 48);
            this.buttonDisableScaling.TabIndex = 402;
            this.buttonDisableScaling.Text = "Disable DLSS/FSR2";
            this.buttonDisableScaling.UseVisualStyleBackColor = true;
            this.buttonDisableScaling.Click += new System.EventHandler(this.DisableScalingButton_Click);
            // 
            // labelDisableScaling
            // 
            this.labelDisableScaling.Location = new System.Drawing.Point(255, 70);
            this.labelDisableScaling.MaximumSize = new System.Drawing.Size(420, 48);
            this.labelDisableScaling.Name = "labelDisableScaling";
            this.labelDisableScaling.Size = new System.Drawing.Size(420, 48);
            this.labelDisableScaling.TabIndex = 403;
            this.labelDisableScaling.Text = "Settings.json will be edited and the values for DynamicResolution and AllowFSR2 w" +
    "ill be set to 0. Fixes crashes on login for players with AMD (and 10/16/GTX TITA" +
    "N series Nvidia) GPUs.";
            // 
            // buttonClearShaderCache
            // 
            this.buttonClearShaderCache.Location = new System.Drawing.Point(9, 126);
            this.buttonClearShaderCache.Name = "buttonClearShaderCache";
            this.buttonClearShaderCache.Size = new System.Drawing.Size(240, 48);
            this.buttonClearShaderCache.TabIndex = 404;
            this.buttonClearShaderCache.Text = "Clear Shader Cache";
            this.buttonClearShaderCache.UseVisualStyleBackColor = true;
            this.buttonClearShaderCache.Click += new System.EventHandler(this.ClearShaderCacheButton_Click);
            // 
            // labelClearShaderCache
            // 
            this.labelClearShaderCache.Location = new System.Drawing.Point(255, 128);
            this.labelClearShaderCache.MaximumSize = new System.Drawing.Size(420, 48);
            this.labelClearShaderCache.Name = "labelClearShaderCache";
            this.labelClearShaderCache.Size = new System.Drawing.Size(420, 48);
            this.labelClearShaderCache.TabIndex = 405;
            this.labelClearShaderCache.Text = "Attempts to entirely clear shader cache. This may help with stutter and possibly " +
    "resolve some crashes.";
            // 
            // buttonCrashLogs
            // 
            this.buttonCrashLogs.Location = new System.Drawing.Point(9, 294);
            this.buttonCrashLogs.Name = "buttonCrashLogs";
            this.buttonCrashLogs.Size = new System.Drawing.Size(240, 48);
            this.buttonCrashLogs.TabIndex = 406;
            this.buttonCrashLogs.Text = "Open Crash Log Folder";
            this.buttonCrashLogs.UseVisualStyleBackColor = true;
            this.buttonCrashLogs.Click += new System.EventHandler(this.CrashLogsButton_Click);
            // 
            // linkLabelCrashLogs
            // 
            this.linkLabelCrashLogs.LinkArea = new System.Windows.Forms.LinkArea(13, 27);
            this.linkLabelCrashLogs.Location = new System.Drawing.Point(258, 296);
            this.linkLabelCrashLogs.MaximumSize = new System.Drawing.Size(420, 48);
            this.linkLabelCrashLogs.Name = "linkLabelCrashLogs";
            this.linkLabelCrashLogs.Size = new System.Drawing.Size(420, 48);
            this.linkLabelCrashLogs.TabIndex = 407;
            this.linkLabelCrashLogs.TabStop = true;
            this.linkLabelCrashLogs.Text = "Please email support@visionaryrealms.com with any details you may have about unre" +
    "solved crashes, along with a file attachment of an archive of your related logs." +
    "";
            this.linkLabelCrashLogs.UseCompatibleTextRendering = true;
            this.linkLabelCrashLogs.Links.Clear();
            this.linkLabelCrashLogs.Links.Add(13, 27, "mailto:support@visionaryrealms.com");
            this.linkLabelCrashLogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CrashLogsLinkLabel_LinkClicked);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 392);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(708, 150);
            this.textBox.TabIndex = 1000;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(708, 542);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Pantheon Support Tool";

            this.tabControl.ResumeLayout(false);

            this.tabGraphics.ResumeLayout(false);
            this.tabGraphics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLODDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderClipDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderShadowDrawDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderNameplateDistance)).EndInit();

            this.tabAudio.ResumeLayout(false);
            this.tabAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMasterVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAmbientVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSFXVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLocomotionVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderUISFXVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMusicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderCombatMusicVolume)).EndInit();

            this.tabUI.ResumeLayout(false);

            this.tabUI.PerformLayout();

            this.tabFixes.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TabControl tabControl;

        private TabPage tabGraphics;
        private Label labelLODDistance;
        private TrackBar sliderLODDistance;
        private Label labelClipDistance;
        private TrackBar sliderClipDistance;
        private Label labelShadowDistance;
        private TrackBar sliderShadowDrawDistance;
        private Label labelNameplateDistance;
        private TrackBar sliderNameplateDistance;
        private Label labelShowMyNameplate;
        private CheckBox checkBoxShowMyNameplate;
        private Label labelDynamicResolution;
        private CheckBox checkBoxDynamicResolution;
        private Label labelAllowFSR2;
        private CheckBox checkBoxAllowFSR2;
        private Label labelAntiAliasing;
        private ComboBox comboBoxAntiAliasing;
        private Label labelQualityLevel;
        private ComboBox comboBoxQualityLevel;
        private Label labelAllowAmbientOcclusion;
        private CheckBox checkBoxAllowAmbientOcclusion;
        private Label labelDisableSky;
        private CheckBox checkBoxDisableSky;
        private Label labelDetailMeshes;
        private CheckBox checkBoxDetailMeshes;
        private Label labelDisplayMonitor;
        private ComboBox comboBoxDisplayMonitor;
        private Label labelVSync;
        private ComboBox comboBoxVSync;
        private Label labelResolution;
        private ComboBox comboBoxResolution;
        private Label labelFullScreenEnabled;
        private CheckBox checkBoxFullScreenEnabled;
        private Label labelHardwareCursor;
        private CheckBox checkBoxHardwareCursor;

        private TabPage tabAudio;
        private Label labelMasterVolume;
        private TrackBar sliderMasterVolume;
        private Label labelAmbientVolume;
        private TrackBar sliderAmbientVolume;
        private Label labelSFXVolume;
        private TrackBar sliderSFXVolume;
        private Label labelLocomotionVolume;
        private TrackBar sliderLocomotionVolume;
        private Label labelUISFXVolume;
        private TrackBar sliderUISFXVolume;
        private Label labelMusicVolume;
        private TrackBar sliderMusicVolume;
        private Label labelCombatMusicVolume;
        private TrackBar sliderCombatMusicVolume;

        private TabPage tabUI;
        private Label label1;

        private TabPage tabFixes;
        private Button buttonResetChatColors;
        private Label labelResetChatColors;
        private Button buttonResetSettings;
        private Button buttonDisableScaling;
        private Label labelDisableScaling;
        private Button buttonClearShaderCache;
        private Label labelClearShaderCache;
        private Button buttonCrashLogs;
        private LinkLabel linkLabelCrashLogs;

        private TextBox textBox;
    }
}
