using parking_lot_console.Models;
using parking_lot_console.Models.Enums;

namespace parking_lot_console.Services
{
    public class VehiclesService
    {
        public Vehicle? GetVehicle(string vehicleNumber)
        {
            return null;
        }

        public Vehicle RegisterVehicle(string vehicleNumber, VehicleType vehicleType)
        {
            var vehicle = new Vehicle
            {
                Id = 1,
                Number = vehicleNumber,
                Type = vehicleType,
                CreatedAtUtc = DateTime.UtcNow
            };

            return vehicle;
        }
    }
}