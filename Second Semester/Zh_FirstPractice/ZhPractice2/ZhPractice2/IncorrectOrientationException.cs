
namespace ZhPractice2
{
    [Serializable]
    public class IncorrectOrientationException : DeliveryException
    {
        FragileParcel FragileParcel { get; set; }

        public IncorrectOrientationException(FragileParcel parcel)
        {
            FragileParcel = parcel;
        }

        public IncorrectOrientationException(string? message) : base(message)
        {
        }

        public IncorrectOrientationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}