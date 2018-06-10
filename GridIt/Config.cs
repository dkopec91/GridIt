using GridIt.Properties;
using Microsoft.Win32;
using System.Windows.Forms;

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
        private static string GridIt = "GridIt";
        private static RegistryKey appKey;
        
        public static void LoadConfiguration()
        {
            ColorGrid = Settings.Default.ColorGrid;
            GridWidth = Settings.Default.GridWidth;
            GridHeight = Settings.Default.GridHeight;
            LineThickness = Settings.Default.LineThickness;
            GridOffsetVertical = Settings.Default.GridOffsetVertical;
            GridOffsetHorizontal = Settings.Default.GridOffsetHorizontal;
            appKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
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

        public static bool RunsOnSystemStartup()
        {
            return (appKey.GetValue(GridIt) != null);
        }

        public static void SetRunOnSystemStartup(bool runOnSystemStartup)
        {
            if (runOnSystemStartup)
            {
                if (appKey.GetValue(GridIt) != null && appKey.GetValue(GridIt).ToString() != Application.ExecutablePath)
                    appKey.DeleteValue(GridIt);

                if (appKey.GetValue(GridIt) == null)
                    appKey.SetValue(GridIt, Application.ExecutablePath);
            }
            else
            {
                appKey.DeleteValue(GridIt);
            }
        }
    }
}
