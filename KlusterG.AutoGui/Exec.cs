using KlusterG.AutoGui.InternalKeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlusterG.AutoGui
{
    public class Exec
    {
        public const int KEYEVENF_KEYUP = 0x0002;
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001;

        public void Click(MKeys key = MKeys.Left)
        {
            if (key == MKeys.Left)
            {
                External.mouse_event((int)MouseKeys.LeftPress, 0, 0, 0, 0);
                External.mouse_event((int)MouseKeys.LeftDrop, 0, 0, 0, 0);
            }
            else if (key == MKeys.Right)
            {
                External.mouse_event((int)MouseKeys.RightPress, 0, 0, 0, 0);
                External.mouse_event((int)MouseKeys.RightDrop, 0, 0, 0, 0);
            }
            else if (key == MKeys.Middle)
            {
                External.mouse_event((int)MouseKeys.MiddlePress, 0, 0, 0, 0);
                External.mouse_event((int)MouseKeys.MiddleDrop, 0, 0, 0, 0);
            }
        }

        public void Press(MKeys key = MKeys.None)
        {
            if (key == MKeys.Left)
            {
                External.mouse_event((int)MouseKeys.LeftPress, 0, 0, 0, 0);
            }
            else if (key == MKeys.Right)
            {
                External.mouse_event((int)MouseKeys.RightPress, 0, 0, 0, 0);
            }
            else if (key == MKeys.Middle)
            {
                External.mouse_event((int)MouseKeys.MiddlePress, 0, 0, 0, 0);
            }
            else
            {

            }
        }

        public void Drop(MKeys key = MKeys.None)
        {
            if (key == MKeys.Left)
            {
                External.mouse_event((int)MouseKeys.LeftDrop, 0, 0, 0, 0);
            }
            else if (key == MKeys.Right)
            {
                External.mouse_event((int)MouseKeys.RightDrop, 0, 0, 0, 0);
            }
            else if (key == MKeys.Middle)
            {
                External.mouse_event((int)MouseKeys.MiddleDrop, 0, 0, 0, 0);
            }
            else
            {

            }
        }

        public void DropMouseKeys()
        {
            External.mouse_event((int)MouseKeys.LeftDrop, 0, 0, 0, 0);
            External.mouse_event((int)MouseKeys.RightDrop, 0, 0, 0, 0);
            External.mouse_event((int)MouseKeys.MiddleDrop, 0, 0, 0, 0);
        }

        public void Write(string text)
        {
            char[] values = text.ToUpper().ToCharArray();

            foreach (char value in values)
            {
                var hex = Convert.ToInt32(value);

                External.keybd_event((byte)hex, 0, 0, UIntPtr.Zero);
                External.keybd_event((byte)hex, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
            }
        }

        public void KeyPress(KKeys key = KKeys.None)
        {
            External.keybd_event((byte)key, 0, 0, UIntPtr.Zero);
        }

        public void KeyDrop(KKeys key = KKeys.None)
        {
            External.keybd_event((byte)key, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
        }

        public void DropKeyboardKeys()
        {
            External.keybd_event((byte)KKeys.ClearKey, 0, 0, UIntPtr.Zero);
            External.keybd_event((byte)KKeys.ClearKey, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
        }

        public void DropAllKeys()
        {
            DropMouseKeys();
            DropKeyboardKeys();
        }

        public void PixelColor()
        {

        }

        public void Mouse()
        {

        }

        public void Keyboard()
        {

        }
    }
}
