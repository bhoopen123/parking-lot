namespace parking_lot_console.Models
{
    public class ParkingSlot : BaseModel
    {
        public string Number { get; set; }
        public ParkingSlotStatus ParkingSlotStatus { get; set; }
        public VehicleType SupportedVehicleType { get; set; }
    }
}
