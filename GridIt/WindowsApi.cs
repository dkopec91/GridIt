using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GridIt
{
    public static class WindowsApi
    {
        #region Window management
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TRANSPARENT = 0x20;

        [DllImport("user32.dll")]
        private static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public static void SetAsOverlay(Form form)
        {
            int exstyle = GetWindowLong(form.Handle, GWL_EXSTYLE);
            exstyle |= WS_EX_TRANSPARENT;
            SetWindowLong(form.Handle, GWL_EXSTYLE, exstyle);

            IntPtr hwndf = form.Handle;
            IntPtr hwndParent = GetDesktopWindow();
            SetParent(hwndf, hwndParent);
            form.TopMost = true;
        }
        #endregion

        #region Hotkeys
        public const int WM_HOTKEY_MSG_ID = 0x0312;
        public enum KeyModifiers
        {
            MOD_ALT = 0x0001,
            MOD_CONTROL = 0x0002,
            MOD_NOREPEAT = 0x4000,
            MOD_SHIFT = 0x0004
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion

        #region Mouse Hook
        private static int _mouseHook = 0;
        public const int WH_MOUSE_LL = 14;
        public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll")]
        public static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(int idHook);

        public static void SetGlobalMouseHook(HookProc MouseMoveDelegate)
        {
            _mouseHook = SetWindowsHookEx(WH_MOUSE_LL, MouseMoveDelegate, (IntPtr)0, 0);
        }

        public static void UnhookMouseHook() => UnhookWindowsHookEx(_mouseHook);
        #endregion
    }
}
