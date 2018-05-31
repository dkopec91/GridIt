using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
namespace GridIt
{
    public partial class GridWindow : Form
    {
        public GridWindow()
        {
            InitializeComponent();
            SetAsOverlay();
            DrawImage();
        }

        public void DrawImage()
        {
            Bitmap grid = new Bitmap(Config.DesktopWidth, Config.DesktopHeight, PixelFormat.Format16bppArgb1555);
            gridImage.Image = grid;

            for (int h = Config.GridOffsetHorizontal; h < Config.DesktopHeight; h += Config.GridHeight)
                for (int w = 0; w < Config.DesktopWidth; w++)
                    for (int bh = h; bh < h + Config.LineThickness && bh < Config.DesktopHeight; bh++)
                        grid.SetPixel(w, bh, Config.ColorGrid);

            for (int w = Config.GridOffsetVertical; w < Config.DesktopWidth; w += Config.GridWidth)
                for (int h = 0; h < Config.DesktopHeight; h++)
                    for (int bw = w; bw < w + Config.LineThickness && bw < Config.DesktopWidth; bw++)
                        grid.SetPixel(bw, h, Config.ColorGrid);
        }

        private void SetAsOverlay()
        {
            int exstyle = WindowsApi.GetWindowLong(this.Handle, WindowsApi.GWL_EXSTYLE);
            exstyle |= WindowsApi.WS_EX_TRANSPARENT;
            WindowsApi.SetWindowLong(this.Handle, WindowsApi.GWL_EXSTYLE, exstyle);

            IntPtr hwndf = this.Handle;
            IntPtr hwndParent = WindowsApi.GetDesktopWindow();
            WindowsApi.SetParent(hwndf, hwndParent);
            this.TopMost = true;
        }
    }
}
