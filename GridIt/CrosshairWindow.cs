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
        private static WindowsApi.HookProc _hook;

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
            else WindowsApi.UnhookMouseHook();
            base.SetVisibleCore(value);
        }

        private void StartTracking()
        {
            _hook = (int x, IntPtr wParam, IntPtr lParam) =>
             {
                 crosshairAxisX.Top = Cursor.Position.Y;
                 crosshairAxisY.Left = Cursor.Position.X;
                 return WindowsApi.CallNextHookEx(x, WindowsApi.WH_MOUSE_LL, wParam, lParam);
             };
            WindowsApi.SetGlobalMouseHook(_hook);
        }
    }
}
