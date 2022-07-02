namespace KlusterG.AutoGui.Domain.Model
{
    public class Mouse
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Move { get; set; }
        public MKeys Key { get; set; }
        public MouseAction Action { get; set; }

        public Mouse()
        {
            X = 0;
            Y = 0;
            Move = false;
            Key = MKeys.None;
            Action = MouseAction.None;
        }
    }
}
