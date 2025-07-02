
namespace Gubola_Adam_D0JE27_ZH1
{
    [Serializable]
    public class LateReturnException : Exception
    {
        public LateReturnException()
        {
        }

        public LateReturnException(string? message) : base(message)
        {
        }

        public LateReturnException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}