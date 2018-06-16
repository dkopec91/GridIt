using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GridIt
{
    public partial class CrosshairWindow : Form
    {
        public CrosshairWindow()
        {
            InitializeComponent();
            WindowsApi.SetAsOverlay(this);
            DrawCrosshair();
        }

        public void DrawCrosshair()
        {
            crosshairAxisX.Width = Config.DesktopWidth;
            crosshairAxisX.Height = Config.CrosshairThickness;
            crosshairAxisX.BackColor = Config.CrosshairColor;
            crosshairAxisY.Width = Config.CrosshairThickness;
            crosshairAxisY.Height = Config.DesktopHeight;
            crosshairAxisY.BackColor = Config.CrosshairColor;
        }

        protected override void SetVisibleCore(bool value)
        {
            if (value) StartTracking();
            base.SetVisibleCore(value);
        }

        private async void StartTracking()
        {
            var cursorUpdate = new Progress<Point>(p =>
            {
                crosshairAxisX.Top = p.Y;
                crosshairAxisY.Left = p.X;
            });
            await Task.Factory.StartNew(() => ReportCursorMovement(cursorUpdate), 
                                              TaskCreationOptions.LongRunning);
        }
        
        private void ReportCursorMovement(IProgress<Point> position)
        {
            while (true)
            {
                position.Report(System.Windows.Forms.Cursor.Position);
                System.Threading.Thread.Sleep(200);
                if (!this.Visible) break;
            }
        }
    }
}
