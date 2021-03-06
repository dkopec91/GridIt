﻿namespace GridIt
{
    partial class GridWindow
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
            this.gridImage = new System.Windows.Forms.PictureBox();
            this.gridControl = new global::GridIt.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gridImage
            // 
            this.gridImage.BackColor = System.Drawing.Color.Transparent;
            this.gridImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridImage.Location = new System.Drawing.Point(0, 0);
            this.gridImage.Margin = new System.Windows.Forms.Padding(0);
            this.gridImage.Name = "gridImage";
            this.gridImage.Size = new System.Drawing.Size(100, 100);
            this.gridImage.TabIndex = 0;
            this.gridImage.TabStop = false;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(100, 100);
            this.gridControl.TabIndex = 1;
            this.gridControl.Text = "gridControl1";
            // 
            // GridWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.gridImage);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GridWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GridWindow";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.gridImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gridImage;
        private global::GridIt.GridControl gridControl;
    }
}