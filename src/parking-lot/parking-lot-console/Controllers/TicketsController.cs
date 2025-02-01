using parking_lot_console.DTOs;
using parking_lot_console.Services;

namespace parking_lot_console.Controllers
{
    public class TicketsController
    {
        private readonly TicketsService ticketsService;

        public TicketsController(TicketsService ticketsService)
        {
            this.ticketsService = ticketsService;
        }

        public GenerateTicketResponse GenerateTicket(GenerateTicketRequest generateTicketRequest)
        {
            var ticketResponse = new GenerateTicketResponse();

            try
            {
                // ticket generation
                var ticket = ticketsService.GenerateTicket(generateTicketRequest.GateId,
                                                            generateTicketRequest.VehicleNumber,
                                                            generateTicketRequest.VehicleType);

                ticketResponse.GeneratedTicketId = ticket.Id;
                ticketResponse.Status = ResponseStatus.Success;
            }
            catch (NoParkingSlotAssignedException ex)
            {
                ticketResponse.Status = ResponseStatus.Failure;
                ticketResponse.Message = ex.Message;
            }
            catch (Exception ex)
            {
                ticketResponse.Status = ResponseStatus.Failure;
                ticketResponse.Message = ex.Message;
            }

            return ticketResponse;
        }
    }
}

// Return, just the necessary and sufficent information from the Controller.
// We should not return the DomainModels objects