using KlusterG.AutoGui.Domain;
using KlusterG.Essentials;
using System.Text.RegularExpressions;

namespace KlusterG.AutoGui.User32
{
    public class KeyboardExecution
    {
        private static readonly uint KEYEVENF_KEYUP = 0x0002;
        private static readonly uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        private static List<KKeys> Keys = new List<KKeys>();

        public static void Write(string text)
        {
            try
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
                        List<byte> list = ShurtcutList.Shortcut(value);

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
            }
            catch (Exception ex)
            {
                throw new KeyboardException($"Keyboard Write Error: {ex}");
            }
        }

        public static void Click(KKeys key)
        {
            try
            {
                External.KeyboardEvent((byte)key, 0, 0, UIntPtr.Zero);

                Thread.Sleep(150);

                External.KeyboardEvent((byte)key, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
            }
            catch (Exception ex)
            {
                throw new KeyboardException($"Keyboard Click Error: {ex}");
            }
        }

        public static void Press(KKeys key)
        {
            try
            {
                External.KeyboardEvent((byte)key, 0, 0, UIntPtr.Zero);
                Keys.Add(key);
            }
            catch (Exception ex)
            {
                throw new KeyboardException($"Keyboard Press Error: {ex}");
            }
        }

        public static void Release(KKeys key)
        {
            try
            {
                External.KeyboardEvent((byte)key, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
                Keys.Remove(key);
            }
            catch (Exception ex)
            {
                throw new KeyboardException($"Keyboard Release Error: {ex}");
            }
        }

        public static void ReleaseAll()
        {
            try
            {
                foreach (KKeys key in Keys)
                {
                    External.KeyboardEvent((byte)key, 0, KEYEVENF_KEYUP, UIntPtr.Zero);
                }

                Keys.Clear();
            }
            catch (Exception ex)
            {
                throw new KeyboardException($"Keyboard Release All Error: {ex}");
            }
        }

        public static string GetKeyPress()
        {
            try
            {
                for (int key = 0; key < 255; key++)
                {
                    if (External.GetAsyncKeyState(key) == -32767)
                    {
                        char keyPress = Convert.ToChar(key);

                        if (Essent.IsNumeric(keyPress.ToString()).Item1 || Regex.IsMatch(keyPress.ToString(), @"[A-Z]"))
                        {
                            return keyPress.ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new KeyboardException($"Get Keyboard Key Error: {ex}");
            }
        }
    }
}
