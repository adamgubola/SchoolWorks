using System;
using System.Runtime.Serialization;

namespace Zh_First
{
    
    public class DeliveryException : Exception
    {
        public DeliveryException()
        {
        }

        public DeliveryException(string message) : base(message)
        {
        }

        public DeliveryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeliveryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}