using KlusterG.AutoGui.InternalKeys;

namespace KlusterG.AutoGui
{
    public enum KeyboardAction
    {
        Write = 1,
        Press = 2,
        Release = 3,
        ReleaseAll = 4,
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
