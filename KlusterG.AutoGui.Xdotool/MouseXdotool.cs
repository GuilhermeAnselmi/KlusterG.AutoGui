using KlusterG.AutoGui.Domain;
using KlusterG.AutoGui.Domain.Model;
using System.Diagnostics;

namespace KlusterG.AutoGui.Xdotool
{
    public class MouseXdotool
    {
        public static void Click(MKeys key = MKeys.Left)
        {
            try
            {
                string keyCommand = "1";

                if (key == MKeys.Right) keyCommand = "3";

                if (key == MKeys.Middle) keyCommand = "2";

                Command command = new Command();
                command.Process = "xdotool";
                command.Args = new List<string>()
                {
                    "click",
                    keyCommand
                };

                command.Run();
            }
            catch (Exception ex)
            {
                throw new MouseException($"Mouse Click Error: {ex}");
            }
        }

        public static void Double(MKeys key = MKeys.Left)
        {
            try
            {
                string keyCommand = "1";

                if (key == MKeys.Right) keyCommand = "3";

                if (key == MKeys.Middle) keyCommand = "2";

                Command command = new Command();
                command.Process = "xdotool";
                command.Args = new List<string>()
                {
                    "click",
                    keyCommand
                };

                command.Run();

                Thread.Sleep(150);

                command.Run();
            }
            catch (Exception ex)
            {
                throw new MouseException($"Mouse Click Error: {ex}");
            }
        }

        public static void Press(MKeys key = MKeys.Left)
        {
            try
            {
                string keyCommand = "1";

                if (key == MKeys.Right) keyCommand = "3";

                if (key == MKeys.Middle) keyCommand = "2";

                Command command = new Command();
                command.Process = "xdotool";
                command.Args = new List<string>()
                {
                    "mousedown",
                    keyCommand
                };

                command.Run();
            }
            catch (Exception ex)
            {
                throw new MouseException($"Mouse Press Error: {ex}");
            }
        }

        public static void Release(MKeys key = MKeys.Left)
        {
            try
            {
                string keyCommand = "1";

                if (key == MKeys.Right) keyCommand = "3";

                if (key == MKeys.Middle) keyCommand = "2";

                Command command = new Command();
                command.Process = "xdotool";
                command.Args = new List<string>()
                {
                    "mouseup",
                    keyCommand
                };

                command.Run();
            }
            catch (Exception ex)
            {
                throw new MouseException($"Release Mouse Error: {ex}");
            }
        }

        public static void ReleaseAll()
        {
            try
            {
                Command command = new Command();
                command.Process = "xdotool";
                command.Args = new List<string>()
                {
                    "mouseup",
                    "1"
                };

                command.Run();

                command.Args = new List<string>()
                {
                    "mouseup",
                    "2"
                };

                command.Run();

                command.Args = new List<string>()
                {
                    "mouseup",
                    "3"
                };

                command.Run();
            }
            catch (Exception ex)
            {
                throw new MouseException($"Release All Mouse Error: {ex}");
            }
        }

        public static void SetPosition(int x, int y)
        {
            try
            {
                Command command = new Command();
                command.Process = "xdotool";
                command.Args = new List<string>()
                {
                    "mousemove",
                    x.ToString(),
                    y.ToString()
                };

                command.Run();
            }
            catch (Exception ex)
            {
                throw new MouseException($"Set Mouse Position Error: {ex}");
            }
        }

        public static Mouse GetPosition()
        {
            try
            {
                Mouse mouse = new Mouse();

                Command command = new Command();
                command.Process = "xdotool";
                command.Args = new List<string>()
                {
                    "getmouselocation"
                };

                command.Run();

                var infos = command.Output.Split(' ');

                mouse.X = int.Parse(infos[0].Split(':')[1]);
                mouse.Y = int.Parse(infos[1].Split(':')[1]);

                return mouse;
            }
            catch (Exception ex)
            {
                throw new MouseException($"Get Mouse Position Error: {ex}");
            }
        }
    }
}
