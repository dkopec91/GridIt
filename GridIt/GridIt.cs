using System;
using System.Windows.Forms;
using GridIt.Properties;

namespace GridIt
{
    public partial class GridIt : Form
    {
        private static bool FullGridShown;
        private GridWindow gridWindow;

        public GridIt()
        {
            InitializeComponent();
            Config.DesktopHeight = SystemInformation.VirtualScreen.Height;
            Config.DesktopWidth = SystemInformation.VirtualScreen.Width;
            Config.LoadConfiguration();
            SetGuiControls();
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
                btnOnOffFullGrid.Text = "Show Grid";
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
                btnOnOffFullGrid.Text = "Hide Grid";
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
    }
}
