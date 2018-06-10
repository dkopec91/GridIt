using System;
using System.Windows.Forms;

namespace GridIt
{
    public partial class GridIt : Form
    {
        private GridWindow gridWindow;
        private static bool FullGridShown;        
        private int _hotkeyIdCrosshair;
        private int _hotkeyIdFullGrid;
        private int _hotkeyIdRadial;

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

            _hotkeyIdFullGrid = this.Handle.ToInt32() ^ (int)modifiers ^ (int)Keys.D1;
            _hotkeyIdCrosshair = this.Handle.ToInt32() ^ (int)modifiers ^ (int)Keys.D2;
            _hotkeyIdRadial = this.Handle.ToInt32() ^ (int)modifiers ^ (int)Keys.D3;

            WindowsApi.RegisterHotKey(this.Handle, _hotkeyIdFullGrid, modifiers, Keys.D1);
            WindowsApi.RegisterHotKey(this.Handle, _hotkeyIdCrosshair, modifiers, Keys.D2);
            WindowsApi.RegisterHotKey(this.Handle, _hotkeyIdRadial, modifiers, Keys.D3);
        }

        private void UnregisterHotkeys()
        {
            WindowsApi.UnregisterHotKey(this.Handle, _hotkeyIdRadial);
            WindowsApi.UnregisterHotKey(this.Handle, _hotkeyIdFullGrid);
            WindowsApi.UnregisterHotKey(this.Handle, _hotkeyIdCrosshair);
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
            cbxWindowsStartup.CheckState = Config.RunsOnSystemStartup() ? CheckState.Checked 
                                                                        : CheckState.Unchecked;

            if (cbxWindowsStartup.CheckState==CheckState.Unchecked)
                cbxWindowsStartup.Text = Messages.SetRunOnStartup;
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

        private void BtnOnOffFullGrid_Click(object sender, EventArgs e)
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

        private void LblGridColor_Click(object sender, EventArgs e)
        {
            colorDialogGrid.ShowDialog();
            Config.ColorGrid = colorDialogGrid.Color;
            lblGridColor.BackColor = colorDialogGrid.Color;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            GuiToConfig();
            if (gridWindow != null) gridWindow.DrawImage();
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            GuiToConfig();
            Config.SaveConfiguration();
            if (gridWindow != null) gridWindow.DrawImage();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WindowsApi.WM_HOTKEY_MSG_ID)
            {
                if (m.WParam.ToInt32() == _hotkeyIdFullGrid)
                    BtnOnOffFullGrid_Click(this, null);
                else if (m.WParam.ToInt32() == _hotkeyIdCrosshair)
                    throw new NotImplementedException("Crosshair overlay not implemented");
                else if (m.WParam.ToInt32() == _hotkeyIdRadial)
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

        private void GridIt_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotkeys();
        }
        
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void CbxWindowsStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxWindowsStartup.CheckState == CheckState.Checked)
            {
                cbxWindowsStartup.Text = Messages.UnsetRunOnStartup;
                Config.SetRunOnSystemStartup(true);
            }
            else
            {
                cbxWindowsStartup.Text = Messages.SetRunOnStartup;
                Config.SetRunOnSystemStartup(false);
            }
        }
    }
}
