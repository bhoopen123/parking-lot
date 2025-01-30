namespace parking_lot_console.Models
{
    public class ParkingLot : BaseModel
    {
        public string Address { get; set; }
        public List<ParkingSlot> ParkingSlots { get; set; }
        public List<Gate> Gates { get; set; }
    }
}
