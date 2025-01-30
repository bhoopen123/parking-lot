namespace parking_lot_console.Models
{
    public class Bill : BaseModel
    {
        public required string InvoiceNumber { get; set; }
        public int Amount { get; set; }
        public required Gate ExitGate { get; set; }
        public DateTime ExitTime { get; set; }
        public required Operator Operator { get; set; }
        public required Ticket Ticket { get; set; }
        public required List<Payment> Payments { get; set; }
    }
}
