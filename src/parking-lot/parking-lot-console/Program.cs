// See https://aka.ms/new-console-template for more information
using parking_lot_console.Controllers;
using parking_lot_console.DTOs;
using parking_lot_console.Repositories;
using parking_lot_console.Services;
using parking_lot_console.Services.Strategies;

Console.WriteLine("Welcome to Parking Lot !!");

GatesService gatesService = new();
VehiclesService vehiclesService = new();
ParkingLotRepository parkingLotRepository = new();
ParkingSlotRepository parkingSlotRepository = new();
TicketsRepository ticketsRepository = new();
IParkingSlotAllocationStrategy parkingSlotAllocationStrategy = new FirstParkingSlotAllocationStrategy(parkingLotRepository, parkingSlotRepository);

TicketsController ticketsController = new(new TicketsService(
                                                        gatesService,
                                                        vehiclesService,
                                                        parkingSlotAllocationStrategy,
                                                        ticketsRepository));
var generateTicketRequest = new GenerateTicketRequest()
{
    VehicleNumber = "MH 1234",
    GateId = 111,
    VehicleType = parking_lot_console.Models.Enums.VehicleType.Medium
};

var ticketResponse = ticketsController.GenerateTicket(generateTicketRequest);

if (ticketResponse.Status == ResponseStatus.Success)
{
    Console.WriteLine(ticketResponse.GeneratedTicketId);
}
else
{
    Console.WriteLine("Could not generate ticket, please try again.");

}

// Requirement
// Generate a ticket at entry of a vehicle at a gate


// TicketsController
// Inputs and Outputs of a controller
// Inputs of a controllers
// 1. Can models be the inputs?
// 2. Can we have multiple parameters in Inputs?
//      -> One Parameter with DTO model is advisible, as the code of the
//      consumers won't break if new properties are added in the DTO model.
