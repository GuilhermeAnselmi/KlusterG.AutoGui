
namespace KlusterG.AutoGui.Legacy
{
    public enum Input
    {
        None = 0,
        Mouse = 1,
        Keyboard = 2,
        Both = 3,
    }

    public class ModelRoutine
    {
        public Mouse Mouse { get; set; }
        public Keyboard Keyboard { get; set; }
        public Input Input { get; set; }
        public double Wait { get; set; }

        public ModelRoutine()
        {
            Mouse = new Mouse();
            Keyboard = new Keyboard();
            Input = Input.None;
            Wait = 0;
        }
    }
}
