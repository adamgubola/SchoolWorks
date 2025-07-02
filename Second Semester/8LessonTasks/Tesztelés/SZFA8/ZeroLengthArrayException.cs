
namespace TrainingCosts
{
    [Serializable]
    public class ZeroLengthArrayException : Exception
    {
        public ZeroLengthArrayException()
        {
        }

        public ZeroLengthArrayException(string? message) : base(message)
        {
        }

        public ZeroLengthArrayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}