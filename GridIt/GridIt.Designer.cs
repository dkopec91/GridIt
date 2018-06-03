namespace GridIt
{
    partial class GridIt
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
            System.Windows.Forms.TableLayoutPanel panelFullGrid;
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
            this.tabGuiContainer = new System.Windows.Forms.TabControl();
            this.tabFullGrid = new System.Windows.Forms.TabPage();
            this.btnOnOffFullGrid = new System.Windows.Forms.Button();
            this.tabCrosshair = new System.Windows.Forms.TabPage();
            this.tabRadialGrid = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblEmail = new System.Windows.Forms.Label();
            this.colorDialogGrid = new System.Windows.Forms.ColorDialog();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panelFullGrid = new System.Windows.Forms.TableLayoutPanel();
            panelFullGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridThickness)).BeginInit();
            this.tabGuiContainer.SuspendLayout();
            this.tabFullGrid.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            panelFullGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            this.numGridOffsetX.TabIndex = 4;
            this.numGridOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGridColor
            // 
            this.lblGridColor.AutoSize = true;
            this.lblGridColor.BackColor = System.Drawing.Color.Maroon;
            this.lblGridColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGridColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridColor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGridColor.Location = new System.Drawing.Point(97, 133);
            this.lblGridColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblGridColor.MinimumSize = new System.Drawing.Size(0, 20);
            this.lblGridColor.Name = "lblGridColor";
            this.lblGridColor.Size = new System.Drawing.Size(89, 20);
            this.lblGridColor.TabIndex = 2;
            this.lblGridColor.Click += new System.EventHandler(this.lblGridColor_Click);
            // 
            // numGridOffsetY
            // 
            this.numGridOffsetY.AutoSize = true;
            this.numGridOffsetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridOffsetY.Location = new System.Drawing.Point(97, 29);
            this.numGridOffsetY.Name = "numGridOffsetY";
            this.numGridOffsetY.Size = new System.Drawing.Size(89, 20);
            this.numGridOffsetY.TabIndex = 5;
            this.numGridOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numGridSizeX
            // 
            this.numGridSizeX.AutoSize = true;
            this.numGridSizeX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridSizeX.Location = new System.Drawing.Point(97, 55);
            this.numGridSizeX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGridSizeX.Name = "numGridSizeX";
            this.numGridSizeX.Size = new System.Drawing.Size(89, 20);
            this.numGridSizeX.TabIndex = 6;
            this.numGridSizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numGridSizeY
            // 
            this.numGridSizeY.AutoSize = true;
            this.numGridSizeY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridSizeY.Location = new System.Drawing.Point(97, 81);
            this.numGridSizeY.Name = "numGridSizeY";
            this.numGridSizeY.Size = new System.Drawing.Size(89, 20);
            this.numGridSizeY.TabIndex = 7;
            this.numGridSizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numGridThickness
            // 
            this.numGridThickness.AutoSize = true;
            this.numGridThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridThickness.Location = new System.Drawing.Point(97, 107);
            this.numGridThickness.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numGridThickness.Name = "numGridThickness";
            this.numGridThickness.Size = new System.Drawing.Size(89, 20);
            this.numGridThickness.TabIndex = 8;
            this.numGridThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGridOffsetX
            // 
            this.lblGridOffsetX.AutoSize = true;
            this.lblGridOffsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridOffsetX.Location = new System.Drawing.Point(3, 0);
            this.lblGridOffsetX.Name = "lblGridOffsetX";
            this.lblGridOffsetX.Size = new System.Drawing.Size(88, 26);
            this.lblGridOffsetX.TabIndex = 9;
            this.lblGridOffsetX.Text = "Horizontal offset";
            this.lblGridOffsetX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridOffsetY
            // 
            this.lblGridOffsetY.AutoSize = true;
            this.lblGridOffsetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridOffsetY.Location = new System.Drawing.Point(3, 26);
            this.lblGridOffsetY.Name = "lblGridOffsetY";
            this.lblGridOffsetY.Size = new System.Drawing.Size(88, 26);
            this.lblGridOffsetY.TabIndex = 10;
            this.lblGridOffsetY.Text = "Vertical offset";
            this.lblGridOffsetY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridSizeX
            // 
            this.lblGridSizeX.AutoSize = true;
            this.lblGridSizeX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridSizeX.Location = new System.Drawing.Point(3, 52);
            this.lblGridSizeX.Name = "lblGridSizeX";
            this.lblGridSizeX.Size = new System.Drawing.Size(88, 26);
            this.lblGridSizeX.TabIndex = 11;
            this.lblGridSizeX.Text = "Horizontal size";
            this.lblGridSizeX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridSizeY
            // 
            this.lblGridSizeY.AutoSize = true;
            this.lblGridSizeY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridSizeY.Location = new System.Drawing.Point(3, 78);
            this.lblGridSizeY.Name = "lblGridSizeY";
            this.lblGridSizeY.Size = new System.Drawing.Size(88, 26);
            this.lblGridSizeY.TabIndex = 12;
            this.lblGridSizeY.Text = "Vertical size";
            this.lblGridSizeY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridThickness
            // 
            this.lblGridThickness.AutoSize = true;
            this.lblGridThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridThickness.Location = new System.Drawing.Point(3, 104);
            this.lblGridThickness.Name = "lblGridThickness";
            this.lblGridThickness.Size = new System.Drawing.Size(88, 26);
            this.lblGridThickness.TabIndex = 13;
            this.lblGridThickness.Text = "Line thickness";
            this.lblGridThickness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGridColorLbl
            // 
            this.lblGridColorLbl.AutoSize = true;
            this.lblGridColorLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridColorLbl.Location = new System.Drawing.Point(3, 130);
            this.lblGridColorLbl.Name = "lblGridColorLbl";
            this.lblGridColorLbl.Size = new System.Drawing.Size(88, 26);
            this.lblGridColorLbl.TabIndex = 14;
            this.lblGridColorLbl.Text = "Line color";
            this.lblGridColorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabGuiContainer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabGuiContainer, 2);
            this.tabGuiContainer.Controls.Add(this.tabFullGrid);
            this.tabGuiContainer.Controls.Add(this.tabCrosshair);
            this.tabGuiContainer.Controls.Add(this.tabRadialGrid);
            this.tabGuiContainer.Controls.Add(this.tabAbout);
            this.tabGuiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGuiContainer.Location = new System.Drawing.Point(1, 1);
            this.tabGuiContainer.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.tabGuiContainer.Name = "tabGuiContainer";
            this.tabGuiContainer.Padding = new System.Drawing.Point(3, 3);
            this.tabGuiContainer.SelectedIndex = 0;
            this.tabGuiContainer.Size = new System.Drawing.Size(203, 210);
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
            this.btnOnOffFullGrid.TabIndex = 5;
            this.btnOnOffFullGrid.Text = "Show Grid";
            this.btnOnOffFullGrid.UseVisualStyleBackColor = true;
            this.btnOnOffFullGrid.Click += new System.EventHandler(this.btnOnOffFullGrid_Click);
            // 
            // tabCrosshair
            // 
            this.tabCrosshair.Location = new System.Drawing.Point(4, 22);
            this.tabCrosshair.Name = "tabCrosshair";
            this.tabCrosshair.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrosshair.Size = new System.Drawing.Size(196, 185);
            this.tabCrosshair.TabIndex = 1;
            this.tabCrosshair.Text = "Crosshair";
            this.tabCrosshair.UseVisualStyleBackColor = true;
            // 
            // tabRadialGrid
            // 
            this.tabRadialGrid.Location = new System.Drawing.Point(4, 22);
            this.tabRadialGrid.Name = "tabRadialGrid";
            this.tabRadialGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabRadialGrid.Size = new System.Drawing.Size(196, 185);
            this.tabRadialGrid.TabIndex = 2;
            this.tabRadialGrid.Text = "Radial Grid";
            this.tabRadialGrid.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lblEmail);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(196, 185);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(0, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(196, 185);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "dkopec91@gmail.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorDialogGrid
            // 
            this.colorDialogGrid.AllowFullOpen = false;
            this.colorDialogGrid.Color = global::GridIt.Properties.Settings.Default.ColorGrid;
            this.colorDialogGrid.SolidColorOnly = true;
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
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveSettings, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabGuiContainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnApply, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 241);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // GridIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 241);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(220, 280);
            this.MinimumSize = new System.Drawing.Size(220, 280);
            this.Name = "GridIt";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GridIt";
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
            this.tabAbout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGuiContainer;
        private System.Windows.Forms.TabPage tabFullGrid;
        private System.Windows.Forms.TabPage tabCrosshair;
        private System.Windows.Forms.TabPage tabRadialGrid;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ColorDialog colorDialogGrid;
        private System.Windows.Forms.NumericUpDown numGridOffsetX;
        private System.Windows.Forms.NumericUpDown numGridOffsetY;
        private System.Windows.Forms.NumericUpDown numGridSizeX;
        private System.Windows.Forms.NumericUpDown numGridSizeY;
        private System.Windows.Forms.NumericUpDown numGridThickness;
        private System.Windows.Forms.Button btnOnOffFullGrid;
        private System.Windows.Forms.Label lblGridColor;
        private System.Windows.Forms.Label lblGridOffsetX;
        private System.Windows.Forms.Label lblGridOffsetY;
        private System.Windows.Forms.Label lblGridSizeX;
        private System.Windows.Forms.Label lblGridSizeY;
        private System.Windows.Forms.Label lblGridThickness;
        private System.Windows.Forms.Label lblGridColorLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnApply;
    }
}