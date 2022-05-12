using KlusterG.AutoGui;
using KlusterG.AutoGui.InternalKeys;
using System;

namespace KlusterG.AutoGui.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Exec.MouseClick(MKeys.Right);
            Exec.MousePress(MKeys.Left);
            Exec.MouseDrop(MKeys.Left);
            Exec.Write("Testando");
            Exec.KeyPress(KKeys.Shift);
            Exec.KeyDrop(KKeys.Shift);
            Exec.DropKeyboardKeys();
            Exec.DropMouseKeys();
            Exec.DropAllKeys();

            Mouse mouse = Exec.GetMousePosition();

            //mouse.X = 500;
            //mouse.Y = 500;

            Exec.MouseMove(mouse);
            



            //Exec.MouseClick(MKeys.Right);
        }
    }
}