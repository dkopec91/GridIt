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
            WindowsApi.SetAsOverlay(this);
            DrawImage();
        }

        public void DrawImage()
        {
            Bitmap grid = new Bitmap(Config.DesktopWidth, Config.DesktopHeight, PixelFormat.Format16bppArgb1555);
            gridImage.Image = grid;

            for (int h = Config.GridOffsetHorizontal; h < Config.DesktopHeight; h += Config.GridHeight)
                for (int w = 0; w < Config.DesktopWidth; w++)
                    for (int bh = h; bh < h + Config.GridThickness && bh < Config.DesktopHeight; bh++)
                        grid.SetPixel(w, bh, Config.GridColor);

            for (int w = Config.GridOffsetVertical; w < Config.DesktopWidth; w += Config.GridWidth)
                for (int h = 0; h < Config.DesktopHeight; h++)
                    for (int bw = w; bw < w + Config.GridThickness && bw < Config.DesktopWidth; bw++)
                        grid.SetPixel(bw, h, Config.GridColor);
        }
    }
}
