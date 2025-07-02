
namespace ZhPractice2
{
    [Serializable]
    public class DeliveryException : Exception
    {
        public DeliveryException()
        {
        }

        public DeliveryException(string? message) : base(message)
        {
        }

        public DeliveryException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}