using parking_lot_console.Models;

namespace parking_lot_console.Repositories
{
    public class TicketsRepository
    {
        private static Dictionary<int, Ticket> tickets = new Dictionary<int, Ticket>();
        private static int autoIncrement = 0;

        public Ticket Save(Ticket ticket)
        {
            autoIncrement++;
            ticket.Id = autoIncrement;

            tickets.Add(autoIncrement, ticket);

            return ticket;
        }
    }
}
