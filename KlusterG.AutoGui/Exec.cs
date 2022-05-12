﻿using KlusterG.AutoGui.InternalKeys;
using System.Drawing;
using static KlusterG.AutoGui.Structs;

namespace KlusterG.AutoGui
{
    public class Exec
    {
        private static readonly uint KEYEVENF_KEYUP = 0x0002;
        private static readonly uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        private static KeyboardControl kControl = new KeyboardControl();

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
        /// Simulation of pressing mouse click
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> PressMouse(MKeys key)
        {
            try
            {
                if (key == MKeys.Left)
                {
                    External.MouseEvet((int)MouseKeys.LeftPress, 0, 0, 0, 0);
                }
                else if (key == MKeys.Right)
                {
                    External.MouseEvet((int)MouseKeys.RightPress, 0, 0, 0, 0);
                }
                else if (key == MKeys.Middle)
                {
                    External.MouseEvet((int)MouseKeys.MiddlePress, 0, 0, 0, 0);
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
                    External.MouseEvet((int)MouseKeys.LeftDrop, 0, 0, 0, 0);
                }
                else if (key == MKeys.Right)
                {
                    External.MouseEvet((int)MouseKeys.RightDrop, 0, 0, 0, 0);
                }
                else if (key == MKeys.Middle)
                {
                    External.MouseEvet((int)MouseKeys.MiddleDrop, 0, 0, 0, 0);
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
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> MouseMove(Mouse mouse)
        {
            try
            {
                if (mouse.X != null && mouse.Y != null)
                {
                    External.SetCursorPos(mouse.X, mouse.Y);

                    return new Tuple<bool, string>(true, null);
                }
                else
                {
                    return new Tuple<bool, string>(false, "Mouse object cannot be empty");
                }
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
        public static Mouse GetMousePosition()
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
                    char[] values = text.ToUpper().ToCharArray();

                    foreach (char value in values)
                    {
                        var hex = Convert.ToInt32(value);

                        External.KeyboardEvent((byte)hex, 0, 0, UIntPtr.Zero);
                        External.KeyboardEvent((byte)hex, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
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
        /// Press a keyboard key
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool, string</returns>
        /// <exception cref="ExecException"></exception>
        public static Tuple<bool, string> PressKey(KKeys key = KKeys.None)
        {
            try
            {
                if (key != null && key != KKeys.None)
                {
                    External.KeyboardEvent((byte)key, 0, 0, UIntPtr.Zero);
                    kControl.AddKeyPress(key);

                    return new Tuple<bool, string>(true, null);
                }
                else
                {
                    return new Tuple<bool, string>(false, "KKeys cannot be null or none");
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
                if (key != null && key != KKeys.None)
                {
                    External.KeyboardEvent((byte)key, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
                    kControl.RemoveKeyPress(key);

                    return new Tuple<bool, string>(true, null);
                }
                else
                {
                    return new Tuple<bool, string>(false, "KKeys cannot be null or none");
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
        #endregion

        /// <summary>
        /// Release all keys (keyboard and mouse)
        /// </summary>
        public static void DropAllKeys()
        {
            ReleaseMouseKeys();
            ReleaseKeyboardKeys();
        }

        public static Tuple<bool, string> GetPixelColor()
        {
            try
            {
                return new Tuple<bool, string>(false, "DEVELOPER: NOT IMPLEMENTED");

                return new Tuple<bool, string>(false, "KKeys cannot be null or none");
            }
            catch (Exception ex)
            {
                string title = "GetPixelColor Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        public static Tuple<bool, string> Mouse()
        {
            try
            {
                return new Tuple<bool, string>(false, "DEVELOPER: NOT IMPLEMENTED");

                return new Tuple<bool, string>(false, "KKeys cannot be null or none");
            }
            catch (Exception ex)
            {
                string title = "Mouse Error";

                throw new ExecException($"{title}: {ex}");
            }
        }

        public static Tuple<bool, string> Keyboard()
        {
            try
            {
                return new Tuple<bool, string>(false, "DEVELOPER: NOT IMPLEMENTED");

                return new Tuple<bool, string>(false, "KKeys cannot be null or none");
            }
            catch (Exception ex)
            {
                string title = "Keyboard Error";

                throw new ExecException($"{title}: {ex}");
            }
        }
    }
}
