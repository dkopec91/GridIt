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
            this.tabGuiContainer = new System.Windows.Forms.TabControl();
            this.tabCrosshair = new System.Windows.Forms.TabPage();
            this.tabRadialGrid = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tabFullGrid = new System.Windows.Forms.TabPage();
            this.btnOnOffFullGrid = new System.Windows.Forms.Button();
            this.colorDialogGrid = new System.Windows.Forms.ColorDialog();
            this.lblGridSizeX = new System.Windows.Forms.Label();
            this.lblGridSizeY = new System.Windows.Forms.Label();
            this.lblGridThickness = new System.Windows.Forms.Label();
            this.lblGridColorLbl = new System.Windows.Forms.Label();
            panelFullGrid = new System.Windows.Forms.TableLayoutPanel();
            panelFullGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridThickness)).BeginInit();
            this.tabGuiContainer.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.tabFullGrid.SuspendLayout();
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
            panelFullGrid.Size = new System.Drawing.Size(190, 151);
            panelFullGrid.TabIndex = 4;
            // 
            // numGridOffsetX
            // 
            this.numGridOffsetX.AutoSize = true;
            this.numGridOffsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridOffsetX.Location = new System.Drawing.Point(98, 3);
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
            this.lblGridColor.Location = new System.Drawing.Point(98, 133);
            this.lblGridColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblGridColor.Name = "lblGridColor";
            this.lblGridColor.Size = new System.Drawing.Size(89, 15);
            this.lblGridColor.TabIndex = 2;
            this.lblGridColor.Click += new System.EventHandler(this.lblGridColor_Click);
            // 
            // numGridOffsetY
            // 
            this.numGridOffsetY.AutoSize = true;
            this.numGridOffsetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridOffsetY.Location = new System.Drawing.Point(98, 29);
            this.numGridOffsetY.Name = "numGridOffsetY";
            this.numGridOffsetY.Size = new System.Drawing.Size(89, 20);
            this.numGridOffsetY.TabIndex = 5;
            this.numGridOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numGridSizeX
            // 
            this.numGridSizeX.AutoSize = true;
            this.numGridSizeX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridSizeX.Location = new System.Drawing.Point(98, 55);
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
            this.numGridSizeY.Location = new System.Drawing.Point(98, 81);
            this.numGridSizeY.Name = "numGridSizeY";
            this.numGridSizeY.Size = new System.Drawing.Size(89, 20);
            this.numGridSizeY.TabIndex = 7;
            this.numGridSizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numGridThickness
            // 
            this.numGridThickness.AutoSize = true;
            this.numGridThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGridThickness.Location = new System.Drawing.Point(98, 107);
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
            this.lblGridOffsetX.Size = new System.Drawing.Size(89, 26);
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
            this.lblGridOffsetY.Size = new System.Drawing.Size(89, 26);
            this.lblGridOffsetY.TabIndex = 10;
            this.lblGridOffsetY.Text = "Vertical offset";
            this.lblGridOffsetY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabGuiContainer
            // 
            this.tabGuiContainer.Controls.Add(this.tabFullGrid);
            this.tabGuiContainer.Controls.Add(this.tabCrosshair);
            this.tabGuiContainer.Controls.Add(this.tabRadialGrid);
            this.tabGuiContainer.Controls.Add(this.tabAbout);
            this.tabGuiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGuiContainer.Location = new System.Drawing.Point(0, 0);
            this.tabGuiContainer.Name = "tabGuiContainer";
            this.tabGuiContainer.Padding = new System.Drawing.Point(3, 3);
            this.tabGuiContainer.SelectedIndex = 0;
            this.tabGuiContainer.Size = new System.Drawing.Size(204, 211);
            this.tabGuiContainer.TabIndex = 0;
            // 
            // tabCrosshair
            // 
            this.tabCrosshair.Location = new System.Drawing.Point(4, 22);
            this.tabCrosshair.Name = "tabCrosshair";
            this.tabCrosshair.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrosshair.Size = new System.Drawing.Size(196, 323);
            this.tabCrosshair.TabIndex = 1;
            this.tabCrosshair.Text = "Crosshair";
            this.tabCrosshair.UseVisualStyleBackColor = true;
            // 
            // tabRadialGrid
            // 
            this.tabRadialGrid.Location = new System.Drawing.Point(4, 22);
            this.tabRadialGrid.Name = "tabRadialGrid";
            this.tabRadialGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabRadialGrid.Size = new System.Drawing.Size(196, 323);
            this.tabRadialGrid.TabIndex = 2;
            this.tabRadialGrid.Text = "Radial Grid";
            this.tabRadialGrid.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lblEmail);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(196, 195);
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
            this.lblEmail.Size = new System.Drawing.Size(196, 195);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "dkopec91@gmail.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabFullGrid
            // 
            this.tabFullGrid.Controls.Add(this.btnOnOffFullGrid);
            this.tabFullGrid.Controls.Add(panelFullGrid);
            this.tabFullGrid.Location = new System.Drawing.Point(4, 22);
            this.tabFullGrid.Name = "tabFullGrid";
            this.tabFullGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabFullGrid.Size = new System.Drawing.Size(196, 185);
            this.tabFullGrid.TabIndex = 0;
            this.tabFullGrid.Text = "Full Grid";
            this.tabFullGrid.UseVisualStyleBackColor = true;
            // 
            // btnOnOffFullGrid
            // 
            this.btnOnOffFullGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOnOffFullGrid.Location = new System.Drawing.Point(3, 156);
            this.btnOnOffFullGrid.Name = "btnOnOffFullGrid";
            this.btnOnOffFullGrid.Size = new System.Drawing.Size(190, 26);
            this.btnOnOffFullGrid.TabIndex = 5;
            this.btnOnOffFullGrid.Text = "Show Grid";
            this.btnOnOffFullGrid.UseVisualStyleBackColor = true;
            this.btnOnOffFullGrid.Click += new System.EventHandler(this.btnOnOffFullGrid_Click);
            // 
            // colorDialogGrid
            // 
            this.colorDialogGrid.AllowFullOpen = false;
            this.colorDialogGrid.Color = global::GridIt.Properties.Settings.Default.ColorGrid;
            this.colorDialogGrid.SolidColorOnly = true;
            // 
            // lblGridSizeX
            // 
            this.lblGridSizeX.AutoSize = true;
            this.lblGridSizeX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGridSizeX.Location = new System.Drawing.Point(3, 52);
            this.lblGridSizeX.Name = "lblGridSizeX";
            this.lblGridSizeX.Size = new System.Drawing.Size(89, 26);
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
            this.lblGridSizeY.Size = new System.Drawing.Size(89, 26);
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
            this.lblGridThickness.Size = new System.Drawing.Size(89, 26);
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
            this.lblGridColorLbl.Size = new System.Drawing.Size(89, 21);
            this.lblGridColorLbl.TabIndex = 14;
            this.lblGridColorLbl.Text = "Line color";
            this.lblGridColorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GridIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 211);
            this.Controls.Add(this.tabGuiContainer);
            this.MaximumSize = new System.Drawing.Size(220, 250);
            this.MinimumSize = new System.Drawing.Size(220, 250);
            this.Name = "GridIt";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GridIt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridIt_FormClosing);
            panelFullGrid.ResumeLayout(false);
            panelFullGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGridThickness)).EndInit();
            this.tabGuiContainer.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabFullGrid.ResumeLayout(false);
            this.tabFullGrid.PerformLayout();
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
    }
}