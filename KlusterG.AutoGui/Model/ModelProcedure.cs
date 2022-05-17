
namespace KlusterG.AutoGui
{
    public enum InputProcedure
    {
        None = 0,
        Mouse = 1,
        Keyboard = 2,
        Both = 3,
    }

    public class ModelProcedure
    {
        public Mouse Mouse { get; set; }
        public Keyboard Keyboard { get; set; }
        public InputProcedure Input { get; set; }
        public int Wait { get; set; }

        public ModelProcedure()
        {
            Mouse = new Mouse();
            Keyboard = new Keyboard();
            Input = InputProcedure.None;
            Wait = 0;
        }
    }
}
