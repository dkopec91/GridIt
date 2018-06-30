using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridIt
{
    public partial class GridControl : Control
    {
        public GridControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            var linePen = new Pen(Config.GridColor, Config.GridThickness);

            for (int h = Config.GridOffsetHorizontal; h < Config.DesktopHeight; h += Config.GridHeight)
                pe.Graphics.DrawLine(linePen, 0, h, Config.DesktopWidth, h);

            for (int w = Config.GridOffsetVertical; w < Config.DesktopWidth; w += Config.GridWidth)
                pe.Graphics.DrawLine(linePen, w, 0, w,Config.DesktopHeight);

            base.OnPaint(pe);
        }
    }
}
