namespace GridIt
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TableLayoutPanel panelFullGrid;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.numGridOffsetX = new System.Windows.Forms.NumericUpDown();
            this.lblGridColor = new System.Windows.Forms.Label();
            this.numGridOffsetY = new System.Windows.Forms.NumericUpDown();
            this.numGridSizeX = new System.Windows.Forms.NumericUpDown();
            this.numGridSizeY = new System.Windows.Forms.NumericUpDown();
            this.numGridThickness = new System.Windows.Forms.NumericUpDown();
            this.lblGridOffsetX = new System.Windows.Forms.Label();
            this.lblGridOffsetY = new System.Windows.Forms.Label();
            this.lblGridSizeX = new System.Windows.Forms.Label();
            this.lblGridSizeY = new System.Windows.Forms.Label();
            this.lblGridThickness = new System.Windows.Forms.Label();
            this.lblGridColorLbl = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnApply = new System.Windows.Forms.Button();
            this.tabGuiContainer = new System.Windows.Forms.TabControl();
            this.tabFullGrid = new System.Windows.Forms.TabPage();
            this.btnOnOffFullGrid = new System.Windows.Forms.Button();
            this.tabCrosshair = new System.Windows.Forms.TabPage();
            this.panelCrosshair = new System.Windows.Forms.TableLayoutPanel();
            this.lblCrosshairThickness = new System.Windows.Forms.Label();
            this.numCrosshairThickness = new System.Windows.Forms.NumericUpDown();
            this.lblCrosshairColorLbl = new System.Windows.Forms.Label();
            this.lblCrosshairColor = new System.Windows.Forms.Label();
            this.btnOnOffCrosshair = new System.Windows.Forms.Button();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblGitHub = new System.Windows.Forms.LinkLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.cbxWindowsStartup = new System.Windows.Forms.CheckBox();
            this.tabMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.colorDialogGrid = new System.Windows.Forms.ColorDialog();
            panelFullGrid = new System.Windows.Forms.TableLayoutPanel();
            panelFullGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridThickness)).BeginInit();
            this.tabGuiContainer.SuspendLayout();
            this.tabFullGrid.SuspendLayout();
            this.tabCrosshair.SuspendLayout();
            this.panelCrosshair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrosshairThickness)).BeginInit();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFullGrid
            // 
            panelFullGrid.AutoSize = true;
            panelFullGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelFullGrid.ColumnCount = 2;
            panelFullGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelFullGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelFullGrid.Controls.Add(this.numGridOffsetX, 1, 0);
            panelFullGrid.Controls.Add(this.lblGridColor, 1, 5);
            panelFullGrid.Controls.Add(this.numGridOffsetY, 1, 1);
            panelFullGrid.Controls.Add(this.numGridSizeX, 1, 2);
            panelFullGrid.Controls.Add(this.numGridSizeY, 1, 3);
            panelFullGrid.Controls.Add(this.numGridThickness, 1, 4);
            panelFullGrid.Controls.Add(this.lblGridOffsetX, 0, 0);
            panelFullGrid.Controls.Add(this.lblGridOffsetY, 0, 1);
            panelFullGrid.Controls.Add(this.lblGridSizeX, 0, 2);
            panelFullGrid.Controls.Add(this.lblGridSizeY, 0, 3);
            panelFullGrid.Controls.Add(this.lblGridThickness, 0, 4);
            panelFullGrid.Controls.Add(this.lblGridColorLbl, 0, 5);
            panelFullGrid.Dock = System.Windows.Forms.DockStyle.Top;
            panelFullGrid.Location = new System.Drawing.Point(3, 3);
            panelFullGrid.Name = "panelFullGrid";
            panelFullGrid.RowCount = 6;
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            panelFullGrid.Size = new System.Drawing.Size(189, 156);
            panelFullGrid.TabIndex = 4;
            // 
            // numGridOffsetX
            // 
            this.numGridOffsetX.AutoSize = true;
            this.numGridOffsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridOffsetX.Location = new System.Drawing.Point(97, 3);
            this.numGridOffsetX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGridOffsetX.Name = "numGridOffsetX";
            this.numGridOffsetX.Size = new System.Drawing.Size(89, 20);
            this.numGridOffsetX.TabIndex = 1;
            this.numGridOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGridColor
            // 
            this.lblGridColor.AutoSize = true;
            this.lblGridColor.BackColor = System.Drawing.Color.Maroon;
            this.lblGridColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGridColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridColor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGridColor.Location = new System.Drawing.Point(97, 128);
            this.lblGridColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblGridColor.MinimumSize = new System.Drawing.Size(2, 20);
            this.lblGridColor.Name = "lblGridColor";
            this.lblGridColor.Size = new System.Drawing.Size(89, 25);
            this.lblGridColor.TabIndex = 11;
            this.lblGridColor.Click += new System.EventHandler(this.LblGridColor_Click);
            // 
            // numGridOffsetY
            // 
            this.numGridOffsetY.AutoSize = true;
            this.numGridOffsetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridOffsetY.Location = new System.Drawing.Point(97, 28);
            this.numGridOffsetY.Name = "numGridOffsetY";
            this.numGridOffsetY.Size = new System.Drawing.Size(89, 20);
            this.numGridOffsetY.TabIndex = 3;
            this.numGridOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numGridSizeX
            // 
            this.numGridSizeX.AutoSize = true;
            this.numGridSizeX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridSizeX.Location = new System.Drawing.Point(97, 53);
            this.numGridSizeX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGridSizeX.Name = "numGridSizeX";
            this.numGridSizeX.Size = new System.Drawing.Size(89, 20);
            this.numGridSizeX.TabIndex = 5;
            this.numGridSizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numGridSizeY
            // 
            this.numGridSizeY.AutoSize = true;
            this.numGridSizeY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridSizeY.Location = new System.Drawing.Point(97, 78);
            this.numGridSizeY.Name = "numGridSizeY";
            this.numGridSizeY.Size = new System.Drawing.Size(89, 20);
            this.numGridSizeY.TabIndex = 7;
            this.numGridSizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numGridThickness
            // 
            this.numGridThickness.AutoSize = true;
            this.numGridThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridThickness.Location = new System.Drawing.Point(97, 103);
            this.numGridThickness.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numGridThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGridThickness.Name = "numGridThickness";
            this.numGridThickness.Size = new System.Drawing.Size(89, 20);
            this.numGridThickness.TabIndex = 9;
            this.numGridThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numGridThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGridOffsetX
            // 
            this.lblGridOffsetX.AutoSize = true;
            this.lblGridOffsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridOffsetX.Location = new System.Drawing.Point(3, 0);
            this.lblGridOffsetX.Name = "lblGridOffsetX";
            this.lblGridOffsetX.Size = new System.Drawing.Size(88, 25);
            this.lblGridOffsetX.TabIndex = 0;
            this.lblGridOffsetX.Text = "Horizontal offset";
            this.lblGridOffsetX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridOffsetY
            // 
            this.lblGridOffsetY.AutoSize = true;
            this.lblGridOffsetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridOffsetY.Location = new System.Drawing.Point(3, 25);
            this.lblGridOffsetY.Name = "lblGridOffsetY";
            this.lblGridOffsetY.Size = new System.Drawing.Size(88, 25);
            this.lblGridOffsetY.TabIndex = 2;
            this.lblGridOffsetY.Text = "Vertical offset";
            this.lblGridOffsetY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridSizeX
            // 
            this.lblGridSizeX.AutoSize = true;
            this.lblGridSizeX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridSizeX.Location = new System.Drawing.Point(3, 50);
            this.lblGridSizeX.Name = "lblGridSizeX";
            this.lblGridSizeX.Size = new System.Drawing.Size(88, 25);
            this.lblGridSizeX.TabIndex = 4;
            this.lblGridSizeX.Text = "Horizontal size";
            this.lblGridSizeX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridSizeY
            // 
            this.lblGridSizeY.AutoSize = true;
            this.lblGridSizeY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridSizeY.Location = new System.Drawing.Point(3, 75);
            this.lblGridSizeY.Name = "lblGridSizeY";
            this.lblGridSizeY.Size = new System.Drawing.Size(88, 25);
            this.lblGridSizeY.TabIndex = 6;
            this.lblGridSizeY.Text = "Vertical size";
            this.lblGridSizeY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridThickness
            // 
            this.lblGridThickness.AutoSize = true;
            this.lblGridThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridThickness.Location = new System.Drawing.Point(3, 100);
            this.lblGridThickness.Name = "lblGridThickness";
            this.lblGridThickness.Size = new System.Drawing.Size(88, 25);
            this.lblGridThickness.TabIndex = 8;
            this.lblGridThickness.Text = "Line thickness";
            this.lblGridThickness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridColorLbl
            // 
            this.lblGridColorLbl.AutoSize = true;
            this.lblGridColorLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridColorLbl.Location = new System.Drawing.Point(3, 125);
            this.lblGridColorLbl.Name = "lblGridColorLbl";
            this.lblGridColorLbl.Size = new System.Drawing.Size(88, 31);
            this.lblGridColorLbl.TabIndex = 10;
            this.lblGridColorLbl.Text = "Line color";
            this.lblGridColorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "GridIt";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.Location = new System.Drawing.Point(0, 211);
            this.btnApply.Margin = new System.Windows.Forms.Padding(0);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(102, 30);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // tabGuiContainer
            // 
            this.tabMainPanel.SetColumnSpan(this.tabGuiContainer, 2);
            this.tabGuiContainer.Controls.Add(this.tabFullGrid);
            this.tabGuiContainer.Controls.Add(this.tabCrosshair);
            this.tabGuiContainer.Controls.Add(this.tabAbout);
            this.tabGuiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGuiContainer.ItemSize = new System.Drawing.Size(65, 18);
            this.tabGuiContainer.Location = new System.Drawing.Point(1, 1);
            this.tabGuiContainer.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.tabGuiContainer.Name = "tabGuiContainer";
            this.tabGuiContainer.Padding = new System.Drawing.Point(3, 3);
            this.tabGuiContainer.SelectedIndex = 0;
            this.tabGuiContainer.Size = new System.Drawing.Size(203, 210);
            this.tabGuiContainer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGuiContainer.TabIndex = 0;
            // 
            // tabFullGrid
            // 
            this.tabFullGrid.Controls.Add(this.btnOnOffFullGrid);
            this.tabFullGrid.Controls.Add(panelFullGrid);
            this.tabFullGrid.Location = new System.Drawing.Point(4, 22);
            this.tabFullGrid.Name = "tabFullGrid";
            this.tabFullGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabFullGrid.Size = new System.Drawing.Size(195, 184);
            this.tabFullGrid.TabIndex = 0;
            this.tabFullGrid.Text = "Full Grid";
            this.tabFullGrid.UseVisualStyleBackColor = true;
            // 
            // btnOnOffFullGrid
            // 
            this.btnOnOffFullGrid.AutoSize = true;
            this.btnOnOffFullGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOnOffFullGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOnOffFullGrid.Location = new System.Drawing.Point(3, 159);
            this.btnOnOffFullGrid.Margin = new System.Windows.Forms.Padding(0);
            this.btnOnOffFullGrid.Name = "btnOnOffFullGrid";
            this.btnOnOffFullGrid.Size = new System.Drawing.Size(189, 22);
            this.btnOnOffFullGrid.TabIndex = 12;
            this.btnOnOffFullGrid.Text = "Show Grid (Ctrl + 1)";
            this.btnOnOffFullGrid.UseVisualStyleBackColor = true;
            this.btnOnOffFullGrid.Click += new System.EventHandler(this.BtnOnOffFullGrid_Click);
            // 
            // tabCrosshair
            // 
            this.tabCrosshair.Controls.Add(this.panelCrosshair);
            this.tabCrosshair.Location = new System.Drawing.Point(4, 22);
            this.tabCrosshair.Name = "tabCrosshair";
            this.tabCrosshair.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrosshair.Size = new System.Drawing.Size(195, 184);
            this.tabCrosshair.TabIndex = 1;
            this.tabCrosshair.Text = "Crosshair";
            this.tabCrosshair.UseVisualStyleBackColor = true;
            // 
            // panelCrosshair
            // 
            this.panelCrosshair.ColumnCount = 2;
            this.panelCrosshair.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCrosshair.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCrosshair.Controls.Add(this.lblCrosshairThickness, 0, 0);
            this.panelCrosshair.Controls.Add(this.numCrosshairThickness, 1, 0);
            this.panelCrosshair.Controls.Add(this.lblCrosshairColorLbl, 0, 1);
            this.panelCrosshair.Controls.Add(this.lblCrosshairColor, 1, 1);
            this.panelCrosshair.Controls.Add(this.btnOnOffCrosshair, 0, 6);
            this.panelCrosshair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrosshair.Location = new System.Drawing.Point(3, 3);
            this.panelCrosshair.Name = "panelCrosshair";
            this.panelCrosshair.RowCount = 7;
            this.panelCrosshair.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelCrosshair.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelCrosshair.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelCrosshair.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelCrosshair.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelCrosshair.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelCrosshair.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelCrosshair.Size = new System.Drawing.Size(189, 178);
            this.panelCrosshair.TabIndex = 0;
            // 
            // lblCrosshairThickness
            // 
            this.lblCrosshairThickness.AutoSize = true;
            this.lblCrosshairThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCrosshairThickness.Location = new System.Drawing.Point(3, 0);
            this.lblCrosshairThickness.Name = "lblCrosshairThickness";
            this.lblCrosshairThickness.Size = new System.Drawing.Size(88, 26);
            this.lblCrosshairThickness.TabIndex = 0;
            this.lblCrosshairThickness.Text = "Line thickness";
            this.lblCrosshairThickness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numCrosshairThickness
            // 
            this.numCrosshairThickness.AutoSize = true;
            this.numCrosshairThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCrosshairThickness.Location = new System.Drawing.Point(97, 3);
            this.numCrosshairThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCrosshairThickness.Name = "numCrosshairThickness";
            this.numCrosshairThickness.Size = new System.Drawing.Size(89, 20);
            this.numCrosshairThickness.TabIndex = 1;
            this.numCrosshairThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCrosshairThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCrosshairColorLbl
            // 
            this.lblCrosshairColorLbl.AutoSize = true;
            this.lblCrosshairColorLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCrosshairColorLbl.Location = new System.Drawing.Point(3, 26);
            this.lblCrosshairColorLbl.Name = "lblCrosshairColorLbl";
            this.lblCrosshairColorLbl.Size = new System.Drawing.Size(88, 26);
            this.lblCrosshairColorLbl.TabIndex = 2;
            this.lblCrosshairColorLbl.Text = "Line collor";
            this.lblCrosshairColorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCrosshairColor
            // 
            this.lblCrosshairColor.AutoSize = true;
            this.lblCrosshairColor.BackColor = System.Drawing.Color.Cyan;
            this.lblCrosshairColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrosshairColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCrosshairColor.Location = new System.Drawing.Point(97, 29);
            this.lblCrosshairColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblCrosshairColor.Name = "lblCrosshairColor";
            this.lblCrosshairColor.Size = new System.Drawing.Size(89, 20);
            this.lblCrosshairColor.TabIndex = 3;
            this.lblCrosshairColor.Click += new System.EventHandler(this.LblCrosshairColor_Click);
            // 
            // btnOnOffCrosshair
            // 
            this.panelCrosshair.SetColumnSpan(this.btnOnOffCrosshair, 2);
            this.btnOnOffCrosshair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOnOffCrosshair.Location = new System.Drawing.Point(0, 156);
            this.btnOnOffCrosshair.Margin = new System.Windows.Forms.Padding(0);
            this.btnOnOffCrosshair.Name = "btnOnOffCrosshair";
            this.btnOnOffCrosshair.Size = new System.Drawing.Size(189, 22);
            this.btnOnOffCrosshair.TabIndex = 4;
            this.btnOnOffCrosshair.Text = "Show Crosshair (Ctrl + 2)";
            this.btnOnOffCrosshair.UseVisualStyleBackColor = true;
            this.btnOnOffCrosshair.Click += new System.EventHandler(this.BtnOnOffCrosshair_Click);
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lblGitHub);
            this.tabAbout.Controls.Add(this.picLogo);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(195, 184);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGitHub.Location = new System.Drawing.Point(17, 149);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(161, 20);
            this.lblGitHub.TabIndex = 0;
            this.lblGitHub.TabStop = true;
            this.lblGitHub.Text = "github.com/dkopec91";
            this.lblGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGitHub_LinkClicked);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::GridIt.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(195, 184);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveSettings.Location = new System.Drawing.Point(102, 211);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(102, 30);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // cbxWindowsStartup
            // 
            this.cbxWindowsStartup.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxWindowsStartup.AutoSize = true;
            this.tabMainPanel.SetColumnSpan(this.cbxWindowsStartup, 2);
            this.cbxWindowsStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxWindowsStartup.Location = new System.Drawing.Point(0, 241);
            this.cbxWindowsStartup.Margin = new System.Windows.Forms.Padding(0);
            this.cbxWindowsStartup.Name = "cbxWindowsStartup";
            this.cbxWindowsStartup.Size = new System.Drawing.Size(204, 30);
            this.cbxWindowsStartup.TabIndex = 3;
            this.cbxWindowsStartup.Text = "Click to run GridIt on system startup";
            this.cbxWindowsStartup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxWindowsStartup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cbxWindowsStartup.UseVisualStyleBackColor = true;
            this.cbxWindowsStartup.CheckedChanged += new System.EventHandler(this.CbxWindowsStartup_CheckedChanged);
            // 
            // tabMainPanel
            // 
            this.tabMainPanel.ColumnCount = 2;
            this.tabMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabMainPanel.Controls.Add(this.cbxWindowsStartup, 0, 2);
            this.tabMainPanel.Controls.Add(this.btnSaveSettings, 1, 1);
            this.tabMainPanel.Controls.Add(this.tabGuiContainer, 0, 0);
            this.tabMainPanel.Controls.Add(this.btnApply, 0, 1);
            this.tabMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainPanel.Location = new System.Drawing.Point(0, 0);
            this.tabMainPanel.Name = "tabMainPanel";
            this.tabMainPanel.RowCount = 3;
            this.tabMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabMainPanel.Size = new System.Drawing.Size(204, 271);
            this.tabMainPanel.TabIndex = 3;
            // 
            // colorDialogGrid
            // 
            this.colorDialogGrid.AllowFullOpen = false;
            this.colorDialogGrid.Color = System.Drawing.Color.Red;
            this.colorDialogGrid.SolidColorOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 271);
            this.Controls.Add(this.tabMainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(220, 310);
            this.MinimumSize = new System.Drawing.Size(220, 310);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GridIt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridIt_FormClosing);
            this.Resize += new System.EventHandler(this.GridIt_Resize);
            panelFullGrid.ResumeLayout(false);
            panelFullGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridThickness)).EndInit();
            this.tabGuiContainer.ResumeLayout(false);
            this.tabFullGrid.ResumeLayout(false);
            this.tabFullGrid.PerformLayout();
            this.tabCrosshair.ResumeLayout(false);
            this.panelCrosshair.ResumeLayout(false);
            this.panelCrosshair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrosshairThickness)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabMainPanel.ResumeLayout(false);
            this.tabMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialogGrid;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabControl tabGuiContainer;
        private System.Windows.Forms.TableLayoutPanel tabMainPanel;
        private System.Windows.Forms.CheckBox cbxWindowsStartup;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.TabPage tabFullGrid;
        private System.Windows.Forms.Button btnOnOffFullGrid;
        private System.Windows.Forms.NumericUpDown numGridOffsetX;
        private System.Windows.Forms.Label lblGridColor;
        private System.Windows.Forms.NumericUpDown numGridOffsetY;
        private System.Windows.Forms.NumericUpDown numGridSizeX;
        private System.Windows.Forms.NumericUpDown numGridSizeY;
        private System.Windows.Forms.NumericUpDown numGridThickness;
        private System.Windows.Forms.Label lblGridOffsetX;
        private System.Windows.Forms.Label lblGridOffsetY;
        private System.Windows.Forms.Label lblGridSizeX;
        private System.Windows.Forms.Label lblGridSizeY;
        private System.Windows.Forms.Label lblGridThickness;
        private System.Windows.Forms.Label lblGridColorLbl;
        private System.Windows.Forms.TabPage tabCrosshair;
        private System.Windows.Forms.TableLayoutPanel panelCrosshair;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label lblCrosshairThickness;
        private System.Windows.Forms.NumericUpDown numCrosshairThickness;
        private System.Windows.Forms.Label lblCrosshairColorLbl;
        private System.Windows.Forms.Label lblCrosshairColor;
        private System.Windows.Forms.Button btnOnOffCrosshair;
        private System.Windows.Forms.LinkLabel lblGitHub;
        private System.Windows.Forms.PictureBox picLogo;
    }
}