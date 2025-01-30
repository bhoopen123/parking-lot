namespace parking_lot_console.Models
{
    public class Ticket : BaseModel
    {
        public DateTime EntryTime { get; set; }
        public required Vehicle Vehicle { get; set; }
        public required Gate EntryGate { get; set; }
        public required ParkingSlot AssignedParkingSlot { get; set; }
        public required Operator Operator { get; set; }
    }
}
