using System;
using System.Windows.Forms;

namespace GridIt
{
    public partial class MainWindow : Form
    {
        private GridWindow gridWindow;
        private CrosshairWindow crosshairWindow;
        private static bool FullGridShown;
        private static bool CrosshairShown;
        private int _hotkeyIdCrosshair;
        private int _hotkeyIdFullGrid;
        private int _hotkeyIdRadial;

        public MainWindow()
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
            numGridSizeY.Value = Config.GridWidth;
            numGridSizeX.Value = Config.GridHeight;
            lblGridColor.BackColor = Config.GridColor;
            numGridThickness.Value = Config.GridThickness;
            numGridOffsetY.Value = Config.GridOffsetVertical;
            numGridOffsetX.Value = Config.GridOffsetHorizontal;
            lblCrosshairColor.BackColor = Config.CrosshairColor;
            numCrosshairThickness.Value = Config.CrosshairThickness;
            cbxWindowsStartup.CheckState = Config.RunsOnSystemStartup() ? CheckState.Checked
                                                                        : CheckState.Unchecked;

            if (cbxWindowsStartup.CheckState == CheckState.Unchecked)
                cbxWindowsStartup.Text = Messages.SetRunOnStartup;
        }

        private void GuiToConfig()
        {
            Config.GridOffsetHorizontal = (int)numGridOffsetX.Value;
            Config.GridOffsetVertical = (int)numGridOffsetY.Value;
            Config.GridThickness = (int)numGridThickness.Value;
            Config.GridHeight = (int)numGridSizeX.Value;
            Config.GridWidth = (int)numGridSizeY.Value;
            Config.GridColor = lblGridColor.BackColor;
            Config.CrosshairThickness = (int)numCrosshairThickness.Value;
            Config.CrosshairColor = lblCrosshairColor.BackColor;
        }

        private void BtnOnOffFullGrid_Click(object sender, EventArgs e)
        {
            if (FullGridShown)
            {
                btnOnOffFullGrid.Text = Messages.GridShow;
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
                btnOnOffFullGrid.Text = Messages.GridHide;
            }
            FullGridShown = !FullGridShown;
        }

        private void LblGridColor_Click(object sender, EventArgs e)
        {
            SetColor((Label)sender, ref Config.GridColor);
        }

        private void LblCrosshairColor_Click(object sender, EventArgs e)
        {
            SetColor((Label)sender, ref Config.CrosshairColor);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            GuiToConfig();
            if (gridWindow != null && gridWindow.Visible) gridWindow.Refresh();
            if (crosshairWindow != null) crosshairWindow.DrawCrosshair();
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            BtnApply_Click(this, null);
            Config.SaveConfiguration();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WindowsApi.WM_HOTKEY_MSG_ID)
            {
                if (m.WParam.ToInt32() == _hotkeyIdFullGrid)
                    BtnOnOffFullGrid_Click(this, null);
                else if (m.WParam.ToInt32() == _hotkeyIdCrosshair)
                    BtnOnOffCrosshair_Click(this, null);
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

        private void SetColor(Label label, ref System.Drawing.Color color)
        {
            colorDialogGrid.Color = color;
            colorDialogGrid.ShowDialog();
            color = colorDialogGrid.Color;
            label.BackColor = colorDialogGrid.Color;
        }

        private void BtnOnOffCrosshair_Click(object sender, EventArgs e)
        {
            if (CrosshairShown)
            {
                btnOnOffCrosshair.Text = Messages.CrosshairShow;
                crosshairWindow.Hide();
            }
            else
            {
                if (crosshairWindow == null)
                {
                    crosshairWindow = new CrosshairWindow
                    {
                        StartPosition = FormStartPosition.Manual,
                        Width = Config.DesktopWidth,
                        Height = Config.DesktopHeight,
                        Left = 0,
                        Top = 0
                    };
                }
                crosshairWindow.Show();
                btnOnOffCrosshair.Text = Messages.CrosshairHide;
            }
            CrosshairShown = !CrosshairShown;
        }
    }
}
