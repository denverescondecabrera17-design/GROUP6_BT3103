using System;

namespace CODEINN.Model
{
    public class PaymentModel
    {
        public int PaymentID { get; set; }
        public int ReservationID { get; set; }
        public decimal AmountReceived { get; set; }
        public decimal Change { get; set; }
        public decimal Price { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }

        public decimal Balance { get; set; }  // ADD THIS

        public String RoomNumber { get; set; }
    }
}
