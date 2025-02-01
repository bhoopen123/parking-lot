using parking_lot_console.Models.Enums;

namespace parking_lot_console.Models
{
    public class Vehicle : BaseModel
    {
        public required string Number { get; set; }
        public VehicleType Type { get; set; }
        public string? OwnerName { get; set; }
    }
}
