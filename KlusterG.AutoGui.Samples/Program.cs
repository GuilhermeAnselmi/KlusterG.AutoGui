using KlusterG.AutoGui;
using KlusterG.AutoGui.InternalKeys;
using System;

namespace KlusterG.AutoGui.Samples
{
    class Program
    {
        static void Main(string[] args)
        {

            Exec.Message("Testing", "Send Message");

            Exec.MouseClick(MKeys.Right);
            Exec.PressMouse(MKeys.Left);
            Exec.ReleaseMouse(MKeys.Left);

            Exec.Write("Testando");
            Exec.PressKey(KKeys.Shift);
            Exec.ReleaseKey(KKeys.Shift);
            Exec.ReleaseKeyboardKeys();
            Exec.ReleaseMouseKeys();

            Exec.DropAllKeys();

            Mouse mouse = Exec.GetMousePosition();

            //mouse.X = 500;
            //mouse.Y = 500;

            Exec.MouseMove(mouse);
            



            //Exec.MouseClick(MKeys.Right);
        }
    }
}