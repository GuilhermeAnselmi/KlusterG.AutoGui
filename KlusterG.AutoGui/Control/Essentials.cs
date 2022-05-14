using System.Text.RegularExpressions;

namespace KlusterG.AutoGui
{
    internal class Essentials
    {
        public static bool IsTextNumeric(string value)
        {
            if (value == null) return true;

            value = value.Replace(",", ".");

            // Allow: a-z A-Z 0-9 Space
            if (Regex.IsMatch(value, @"[!@#$%¨&*()_+=§¹²³£¢¬:;<,>.?/}^[\]\\~{`´-]")) return false;

            return true;
        }

        public static bool IsEmail(string value)
        {
            if (value == null) return true;

            // Allow: a-z A-Z 0-9 . @ _
            if (Regex.IsMatch(value, @"[!#$%¨&*()+=§¹²³£¢¬:;<,>?/}^[\]\\~{` ´-]")) return false;

            if (value.Split('@').Length != 2) return false;

            if (value.Split('@')[0].Length == 0) return false;

            if (value.Split('@')[1].Length < 9) return false;

            if (value.Substring(value.Length - 4, 4) != ".com" && value.Substring(value.Length - 7, 7) != ".com.br") return false;

            return true;
        }

        public static bool IsPassword(string value)
        {
            if (value == null) return true;

            value = value.Replace(",", ".");

            // Allow: a-z A-Z 0-9 ! @ % _ ? -
            if (Regex.IsMatch(value, @"[#$¨&*()+=§¹²³£¢¬:;<,>./}^[\]\\~{` ´]")) return false;

            return true;
        }

        public static bool IsText(string value, bool space = false)
        {
            value = value.Replace(",", ".");

            if (!space)
            {
                // Allow: a-z A-Z Space
                if (Regex.IsMatch(value, @"[0-9!@#$%¨&*()_+=§¹²³£¢¬:;<,>.?/}^[\]\\~{` ´-]")) return false;
            }
            else
            {
                // Allow: a-z A-Z
                if (Regex.IsMatch(value, @"[0-9!@#$%¨&*()_+=§¹²³£¢¬:;<,>.?/}^[\]\\~{`´-]")) return false;
            }

            return true;
        }

        public static bool IsPercentage(string value)
        {
            value = value.Replace(",", ".");

            // Allow: 0-9 % .
            if (Regex.IsMatch(value, @"[a-zA-Z!@#$¨&*()_+=§¹²³£¢¬:;<,>?/}^[\]\\~{` ´-]")) return false;

            return true;
        }

        public static bool IsMoney(string value)
        {
            value = value.Replace(",", ".");

            // Allow: 0-9 .
            if (Regex.IsMatch(value, @"[a-zA-Z!@#$%¨&*()_+=§¹²³£¢¬:;<,>?/}^[\]\\~{` ´-]")) return false;

            return true;
        }

        public static bool IsNumeric(string value)
        {
            try
            {
                int.Parse(value);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsUpperCase(string value)
        {
            if (Regex.IsMatch(value, @"[A-Z]")) return true;

            return false;
        }

        public static bool IsRealNumeric(string value)
        {
            try
            {
                double.Parse(value);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidCpf(string value)
        {
            List<int> cpf = new List<int>();

            if (value.Length != 11) return false;

            try
            {
                int multi = 10, calc = 0, digitOne, digitTwo;

                for (int i = 0; i < value.Length; i++)
                {
                    cpf.Add(int.Parse(value.Substring(i, 1)));
                }

                for (int i = 0; i < 9; i++)
                {
                    calc += cpf[i] * multi;

                    multi--;
                }

                digitOne = (11 - (calc % 11)) >= 10 ? 0 : (11 - (calc % 11));

                multi = 11;
                calc = 0;

                for (int i = 0; i < 9; i++)
                {
                    calc += cpf[i] * multi;

                    multi--;
                }

                calc += digitOne * multi;

                digitTwo = (11 - (calc % 11)) >= 10 ? 0 : (11 - (calc % 11));

                return digitOne == cpf[9] && digitTwo == cpf[10];
            }
            catch
            {
                return false;
            }
        }
    }
}
