using System;
using System.Runtime.InteropServices;

namespace open_start_menu
{
    /// <summary>
    /// Opens the start menu by emulating Ctrl+Esc keypresses.
    /// Taken from CodeProject: https://www.codeproject.com/questions/46731/open-start-menu
    /// </summary>
    internal class Program
    {
        [DllImport("User32")]
        private static extern int keybd_event(Byte bVk, Byte bScan, long dwFlags, long dwExtraInfo);
        private const byte UP = 2;
        private const byte CTRL = 17;
        private const byte ESC = 27;

        public static void Main(string[] args)
        {
            // Press Ctrl-Esc key to open Start menu
            keybd_event(CTRL, 0, 0, 0);
            keybd_event(ESC, 0, 0, 0);

            // Need to Release those two keys
            keybd_event(CTRL, 0, UP, 0);
            keybd_event(ESC, 0, UP, 0);
        }
    }
}