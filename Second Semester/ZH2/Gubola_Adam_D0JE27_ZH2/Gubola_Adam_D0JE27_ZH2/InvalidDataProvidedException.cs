
namespace Gubola_Adam_D0JE27_ZH2
{
    [Serializable]
    internal class InvalidDataProvidedException : Exception
    {
        public InvalidDataProvidedException()
        {
        }

        public InvalidDataProvidedException(string? message) : base(message)
        {
        }

        public InvalidDataProvidedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}