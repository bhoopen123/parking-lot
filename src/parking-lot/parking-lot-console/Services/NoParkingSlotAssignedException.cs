using System.Runtime.Serialization;

namespace parking_lot_console.Services
{
    [Serializable]
    internal class NoParkingSlotAssignedException : Exception
    {
        public NoParkingSlotAssignedException()
        {
        }

        public NoParkingSlotAssignedException(string? message) : base(message)
        {
        }

        public NoParkingSlotAssignedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoParkingSlotAssignedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}