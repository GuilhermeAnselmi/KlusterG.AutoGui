using System.Runtime.Serialization;

namespace KlusterG.AutoGui.Domain
{
    public class KeyboardException : Exception
    {
        public KeyboardException()
        {
        }

        public KeyboardException(string message) : base(message)
        {
        }

        public KeyboardException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public KeyboardException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
