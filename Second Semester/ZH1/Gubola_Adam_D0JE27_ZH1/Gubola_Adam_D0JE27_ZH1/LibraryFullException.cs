
namespace Gubola_Adam_D0JE27_ZH1
{
    [Serializable]
    public class LibraryFullException : Exception
    {
        public LibraryFullException()
        {
        }

        public LibraryFullException(string? message) : base(message)
        {
        }

        public LibraryFullException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}