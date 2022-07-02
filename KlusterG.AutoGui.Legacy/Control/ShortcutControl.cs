using KlusterG.AutoGui.Legacy.InternalKeys;

namespace KlusterG.AutoGui.Legacy.Control
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

                case '\\':
                    list.Add(226);
                    break;

                case 'ç':
                    list.Add(186);
                    break;

                case 'Ç':
                    list.Add((byte)KKeys.Shift);
                    list.Add(186);
                    break;

                case 'á':
                    list.Add(219);
                    list.Add((byte)KKeys.A);
                    break;

                case 'Á':
                    list.Add(219);
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.A);
                    break;

                case 'é':
                    list.Add(219);
                    list.Add((byte)KKeys.E);
                    break;

                case 'É':
                    list.Add(219);
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.E);
                    break;

                case 'í':
                    list.Add(219);
                    list.Add((byte)KKeys.I);
                    break;

                case 'Í':
                    list.Add(219);
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.I);
                    break;

                case 'ó':
                    list.Add(219);
                    list.Add((byte)KKeys.O);
                    break;

                case 'Ó':
                    list.Add(219);
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.O);
                    break;

                case 'ú':
                    list.Add(219);
                    list.Add((byte)KKeys.U);
                    break;

                case 'Ú':
                    list.Add(219);
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.U);
                    break;

                case 'ã':
                    list.Add(222);
                    list.Add((byte)KKeys.A);
                    break;

                case 'Ã':
                    list.Add(222);
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.A);
                    break;

                case 'õ':
                    list.Add(222);
                    list.Add((byte)KKeys.O);
                    break;

                case 'Õ':
                    list.Add(222);
                    list.Add((byte)KKeys.Shift);
                    list.Add((byte)KKeys.O);
                    break;

                case 'ê':
                    list.Add((byte)KKeys.Shift);
                    list.Add(222);
                    list.Add((byte)KKeys.Caps);
                    list.Add((byte)KKeys.E);
                    break;

                case 'Ê':
                    list.Add((byte)KKeys.Shift);
                    list.Add(222);
                    list.Add((byte)KKeys.E);
                    break;

                case '[':
                    list.Add(221);
                    break;

                case ']':
                    list.Add(220);
                    break;

                case '<':
                    list.Add((byte)KKeys.Shift);
                    list.Add(188);
                    break;

                case '>':
                    list.Add((byte)KKeys.Shift);
                    list.Add(190);
                    break;

                default:
                    list = null;
                    break;
            }

            return list;
        }
    }
}
