using KlusterG.AutoGui.InternalKeys;

namespace KlusterG.AutoGui.Control
{
    internal class KeyboardControl
    {
        private List<KKeys> Keys = new List<KKeys>();

        public void AddKeyPress(KKeys key)
        {
            Keys.Add(key);
        }

        public void RemoveKeyPress(KKeys key)
        {
            Keys.Remove(key);
        }

        public void ClearKeys()
        {
            foreach (KKeys key in Keys)
            {
                External.KeyboardEvent((byte)key, 0, 2, UIntPtr.Zero);
            }

            Keys.Clear();
        }
    }
}
