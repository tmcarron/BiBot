using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BiBot
{
    class MouseAndKey
    {
        
        [DllImport("USER32.DLL")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public static void LeftMouseClick(System.Drawing.Point CursorPos)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, CursorPos.X, CursorPos.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, CursorPos.X, CursorPos.Y, 0, 0);
        }
    }
}
