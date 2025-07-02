
namespace PhoneBook
{
    [Serializable]
    internal class NotOrderedItems : Exception
    {
        public NotOrderedItems()
        {
        }

        public NotOrderedItems(string? message) : base(message)
        {
        }

        public NotOrderedItems(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}