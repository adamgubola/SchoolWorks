using System;
using System.Runtime.Serialization;

namespace Zh_First
{
    public class OverweightException : Exception
    {
        public OverweightException()
        {
        }

        public OverweightException(string message) : base(message)
        {
        }

        public OverweightException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OverweightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}