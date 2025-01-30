namespace parking_lot_console.Models
{
    public class Gate : BaseModel
    {
        public required string Number { get; set; }
        public GateType GateType { get; set; }
        public required Operator CurrentOperator { get; set; }
    }
}
