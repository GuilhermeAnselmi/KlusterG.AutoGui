using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlusterG.AutoGui
{
    public class Structs
    {
        public struct CursorPosition
        {
            public int X;
            public int Y;

            public static implicit operator Point(CursorPosition point)
            {
                return new Point(point.X, point.Y);
            }
        }

        public struct INPUT
        {
            public int type;

            public KEYBDINPUT ki;

            public MOUSEINPUT mi;

            public HARDWAREINPUT hi;
        }

        public struct MOUSEINPUT
        {
            public int dx;

            public int dy;

            public int mouseData;

            public int dwFlags;

            public int time;

            public IntPtr dwExtraInfo;
        }

        public struct KEYBDINPUT
        {
            public short wVk;

            public short wScan;

            public int dwFlags;

            public int time;

            public IntPtr dwExtraInfo;
        }

        public struct HARDWAREINPUT
        {
            public int uMsg;

            public short wParamL;

            public short wParamH;
        }
    }
}
