namespace parking_lot_console.DTOs
{
    public abstract class BaseResponse
    {
        public ResponseStatus Status { get; set; }
        public string? Message { get; set; }
    }
}
