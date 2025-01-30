using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking_lot_console.Models
{
    public class Vehicle : BaseModel
    {
        public required string Number { get; set; }
        public VehicleType Type { get; set; }
        public string? OwnerName { get; set; }
    }
}
