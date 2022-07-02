using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KlusterG.AutoGui.Legacy
{
    internal class ExecException : Exception
    {
        public ExecException()
        {
        }

        public ExecException(string message) : base(message)
        {
        }

        public ExecException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ExecException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
