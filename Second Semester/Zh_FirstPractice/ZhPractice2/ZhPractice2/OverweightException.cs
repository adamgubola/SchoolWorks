
namespace ZhPractice2
{
    [Serializable]
    public class OverweightException : Exception
    {
        public OverweightException()
        {
        }

        public OverweightException(string? message) : base(message)
        {
        }

        public OverweightException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}