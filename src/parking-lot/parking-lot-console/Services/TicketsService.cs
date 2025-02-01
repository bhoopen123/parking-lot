using parking_lot_console.Models;
using parking_lot_console.Models.Enums;
using parking_lot_console.Repositories;
using parking_lot_console.Services.Strategies;

namespace parking_lot_console.Services
{
    public class TicketsService
    {
        private readonly GatesService gatesService;
        private readonly VehiclesService vehiclesService;
        private readonly IParkingSlotAllocationStrategy parkingSlotAllocationStrategy;
        private readonly TicketsRepository ticketsRepository;

        public TicketsService(GatesService gatesService,
                                VehiclesService vehiclesService,
                                IParkingSlotAllocationStrategy parkingSlotAllocationStrategy,
                                TicketsRepository ticketsRepository)
        {
            this.gatesService = gatesService;
            this.vehiclesService = vehiclesService;
            this.parkingSlotAllocationStrategy = parkingSlotAllocationStrategy;
            this.ticketsRepository = ticketsRepository;
        }

        // Service Layer should not recieve Controller layer DTOs,
        // because one service method could be used by different controller methods.

        public Ticket GenerateTicket(int GateId, string vehicleNumber, VehicleType vehicleType)
        {

            var gate = gatesService.GetGate(GateId);
            var vehicle = vehiclesService.GetVehicle(vehicleNumber);
            if (vehicle == null)
            {
                vehicle = vehiclesService.RegisterVehicle(vehicleNumber, vehicleType);
            }
            var assignedParkingSlot = parkingSlotAllocationStrategy.AssignParkingSlot(gate.Id, vehicleType);

            if (assignedParkingSlot == null)
            {
                throw new NoParkingSlotAssignedException("Slots not available.");
            }

            var ticket = new Ticket()
            {
                EntryTime = DateTime.UtcNow,
                EntryGate = gate,
                Vehicle = vehicle,
                Operator = gate.CurrentOperator,
                AssignedParkingSlot = assignedParkingSlot,
                CreatedAtUtc = DateTime.UtcNow,
            };

            ticket = ticketsRepository.Save(ticket);

            return ticket;
        }
    }
}
