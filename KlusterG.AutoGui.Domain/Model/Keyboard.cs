namespace KlusterG.AutoGui.Domain.Model
{
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
            Action = KeyboardAction.None;
        }
    }
}
