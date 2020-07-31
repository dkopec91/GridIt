using System.Windows.Forms;
using GridIt.Properties;
using Microsoft.Win32;
using System.Drawing;

namespace GridIt
{
    static class Config
    {
        private static string GridIt = "GridIt";
        private static RegistryKey appKey;
        public static int DesktopHeight;
        public static int DesktopWidth;
        public static int DesktopLeft;
        public static int DesktopTop;
        public static int GridWidth;
        public static int GridHeight;
        public static int GridThickness;
        public static int GridOffsetVertical;
        public static int GridOffsetHorizontal;
        public static Color GridColor;
        public static int CrosshairThickness;
        public static Color CrosshairColor;


        public static void LoadConfiguration()
        {
            appKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            GridColor = Settings.Default.GridColor;
            GridWidth = Settings.Default.GridWidth;
            GridHeight = Settings.Default.GridHeight;
            GridThickness = Settings.Default.GridThickness;
            GridOffsetVertical = Settings.Default.GridOffsetVertical;
            GridOffsetHorizontal = Settings.Default.GridOffsetHorizontal;
            CrosshairColor = Settings.Default.CrosshairColor;
            CrosshairThickness = Settings.Default.CrosshairThickness;
        }

        public static void SaveConfiguration()
        {
            Settings.Default.GridColor = GridColor;
            Settings.Default.GridWidth = GridWidth;
            Settings.Default.GridHeight = GridHeight;
            Settings.Default.GridThickness = GridThickness;
            Settings.Default.GridOffsetVertical = GridOffsetVertical;
            Settings.Default.GridOffsetHorizontal = GridOffsetHorizontal;
            Settings.Default.CrosshairColor = CrosshairColor;
            Settings.Default.CrosshairThickness = CrosshairThickness;
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
