using parking_lot_console.Models;
using parking_lot_console.Models.Enums;
using parking_lot_console.Repositories;

namespace parking_lot_console.Services.Strategies
{
    public class FirstParkingSlotAllocationStrategy : IParkingSlotAllocationStrategy
    {
        private readonly ParkingLotRepository parkingLotRepository;
        private readonly ParkingSlotRepository parkingSlotRepository;

        public FirstParkingSlotAllocationStrategy(ParkingLotRepository parkingLotRepository,
                                                    ParkingSlotRepository parkingSlotRepository)
        {
            this.parkingLotRepository = parkingLotRepository;
            this.parkingSlotRepository = parkingSlotRepository;
        }

        public ParkingSlot? AssignParkingSlot(int gateId, VehicleType vehicleType)
        {
            var parkingLot = parkingLotRepository.GetParkingLotByGateId(gateId);
            var allParkingSlots = parkingSlotRepository.GetParkingSlotsByParkingLotId(parkingLot.Id);

            foreach (var parkingSlot in allParkingSlots)
            {
                if (parkingSlot.ParkingSlotStatus == ParkingSlotStatus.Available
                    && parkingSlot.SupportedVehicleType == vehicleType)
                {
                    return parkingSlot;
                }
            }

            return null;
        }
    }
}
