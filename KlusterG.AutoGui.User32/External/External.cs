using System.Runtime.InteropServices;

namespace KlusterG.AutoGui.User32
{
    internal class External
    {
        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        public static extern void MouseEvet(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void KeyboardEvent(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern int MessageBox(int hWnd, String text, String caption, uint type);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Structs.CursorPosition lpPoint);

        [DllImport("user32.dll")]
        public static extern void SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern Int16 GetAsyncKeyState(int vKey);

        [DllImport("user32.dll")]
        public static extern bool SendInput(uint xInputs, Structs.INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        public static extern bool GetKeyState(int nVirtKey);

        [DllImport("gdi32.dll")]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
    }
}