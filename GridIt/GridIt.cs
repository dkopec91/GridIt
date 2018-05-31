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
            Config.LoadConfiguration();
            Config.DesktopWidth = SystemInformation.VirtualScreen.Width;
            Config.DesktopHeight = SystemInformation.VirtualScreen.Height;
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
        }

        private void btnOnOffFullGrid_Click(object sender, EventArgs e)
        {
            GuiToConfig();
            if (FullGridShown)
            {
                btnOnOffFullGrid.Text = "Show Grid";
                gridWindow.Dispose();
                gridWindow = null;
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
            if (gridWindow != null) gridWindow.DrawImage();
            Config.SaveConfiguration();
        }

        private void GridIt_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuiToConfig();
            Config.SaveConfiguration();
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
    }
}
