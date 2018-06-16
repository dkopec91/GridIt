namespace GridIt
{
    partial class CrosshairWindow
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
            this.crosshairAxisX = new System.Windows.Forms.PictureBox();
            this.crosshairAxisY = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crosshairAxisX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crosshairAxisY)).BeginInit();
            this.SuspendLayout();
            // 
            // crosshairAxisX
            // 
            this.crosshairAxisX.BackColor = System.Drawing.Color.Red;
            this.crosshairAxisX.Location = new System.Drawing.Point(0, 49);
            this.crosshairAxisX.Margin = new System.Windows.Forms.Padding(0);
            this.crosshairAxisX.Name = "crosshairAxisX";
            this.crosshairAxisX.Size = new System.Drawing.Size(100, 3);
            this.crosshairAxisX.TabIndex = 0;
            this.crosshairAxisX.TabStop = false;
            // 
            // crosshairAxisY
            // 
            this.crosshairAxisY.BackColor = System.Drawing.Color.Red;
            this.crosshairAxisY.Location = new System.Drawing.Point(49, 0);
            this.crosshairAxisY.Margin = new System.Windows.Forms.Padding(0);
            this.crosshairAxisY.Name = "crosshairAxisY";
            this.crosshairAxisY.Size = new System.Drawing.Size(3, 100);
            this.crosshairAxisY.TabIndex = 1;
            this.crosshairAxisY.TabStop = false;
            // 
            // CrosshairWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.Controls.Add(this.crosshairAxisY);
            this.Controls.Add(this.crosshairAxisX);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrosshairWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CrosshairWindow";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.crosshairAxisX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crosshairAxisY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox crosshairAxisX;
        private System.Windows.Forms.PictureBox crosshairAxisY;
    }
}