using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEINN.Model
{
    public class History
    {
        public int PaymentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string RoomType { get; set; }
        public string Status { get; set; }
        public int NumberOfNights { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal? Balance { get; set; }  // Nullable decimal
        public decimal? AmountReceived { get; set; }  // Nullable decimal
        public decimal? Change { get; set; }  // Nullable decimal
        public string RoomNumber { get; set; }
        public DateTime CheckOutDateTime { get; set; }
    }

}
