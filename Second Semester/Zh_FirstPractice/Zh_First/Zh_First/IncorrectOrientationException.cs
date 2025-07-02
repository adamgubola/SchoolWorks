using System;
using System.Runtime.Serialization;

namespace Zh_First
{
    
    public class IncorrectOrientationException : DeliveryException
    {
        FragileParcel FragileParcel { get; }

        

        public IncorrectOrientationException()
        {
        }
        public IncorrectOrientationException(FragileParcel fragileParcel)
        {
            FragileParcel = fragileParcel;
        }

        public IncorrectOrientationException(string message) : base(message)
        {
        }

        public IncorrectOrientationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectOrientationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}