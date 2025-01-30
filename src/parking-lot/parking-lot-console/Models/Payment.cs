using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking_lot_console.Models
{
    public class Payment : BaseModel
    {
        public string TransactionId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public PaymentMode PaymentMode { get; set; }
        public DateTime TimeOfPayment { get; set; }

    }
}
