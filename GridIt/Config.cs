using GridIt.Properties;

namespace GridIt
{
    static class Config
    {
        public static int GridWidth;
        public static int GridHeight;
        public static int DesktopWidth;
        public static int DesktopHeight;
        public static int LineThickness;
        public static int GridOffsetVertical;
        public static int GridOffsetHorizontal;
        public static System.Drawing.Color ColorGrid;

        public static void LoadConfiguration()
        {
            ColorGrid = Settings.Default.ColorGrid;
            GridWidth = Settings.Default.GridWidth;
            GridHeight = Settings.Default.GridHeight;
            LineThickness = Settings.Default.LineThickness;
            GridOffsetVertical = Settings.Default.GridOffsetVertical;
            GridOffsetHorizontal = Settings.Default.GridOffsetHorizontal;
        }

        public static void SaveConfiguration()
        {
            Settings.Default.ColorGrid = ColorGrid;
            Settings.Default.GridWidth = GridWidth;
            Settings.Default.GridHeight = GridHeight;
            Settings.Default.LineThickness = LineThickness;
            Settings.Default.GridOffsetVertical = GridOffsetVertical;
            Settings.Default.GridOffsetHorizontal = GridOffsetHorizontal;
            Settings.Default.Save();
        }
    }
}
