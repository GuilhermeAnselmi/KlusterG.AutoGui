using KlusterG.AutoGui.User32;
using KlusterG.AutoGui.Domain;
using KlusterG.AutoGui.Domain.Model;
using KlusterG.AutoGui.Domain.Enum;
using KlusterG.AutoGui.Xdotool;

namespace KlusterG.AutoGui
{
    public class Gui
    {
        public static Plataform GetPlataform()
        {
            string os = Environment.OSVersion.Platform.ToString();

            if (os.Contains("Windows"))
            {
                return Plataform.Windows;
            }
            else
            {
                return Plataform.Linux;
            }
        }

        public static void MouseEvent(Mouse mouse)
        {
            var plataform = GetPlataform();

            if (plataform == Plataform.Windows)
            {
                if (mouse.Move) MouseExecution.SetPosition(mouse.X, mouse.Y);

                if (mouse.Action == MouseAction.Click) MouseExecution.Click(mouse.Key);

                if (mouse.Action == MouseAction.Double) MouseExecution.Double(mouse.Key);

                if (mouse.Action == MouseAction.Press) MouseExecution.Press(mouse.Key);

                if (mouse.Action == MouseAction.Release) MouseExecution.Release(mouse.Key);

                if (mouse.Action == MouseAction.ReleaseAll) MouseExecution.ReleaseAll();
            }
            else if (plataform == Plataform.Linux)
            {
                if (mouse.Move) MouseXdotool.SetPosition(mouse.X, mouse.Y);

                if (mouse.Action == MouseAction.Click) MouseXdotool.Click(mouse.Key);

                if (mouse.Action == MouseAction.Double) MouseXdotool.Double(mouse.Key);

                if (mouse.Action == MouseAction.Press) MouseXdotool.Press(mouse.Key);

                if (mouse.Action == MouseAction.Release) MouseXdotool.Release(mouse.Key);

                if (mouse.Action == MouseAction.ReleaseAll) MouseXdotool.ReleaseAll();
            }
        }

        public static Mouse GetMousePosition()
        {
            var plataform = GetPlataform();

            if (plataform == Plataform.Windows)
            {
                return MouseExecution.GetPosition();
            }
            else if (plataform == Plataform.Linux)
            {
                return MouseXdotool.GetPosition();
            }

            return null;
        }

        public static void KeyboardEvent(Keyboard keyboard)
        {
            var plataform = GetPlataform();

            if (plataform == Plataform.Windows)
            {
                if (keyboard.Action == KeyboardAction.Write) KeyboardExecution.Write(keyboard.Text);

                if (keyboard.Action == KeyboardAction.Click)
                {
                    if (keyboard.PrimaryKey != KKeys.None) KeyboardExecution.Click(keyboard.PrimaryKey);
                    if (keyboard.SecondaryKey != KKeys.None) KeyboardExecution.Click(keyboard.SecondaryKey);
                    if (keyboard.TertiaryKey != KKeys.None) KeyboardExecution.Click(keyboard.TertiaryKey);
                }

                if (keyboard.Action == KeyboardAction.Press)
                {
                    if (keyboard.PrimaryKey != KKeys.None) KeyboardExecution.Press(keyboard.PrimaryKey);
                    if (keyboard.SecondaryKey != KKeys.None) KeyboardExecution.Press(keyboard.SecondaryKey);
                    if (keyboard.TertiaryKey != KKeys.None) KeyboardExecution.Press(keyboard.TertiaryKey);
                }

                if (keyboard.Action == KeyboardAction.Release)
                {
                    if (keyboard.PrimaryKey != KKeys.None) KeyboardExecution.Release(keyboard.PrimaryKey);
                    if (keyboard.SecondaryKey != KKeys.None) KeyboardExecution.Release(keyboard.SecondaryKey);
                    if (keyboard.TertiaryKey != KKeys.None) KeyboardExecution.Release(keyboard.TertiaryKey);
                }

                if (keyboard.Action == KeyboardAction.ReleaseAll) KeyboardExecution.ReleaseAll();
            }
            else if (plataform == Plataform.Linux)
            {
                
            }
        }

        public static string GetKeyPress()
        {
            var plataform = GetPlataform();

            if (plataform == Plataform.Windows)
            {
                return KeyboardExecution.GetKeyPress();
            }
            else if (plataform == Plataform.Linux)
            {
                return null;
            }

            return null;
        }

        public static void GetPixelColor(PixelColor pixelColor)
        {
            var plataform = GetPlataform();

            if (plataform == Plataform.Windows)
            {

            }
            else if (plataform == Plataform.Linux)
            {
                
            }
        }

        public static void Message(string title, string content)
        {
            var plataform = GetPlataform();

            if (plataform == Plataform.Windows)
            {

            }
            else if (plataform == Plataform.Linux)
            {

            }
        }

        public static void Sleep(double time)
        {
            time = Math.Round(time, 2) * 1000;

            int formatTime = int.Parse(time.ToString());

            Thread.Sleep(formatTime);
        }
    }
}