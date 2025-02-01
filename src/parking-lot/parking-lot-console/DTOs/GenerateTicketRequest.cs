using parking_lot_console.Models.Enums;

namespace parking_lot_console.DTOs
{
    public class GenerateTicketRequest
    {
        public required string VehicleNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public int GateId { get; set; }
    }
}
