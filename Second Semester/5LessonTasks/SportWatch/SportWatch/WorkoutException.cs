using System;
using System.Runtime.Serialization;

namespace SportWatch
{
    public class WorkoutException : Exception
    {
        public WorkoutException()
        {
        }

        public WorkoutException(string message) : base(message)
        {
        }

        public WorkoutException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WorkoutException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}