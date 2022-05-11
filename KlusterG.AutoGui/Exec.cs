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
        public void Click(MKeys key = MKeys.Left)
        {
            if (key == MKeys.Left)
            {
                External.mouse_event((int)Keys.LeftPress, 0, 0, 0, 0);
                External.mouse_event((int)Keys.LeftDrop, 0, 0, 0, 0);
            }
            else if (key == MKeys.Right)
            {
                External.mouse_event((int)Keys.RightPress, 0, 0, 0, 0);
                External.mouse_event((int)Keys.RightDrop, 0, 0, 0, 0);
            }
            else if (key == MKeys.Middle)
            {
                External.mouse_event((int)Keys.MiddlePress, 0, 0, 0, 0);
                External.mouse_event((int)Keys.MiddleDrop, 0, 0, 0, 0);
            }
        }

        public void Press(MKeys key = MKeys.None)
        {
            if (key == MKeys.Left)
            {
                External.mouse_event((int)Keys.LeftPress, 0, 0, 0, 0);
            }
            else if (key == MKeys.Right)
            {
                External.mouse_event((int)Keys.RightPress, 0, 0, 0, 0);
            }
            else if (key == MKeys.Middle)
            {
                External.mouse_event((int)Keys.MiddlePress, 0, 0, 0, 0);
            }
            else
            {

            }
        }

        public void Drop(MKeys key = MKeys.None)
        {
            if (key == MKeys.Left)
            {
                External.mouse_event((int)Keys.LeftDrop, 0, 0, 0, 0);
            }
            else if (key == MKeys.Right)
            {
                External.mouse_event((int)Keys.RightDrop, 0, 0, 0, 0);
            }
            else if (key == MKeys.Middle)
            {
                External.mouse_event((int)Keys.MiddleDrop, 0, 0, 0, 0);
            }
            else
            {

            }
        }

        public void DropMouseKeys()
        {

        }

        public void Write(string text)
        {

        }

        public void KeyPress()
        {

        }

        public void KeyDrop()
        {

        }

        public void DropKeyboardKeys()
        {

        }

        public void DropAllKeys()
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
