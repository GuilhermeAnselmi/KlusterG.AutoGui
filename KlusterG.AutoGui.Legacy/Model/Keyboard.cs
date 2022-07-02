using KlusterG.AutoGui.Legacy.InternalKeys;

namespace KlusterG.AutoGui.Legacy
{
    public enum KeyboardAction
    {
        Write = 1,
        Click = 2,
        Press = 3,
        Release = 4,
        ReleaseAll = 5,
    }

    public class Keyboard
    {
        public string Text { get; set; }
        public KKeys PrimaryKey { get; set; }
        public KKeys SecondaryKey { get; set; }
        public KKeys TertiaryKey { get; set; }
        public KeyboardAction Action { get; set; }

        public Keyboard()
        {
            Text = "";
            PrimaryKey = KKeys.None;
            SecondaryKey = KKeys.None;
            TertiaryKey = KKeys.None;
            Action = KeyboardAction.Write;
        }
    }
}
