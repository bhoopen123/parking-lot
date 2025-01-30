namespace parking_lot_console.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? CreatedAtUtc { get; set; }
        public DateTime? ModifiedAtUtc { get; set; }
    }
}
