namespace KlusterG.AutoGui.Domain.Model
{
    public class PixelColor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }
        public byte A { get; private set; }

        public PixelColor()
        {
            X = 0;
            Y = 0;
            R = 0;
            G = 0;
            B = 0;
            A = 0;
        }
    }
}
