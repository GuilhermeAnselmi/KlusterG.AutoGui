using KlusterG.AutoGui.Legacy.InternalKeys;

namespace KlusterG.AutoGui.Legacy
{
    public enum MouseAction
    {
        None = 0,
        Click = 1,
        Double = 2,
        Press = 3,
        Release = 4,
        ReleaseAll = 5,
    }

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
            Key = MKeys.Left;
            Action = MouseAction.Click;
        }
    }
}
