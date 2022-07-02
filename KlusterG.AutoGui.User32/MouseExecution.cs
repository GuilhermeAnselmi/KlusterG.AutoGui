using KlusterG.AutoGui.Domain;
using KlusterG.AutoGui.Domain.Model;
using static KlusterG.AutoGui.User32.Structs;

namespace KlusterG.AutoGui.User32
{
    public class MouseExecution
    {
        public static void Click(MKeys key = MKeys.Left)
        {
            try
            {
                if (key == MKeys.Left)
                {
                    External.MouseEvet((int)EnumMouseKeys.LeftPress, 0, 0, 0, 0);
                    External.MouseEvet((int)EnumMouseKeys.LeftDrop, 0, 0, 0, 0);
                }
                else if (key == MKeys.Right)
                {
                    External.MouseEvet((int)EnumMouseKeys.RightPress, 0, 0, 0, 0);
                    External.MouseEvet((int)EnumMouseKeys.RightDrop, 0, 0, 0, 0);
                }
                else if (key == MKeys.Middle)
                {
                    External.MouseEvet((int)EnumMouseKeys.MiddlePress, 0, 0, 0, 0);
                    External.MouseEvet((int)EnumMouseKeys.MiddleDrop, 0, 0, 0, 0);
                }
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
                if (key == MKeys.Left)
                {
                    External.MouseEvet((int)EnumMouseKeys.LeftPress, 0, 0, 0, 0);
                    External.MouseEvet((int)EnumMouseKeys.LeftDrop, 0, 0, 0, 0);

                    Thread.Sleep(200);

                    External.MouseEvet((int)EnumMouseKeys.LeftPress, 0, 0, 0, 0);
                    External.MouseEvet((int)EnumMouseKeys.LeftDrop, 0, 0, 0, 0);
                }
                else if (key == MKeys.Right)
                {
                    External.MouseEvet((int)EnumMouseKeys.RightPress, 0, 0, 0, 0);
                    External.MouseEvet((int)EnumMouseKeys.RightDrop, 0, 0, 0, 0);

                    Thread.Sleep(200);

                    External.MouseEvet((int)EnumMouseKeys.RightPress, 0, 0, 0, 0);
                    External.MouseEvet((int)EnumMouseKeys.RightDrop, 0, 0, 0, 0);
                }
                else if (key == MKeys.Middle)
                {
                    External.MouseEvet((int)EnumMouseKeys.MiddlePress, 0, 0, 0, 0);
                    External.MouseEvet((int)EnumMouseKeys.MiddleDrop, 0, 0, 0, 0);

                    Thread.Sleep(200);

                    External.MouseEvet((int)EnumMouseKeys.MiddlePress, 0, 0, 0, 0);
                    External.MouseEvet((int)EnumMouseKeys.MiddleDrop, 0, 0, 0, 0);
                }
            }
            catch (Exception ex)
            {
                throw new MouseException($"Double Click Error: {ex}");
            }
        }

        public static void Press(MKeys key)
        {
            try
            {
                if (key == MKeys.Left)
                {
                    External.MouseEvet((int)EnumMouseKeys.LeftPress, 0, 0, 0, 0);
                }
                else if (key == MKeys.Right)
                {
                    External.MouseEvet((int)EnumMouseKeys.RightPress, 0, 0, 0, 0);
                }
                else if (key == MKeys.Middle)
                {
                    External.MouseEvet((int)EnumMouseKeys.MiddlePress, 0, 0, 0, 0);
                }
            }
            catch (Exception ex)
            {
                throw new MouseException($"Mouse Press Error: {ex}");
            }
        }

        public static void Release(MKeys key)
        {
            try
            {
                if (key == MKeys.Left)
                {
                    if (External.GetAsyncKeyState(1) == -32767)
                    {
                        External.MouseEvet((int)EnumMouseKeys.LeftDrop, 0, 0, 0, 0);
                    }
                }
                else if (key == MKeys.Right)
                {
                    if (External.GetAsyncKeyState(2) == -32767)
                    {
                        External.MouseEvet((int)EnumMouseKeys.RightDrop, 0, 0, 0, 0);
                    }
                }
                else if (key == MKeys.Middle)
                {
                    if (External.GetAsyncKeyState(4) == -32767)
                    {
                        External.MouseEvet((int)EnumMouseKeys.MiddleDrop, 0, 0, 0, 0);
                    }
                }
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
                External.MouseEvet((int)EnumMouseKeys.LeftDrop, 0, 0, 0, 0);
                External.MouseEvet((int)EnumMouseKeys.RightDrop, 0, 0, 0, 0);
                External.MouseEvet((int)EnumMouseKeys.MiddleDrop, 0, 0, 0, 0);
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
                External.SetCursorPos(x, y);
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

                CursorPosition lpPoint;
                External.GetCursorPos(out lpPoint);

                mouse.X = lpPoint.X;
                mouse.Y = lpPoint.Y;

                return mouse;
            }
            catch (Exception ex)
            {
                throw new MouseException($"Get Mouse Position Error: {ex}");
            }
        }
    }
}
