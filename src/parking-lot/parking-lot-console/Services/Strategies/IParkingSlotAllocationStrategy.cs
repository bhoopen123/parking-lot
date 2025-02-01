using parking_lot_console.Models;
using parking_lot_console.Models.Enums;

namespace parking_lot_console.Services.Strategies
{
    public interface IParkingSlotAllocationStrategy
    {
        ParkingSlot? AssignParkingSlot(int gateId, VehicleType vehicleType);
    }
}
