using System.Runtime.Serialization;

namespace KlusterG.AutoGui.Domain
{
    public class MouseException : Exception
    {
        public MouseException()
        {
        }

        public MouseException(string message) : base(message)
        {
        }

        public MouseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public MouseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
