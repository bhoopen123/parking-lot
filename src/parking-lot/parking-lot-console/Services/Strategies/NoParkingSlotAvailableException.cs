using System.Runtime.Serialization;

namespace parking_lot_console.Services.Strategies
{
    [Serializable]
    internal class NoParkingSlotAvailableException : Exception
    {
        public NoParkingSlotAvailableException()
        {
        }

        public NoParkingSlotAvailableException(string? message) : base(message)
        {
        }

        public NoParkingSlotAvailableException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoParkingSlotAvailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}