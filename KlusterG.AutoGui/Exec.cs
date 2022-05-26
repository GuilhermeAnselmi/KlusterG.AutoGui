using KlusterG.AutoGui.Control;
using KlusterG.AutoGui.InternalKeys;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using static KlusterG.AutoGui.Structs;

namespace KlusterG.AutoGui
{
    public class Exec
    {
        private static readonly uint KEYEVENF_KEYUP = 0x0002;
        private static readonly uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        private static KeyboardControl kControl = new KeyboardControl();
        private static Bitmap bitmap = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        #region Message
        /// <summary>
        /// Send message on screen this user
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> Message(string title, string content)
        {
            try
            {
                if (title != null && content != null)
                {
                    External.MessageBox(0, content, title, 0);

                    return new Tuple<bool, string>(true, null);
                }
                else
                {
                    return new Tuple<bool, string>(false, "Title and content cannot be null");
                }
            }
            catch (Exception ex)
            {
                throw new ExecException($"Fatal Error: {ex}");
            }
        }
        #endregion

        #region Mouse
        /// <summary>
        /// Simulation of clicking this mouse
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> MouseClick(MKeys key)
        {
            try
            {
                if (key == MKeys.Left)
                {
                    External.MouseEvet((int)MouseKeys.LeftPress, 0, 0, 0, 0);
                    External.MouseEvet((int)MouseKeys.LeftDrop, 0, 0, 0, 0);

                    return new Tuple<bool, string>(true, null);
                }
                else if (key == MKeys.Right)
                {
                    External.MouseEvet((int)MouseKeys.RightPress, 0, 0, 0, 0);
                    External.MouseEvet((int)MouseKeys.RightDrop, 0, 0, 0, 0);

                    return new Tuple<bool, string>(true, null);
                }
                else if (key == MKeys.Middle)
                {
                    External.MouseEvet((int)MouseKeys.MiddlePress, 0, 0, 0, 0);
                    External.MouseEvet((int)MouseKeys.MiddleDrop, 0, 0, 0, 0);

                    return new Tuple<bool, string>(true, null);
                }

                return new Tuple<bool, string>(false, "MKeys cannot be null or none");
            }
            catch (Exception ex)
            {
                string title = "MouseClick Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Simulation of dobule clicking this mouse
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> MouseDoubleClick(MKeys key = MKeys.Left)
        {
            try
            {
                if (key == MKeys.Left)
                {
                    External.MouseEvet((int)MouseKeys.LeftPress, 0, 0, 0, 0);
                    External.MouseEvet((int)MouseKeys.LeftDrop, 0, 0, 0, 0);

                    Thread.Sleep(200);

                    External.MouseEvet((int)MouseKeys.LeftPress, 0, 0, 0, 0);
                    External.MouseEvet((int)MouseKeys.LeftDrop, 0, 0, 0, 0);

                    return new Tuple<bool, string>(true, null);
                }
                else if (key == MKeys.Right)
                {
                    External.MouseEvet((int)MouseKeys.RightPress, 0, 0, 0, 0);
                    External.MouseEvet((int)MouseKeys.RightDrop, 0, 0, 0, 0);

                    Thread.Sleep(200);

                    External.MouseEvet((int)MouseKeys.RightPress, 0, 0, 0, 0);
                    External.MouseEvet((int)MouseKeys.RightDrop, 0, 0, 0, 0);

                    return new Tuple<bool, string>(true, null);
                }
                else if (key == MKeys.Middle)
                {
                    External.MouseEvet((int)MouseKeys.MiddlePress, 0, 0, 0, 0);
                    External.MouseEvet((int)MouseKeys.MiddleDrop, 0, 0, 0, 0);

                    Thread.Sleep(200);

                    External.MouseEvet((int)MouseKeys.MiddlePress, 0, 0, 0, 0);
                    External.MouseEvet((int)MouseKeys.MiddleDrop, 0, 0, 0, 0);

                    return new Tuple<bool, string>(true, null);
                }

                return new Tuple<bool, string>(false, "MKeys cannot be null or none");
            }
            catch (Exception ex)
            {
                string title = "MouseDoubleClick Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Simulation of pressing mouse click
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> MousePress(MKeys key)
        {
            try
            {
                if (key == MKeys.Left)
                {
                    External.MouseEvet((int)MouseKeys.LeftPress, 0, 0, 0, 0);

                    return new Tuple<bool, string>(true, null);
                }
                else if (key == MKeys.Right)
                {
                    External.MouseEvet((int)MouseKeys.RightPress, 0, 0, 0, 0);

                    return new Tuple<bool, string>(true, null);
                }
                else if (key == MKeys.Middle)
                {
                    External.MouseEvet((int)MouseKeys.MiddlePress, 0, 0, 0, 0);

                    return new Tuple<bool, string>(true, null);
                }

                return new Tuple<bool, string>(false, "MKeys cannot be null or none");
            }
            catch (Exception ex)
            {
                string title = "MousePress Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Release mouse key pressed
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> ReleaseMouse(MKeys key)
        {
            try
            {
                if (key == MKeys.Left)
                {
                    if (External.GetAsyncKeyState(1) == -32767)
                    {
                        External.MouseEvet((int)MouseKeys.LeftDrop, 0, 0, 0, 0);
                    }

                    return new Tuple<bool, string>(true, null);
                }
                else if (key == MKeys.Right)
                {
                    if (External.GetAsyncKeyState(2) == -32767)
                    {
                        External.MouseEvet((int)MouseKeys.RightDrop, 0, 0, 0, 0);
                    }

                    return new Tuple<bool, string>(true, null);
                }
                else if (key == MKeys.Middle)
                {
                    if (External.GetAsyncKeyState(4) == -32767)
                    {
                        External.MouseEvet((int)MouseKeys.MiddleDrop, 0, 0, 0, 0);
                    }

                    return new Tuple<bool, string>(true, null);
                }

                return new Tuple<bool, string>(false, "MKeys cannot be null or none");
            }
            catch (Exception ex)
            {
                string title = "MouseDrop Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Release all mouse keys
        /// </summary>
        /// <exception cref="ExecException"></exception>
        public static void ReleaseMouseKeys()
        {
            try
            {
                External.MouseEvet((int)MouseKeys.LeftDrop, 0, 0, 0, 0);
                External.MouseEvet((int)MouseKeys.RightDrop, 0, 0, 0, 0);
                External.MouseEvet((int)MouseKeys.MiddleDrop, 0, 0, 0, 0);
            }
            catch (Exception ex)
            {
                string title = "DropMouseKey Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Move mouse cursor to X and Y positions
        /// </summary>
        /// <param name="mouse"></param>
        /// <exception cref="ExecException"></exception>
        public static void SetCursorPosition(Mouse mouse)
        {
            try
            {
                External.SetCursorPos(mouse.X, mouse.Y);
            }
            catch (Exception ex)
            {
                string title = "MouseMove Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Get mouse position
        /// </summary>
        /// <returns>Mouse</returns>
        /// <exception cref="ExecException"></exception>
        public static Mouse GetCursorPosition()
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
                string title = "GetMousePosition Error";

                throw new ExecException($"{title}: {ex}");
            }
        }
        #endregion

        #region Keyboard
        /// <summary>
        /// Simulates keyboard typing
        /// </summary>
        /// <param name="text"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> Write(string text)
        {
            try
            {
                if (text != null && text != "")
                {
                    char[] values = text.ToCharArray();

                    foreach (char value in values)
                    {
                        if (Regex.IsMatch(value.ToString(), @"[a-z0-9]"))
                        {
                            var hex = Convert.ToInt32(char.Parse(value.ToString().ToUpper()));

                            External.KeyboardEvent((byte)hex, 0, 0, UIntPtr.Zero);
                            External.KeyboardEvent((byte)hex, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
                        }
                        else if (!Regex.IsMatch(value.ToString(), @"[A-Z]"))
                        {
                            List<byte> list = ShortcutControl.Shortcut(value);

                            if (list != null && list.Count > 0)
                            {
                                foreach (byte b in list)
                                {
                                    External.KeyboardEvent((byte)b, 0, 0, UIntPtr.Zero);
                                }

                                foreach (byte b in list)
                                {
                                    External.KeyboardEvent((byte)b, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
                                }

                                if (list.Contains((byte)KKeys.Caps))
                                {
                                    External.KeyboardEvent((byte)KKeys.Caps, 0, 0, UIntPtr.Zero);
                                    External.KeyboardEvent((byte)KKeys.Caps, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
                                }
                            }
                            else
                            {
                                return new Tuple<bool, string>(false, $"The value '{value}' cannot be identified, so nothing was written.");
                            }
                        }
                        else
                        {
                            External.KeyboardEvent((byte)KKeys.Shift, 0, 0, UIntPtr.Zero);

                            var hex = Convert.ToInt32(char.Parse(value.ToString().ToUpper()));

                            External.KeyboardEvent((byte)hex, 0, 0, UIntPtr.Zero);
                            External.KeyboardEvent((byte)hex, 0, KEYEVENF_KEYUP, UIntPtr.Zero);

                            External.KeyboardEvent((byte)KKeys.Shift, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
                        }
                    }

                    return new Tuple<bool, string>(true, null);
                }
                else
                {
                    return new Tuple<bool, string>(false, "Text cannot be null or empty");
                }
            }
            catch (Exception ex)
            {
                string title = "Write Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Simulates a single keyboard click
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> KeyClick(KKeys key = KKeys.None)
        {
            try
            {
                if (key != KKeys.None)
                {
                    External.KeyboardEvent((byte)key, 0, 0, UIntPtr.Zero);

                    Thread.Sleep(300);

                    External.KeyboardEvent((byte)key, 0, KEYEVENF_KEYUP, UIntPtr.Zero);

                    return new Tuple<bool, string>(true, null);
                }
                else
                {
                    return new Tuple<bool, string>(false, "KKeys cannot be none");
                }
            }
            catch (Exception ex)
            {
                string title = "KeyPress Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Press a keyboard key
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> KeyPress(KKeys key = KKeys.None)
        {
            try
            {
                if (key != KKeys.None)
                {
                    External.KeyboardEvent((byte)key, 0, 0, UIntPtr.Zero);
                    kControl.AddKeyPress(key);

                    return new Tuple<bool, string>(true, null);
                }
                else
                {
                    return new Tuple<bool, string>(false, "KKeys cannot be none");
                }
            }
            catch (Exception ex)
            {
                string title = "KeyPress Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Release the pressed key on the keyboard
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> ReleaseKey(KKeys key = KKeys.None)
        {
            try
            {
                if (key != KKeys.None)
                {
                    External.KeyboardEvent((byte)key, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
                    kControl.RemoveKeyPress(key);

                    return new Tuple<bool, string>(true, null);
                }
                else
                {
                    return new Tuple<bool, string>(false, "KKeys cannot be none");
                }
            }
            catch (Exception ex)
            {
                string title = "KeyDrop Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Release the pressed key from the keyboard
        /// </summary>
        /// <exception cref="ExecException"></exception>
        public static void ReleaseKeyboardKeys()
        {
            try
            {
                kControl.ClearKeys();
            }
            catch (Exception ex)
            {
                string title = "DropKeyboardKeys Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Get the key that was pressed
        /// </summary>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> GetKeyPress()
        {
            try
            {
                for (int key = 0; key < 255; key++)
                {
                    if (External.GetAsyncKeyState(key) == -32767)
                    {
                        char keyPress = Convert.ToChar(key);

                        if (Essentials.IsNumeric(keyPress.ToString()) || Essentials.IsUpperCase(keyPress.ToString()))
                        {
                            return new Tuple<bool, string>(true, keyPress.ToString());
                        }
                        else
                        {
                            return new Tuple<bool, string>(false, null);
                        }
                    }
                }

                return new Tuple<bool, string>(false, null);
            }
            catch (Exception ex)
            {
                string title = "GetKeyPress Error";

                throw new ExecException($"{title}: {ex}");
            }
        }
        #endregion

        /// <summary>
        /// Release all keys (keyboard and mouse)
        /// </summary>
        public static void ReleaseAllKeys()
        {
            ReleaseMouseKeys();
            ReleaseKeyboardKeys();
        }

        /// <summary>
        /// Get the color of the pixel that was indicated
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns>pColor</returns>
        /// <exception cref="ExecException"></exception>
        public static PixelColor GetPixelColor(int X, int Y)
        {
            try
            {
                Point point = new Point(X, Y);

                using (Graphics gdest = Graphics.FromImage(bitmap))
                {
                    using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                    {
                        IntPtr hSrcDC = gsrc.GetHdc();
                        IntPtr hDC = gdest.GetHdc();

                        int retval = External.BitBlt(hDC, 0, 0, 1, 1, hSrcDC, point.X, point.Y, (int)CopyPixelOperation.SourceCopy);

                        gdest.ReleaseHdc();
                        gsrc.ReleaseHdc();
                    }
                }

                Color color = bitmap.GetPixel(0, 0);

                PixelColor pColor = new PixelColor();
                pColor.A = color.A;
                pColor.R = color.R;
                pColor.G = color.G;
                pColor.B = color.B;

                return pColor;
            }
            catch (Exception ex)
            {
                string title = "GetPixelColor Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Makes the whole process wait for the parameter time
        /// </summary>
        /// <param name="time"></param>
        /// <exception cref="ExecException"></exception>
        public static void Wait(double time)
        {
            try
            {
                time = Math.Round(time, 2) * 1000;

                int formatTime = int.Parse(time.ToString());

                Thread.Sleep(formatTime);
            }
            catch (Exception ex)
            {
                string title = "Wait Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        /// <summary>
        /// Reads a list from the ModelRoutine object that executes each index in sequence to execute Mouse or Keyboard simulation commands
        /// </summary>
        /// <param name="routine"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> StartRoutine(List<ModelRoutine> routine)
        {
            try
            {
                if (routine != null && routine.Count > 0)
                {
                    foreach (ModelRoutine e in routine)
                    {
                        if (e.Input.Equals(Input.Mouse) || e.Input.Equals(Input.Both))
                        {
                            if (e.Mouse.Move) SetCursorPosition(e.Mouse);

                            switch (e.Mouse.Action)
                            {
                                case MouseAction.Click:
                                    MouseClick(e.Mouse.Key);
                                    break;

                                case MouseAction.Double:
                                    MouseDoubleClick(e.Mouse.Key);
                                    break;

                                case MouseAction.Press:
                                    MousePress(e.Mouse.Key);
                                    break;

                                case MouseAction.Release:
                                    ReleaseMouse(e.Mouse.Key);
                                    break;

                                case MouseAction.ReleaseAll:
                                    ReleaseMouseKeys();
                                    break;
                            }
                        }

                        Wait(0.2);

                        if (e.Input.Equals(Input.Keyboard) || e.Input.Equals(Input.Both))
                        {
                            switch (e.Keyboard.Action)
                            {
                                case KeyboardAction.Write:
                                    Write(e.Keyboard.Text);
                                    break;

                                case KeyboardAction.Click:
                                    if (e.Keyboard.PrimaryKey != KKeys.None) KeyClick(e.Keyboard.PrimaryKey);
                                    if (e.Keyboard.SecondaryKey != KKeys.None) KeyClick(e.Keyboard.SecondaryKey);
                                    if (e.Keyboard.TertiaryKey != KKeys.None) KeyClick(e.Keyboard.TertiaryKey);
                                    break;

                                case KeyboardAction.Press:
                                    if (e.Keyboard.PrimaryKey != KKeys.None) KeyPress(e.Keyboard.PrimaryKey);
                                    if (e.Keyboard.SecondaryKey != KKeys.None) KeyPress(e.Keyboard.SecondaryKey);
                                    if (e.Keyboard.TertiaryKey != KKeys.None) KeyPress(e.Keyboard.TertiaryKey);
                                    break;

                                case KeyboardAction.Release:
                                    if (e.Keyboard.PrimaryKey != KKeys.None) ReleaseKey(e.Keyboard.PrimaryKey);
                                    if (e.Keyboard.SecondaryKey != KKeys.None) ReleaseKey(e.Keyboard.SecondaryKey);
                                    if (e.Keyboard.TertiaryKey != KKeys.None) ReleaseKey(e.Keyboard.TertiaryKey);
                                    break;

                                case KeyboardAction.ReleaseAll:
                                    ReleaseAllKeys();
                                    break;
                            }
                        }

                        Wait(e.Wait);
                    }

                    return new Tuple<bool, string>(true, null);
                }

                return new Tuple<bool, string>(false, "List<ModelRoutine> cannot be null or empty");
            }
            catch (Exception ex)
            {
                string title = "StartRoutine Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        public static Tuple<bool, string> StartProcedure(ModelProcedure procedure)
        {
            try
            {
                if (procedure != null)
                {
                    if (procedure.Input.Equals(InputProcedure.Mouse) || procedure.Input.Equals(InputProcedure.Both))
                    {
                        if (procedure.Mouse.Move) SetCursorPosition(procedure.Mouse);

                        switch (procedure.Mouse.Action)
                        {
                            case MouseAction.Click:
                                MouseClick(procedure.Mouse.Key);
                                break;

                            case MouseAction.Double:
                                MouseDoubleClick(procedure.Mouse.Key);
                                break;

                            case MouseAction.Press:
                                MousePress(procedure.Mouse.Key);
                                break;

                            case MouseAction.Release:
                                ReleaseMouse(procedure.Mouse.Key);
                                break;

                            case MouseAction.ReleaseAll:
                                ReleaseMouseKeys();
                                break;
                        }
                    }

                    Wait(0.2);

                    if (procedure.Input.Equals(InputProcedure.Keyboard) || procedure.Input.Equals(InputProcedure.Both))
                    {
                        switch (procedure.Keyboard.Action)
                        {
                            case KeyboardAction.Write:
                                Write(procedure.Keyboard.Text);
                                break;

                            case KeyboardAction.Click:
                                if (procedure.Keyboard.PrimaryKey != KKeys.None) KeyClick(procedure.Keyboard.PrimaryKey);
                                if (procedure.Keyboard.SecondaryKey != KKeys.None) KeyClick(procedure.Keyboard.SecondaryKey);
                                if (procedure.Keyboard.TertiaryKey != KKeys.None) KeyClick(procedure.Keyboard.TertiaryKey);
                                break;

                            case KeyboardAction.Press:
                                if (procedure.Keyboard.PrimaryKey != KKeys.None) KeyPress(procedure.Keyboard.PrimaryKey);
                                if (procedure.Keyboard.SecondaryKey != KKeys.None) KeyPress(procedure.Keyboard.SecondaryKey);
                                if (procedure.Keyboard.TertiaryKey != KKeys.None) KeyPress(procedure.Keyboard.TertiaryKey);
                                break;

                            case KeyboardAction.Release:
                                if (procedure.Keyboard.PrimaryKey != KKeys.None) ReleaseKey(procedure.Keyboard.PrimaryKey);
                                if (procedure.Keyboard.SecondaryKey != KKeys.None) ReleaseKey(procedure.Keyboard.SecondaryKey);
                                if (procedure.Keyboard.TertiaryKey != KKeys.None) ReleaseKey(procedure.Keyboard.TertiaryKey);
                                break;

                            case KeyboardAction.ReleaseAll:
                                ReleaseAllKeys();
                                break;
                        }
                    }

                    Wait(procedure.Wait);

                    return new Tuple<bool, string>(true, null);
                }

                return new Tuple<bool, string>(false, "ModelRoutine cannot be null");
            }
            catch (Exception ex)
            {
                string title = "StartProcedure Error";

                throw new ExecException($"{title}: {ex}");
            }
        }
    }
}
