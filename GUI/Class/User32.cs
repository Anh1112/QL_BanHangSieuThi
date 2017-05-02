using System;
using System.Runtime.InteropServices;

namespace GUI.Class
{
    class User32
    {
        public static int HT_CAPTION = 0x2;
        public static int WM_NCLBUTTONDOWN = 0x00A1;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}
