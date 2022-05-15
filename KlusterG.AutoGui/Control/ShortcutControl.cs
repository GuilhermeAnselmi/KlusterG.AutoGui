using KlusterG.AutoGui.InternalKeys;

namespace KlusterG.AutoGui.Control
{
    internal class ShortcutControl
    {
        public static List<byte> Shortcut(char value)
        {
            List<byte> list = new List<byte>();

            switch (value)
            {
                case ' ':
                    list.Add(32);
                    break;

                case '!':
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.One);
                    break;

                case '@':
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.Two);
                    break;

                case '#':
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.Three);
                    break;

                case '$':
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.Four);
                    break;

                case '%':
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.Five);
                    break;

                case '&':
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.Seven);
                    break;

                case '*':
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.Eight);
                    break;

                case '(':
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.Nine);
                    break;

                case ')':
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.Zero);
                    break;

                case '/':
                    list.Add(111);
                    break;

                case ';':
                    list.Add(191);
                    break;

                case '.':
                    list.Add(190);
                    break;

                case ',':
                    list.Add(188);
                    break;

                case '-':
                    list.Add(189);
                    break;

                case '_':
                    list.Add((byte)KKeys.Shift);
                    list.Add(189);
                    break;

                case '+':
                    list.Add(107);
                    break;

                case '=':
                    list.Add(187);
                    break;

                case ':':
                    list.Add((byte)KKeys.Shift);
                    list.Add(191);
                    break;

                case '?':
                    list.Add((byte)KKeys.Shift);
                    list.Add(193);
                    break;

                case '\'':
                    list.Add(192);
                    break;

                case '"':
                    list.Add((byte)KKeys.Shift);
                    list.Add(192);
                    break;

                default:
                    list = null;
                    break;
            }

            return list;
        }
    }
}
