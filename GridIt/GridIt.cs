using System;
using System.Windows.Forms;
using GridIt.Properties;

namespace GridIt
{
    public partial class GridIt : Form
    {
        private static bool FullGridShown;
        private GridWindow gridWindow;
        private int _hotkeyCrosshair;
        private int _hotkeyFullGrid;
        private int _hotkeyRadial;

        public GridIt()
        {
            InitializeComponent();
            Config.DesktopHeight = SystemInformation.VirtualScreen.Height;
            Config.DesktopWidth = SystemInformation.VirtualScreen.Width;
            Config.LoadConfiguration();
            RegisterHotkeys();
            SetGuiControls();
        }

        private void RegisterHotkeys()
        {
            WindowsApi.KeyModifiers modifiers = WindowsApi.KeyModifiers.MOD_CONTROL |
                                                WindowsApi.KeyModifiers.MOD_NOREPEAT;

            _hotkeyFullGrid = this.Handle.ToInt32() ^ (int)modifiers ^ (int)Keys.D1;
            _hotkeyCrosshair = this.Handle.ToInt32() ^ (int)modifiers ^ (int)Keys.D2;
            _hotkeyRadial = this.Handle.ToInt32() ^ (int)modifiers ^ (int)Keys.D3;

            WindowsApi.RegisterHotKey(this.Handle, _hotkeyFullGrid, modifiers, Keys.D1);
            WindowsApi.RegisterHotKey(this.Handle, _hotkeyCrosshair, modifiers, Keys.D2);
            WindowsApi.RegisterHotKey(this.Handle, _hotkeyRadial, modifiers, Keys.D3);
        }

        private void UnregisterHotkeys()
        {
            WindowsApi.UnregisterHotKey(this.Handle, _hotkeyRadial);
            WindowsApi.UnregisterHotKey(this.Handle, _hotkeyFullGrid);
            WindowsApi.UnregisterHotKey(this.Handle, _hotkeyCrosshair);
        }

        private void SetGuiControls()
        {
            numGridOffsetX.Value = Config.GridOffsetHorizontal;
            numGridOffsetY.Value = Config.GridOffsetVertical;
            numGridSizeX.Value = Config.GridHeight;
            numGridSizeY.Value = Config.GridWidth;
            numGridThickness.Value = Config.LineThickness;
            lblGridColor.BackColor = Config.ColorGrid;
            colorDialogGrid.Color = Config.ColorGrid;
        }

        private void GuiToConfig()
        {
            Config.GridOffsetHorizontal = (int)numGridOffsetX.Value;
            Config.GridOffsetVertical = (int)numGridOffsetY.Value;
            Config.GridHeight = (int)numGridSizeX.Value;
            Config.GridWidth = (int)numGridSizeY.Value;
            Config.LineThickness = (int)numGridThickness.Value;
            Config.ColorGrid = lblGridColor.BackColor;
        }

        private void btnOnOffFullGrid_Click(object sender, EventArgs e)
        {
            if (FullGridShown)
            {
                btnOnOffFullGrid.Text = "Show Grid (Ctrl + 1)";
                gridWindow.Hide();
            }
            else
            {
                if (gridWindow == null)
                {
                    gridWindow = new GridWindow
                    {
                        StartPosition = FormStartPosition.Manual,
                        Width = Config.DesktopWidth,
                        Height = Config.DesktopHeight,
                        Left = 0,
                        Top = 0
                    };
                }
                gridWindow.Show();
                btnOnOffFullGrid.Text = "Hide Grid (Ctrl + 1)";
            }
            FullGridShown = !FullGridShown;
        }

        private void lblGridColor_Click(object sender, EventArgs e)
        {
            colorDialogGrid.ShowDialog();
            Config.ColorGrid = colorDialogGrid.Color;
            lblGridColor.BackColor = colorDialogGrid.Color;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            GuiToConfig();
            if (gridWindow != null) gridWindow.DrawImage();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            GuiToConfig();
            Config.SaveConfiguration();
            if (gridWindow != null) gridWindow.DrawImage();
        }

        private void GridIt_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotkeys();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WindowsApi.WM_HOTKEY_MSG_ID)
            {
                if (m.WParam.ToInt32() == _hotkeyFullGrid)
                    btnOnOffFullGrid_Click(this, null);
                else if (m.WParam.ToInt32() == _hotkeyCrosshair)
                    throw new NotImplementedException("Crosshair overlay not implemented");
                else if (m.WParam.ToInt32() == _hotkeyRadial)
                    throw new NotImplementedException("Radial overlay not implemented");
            }
            base.WndProc(ref m);
        }

        private void GridIt_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
