using KlusterG.AutoGui.Domain;

namespace KlusterG.AutoGui.Xdotool
{
    public class KeyboardXdotool
    {
        public static void Write(string text)
        {
            try
            {
                
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
                

                return null;
            }
            catch (Exception ex)
            {
                throw new KeyboardException($"Get Keyboard Key Error: {ex}");
            }
        }
    }
}