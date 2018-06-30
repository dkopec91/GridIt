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
        }
    }
}
