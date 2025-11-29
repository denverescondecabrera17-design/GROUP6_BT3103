using System;

namespace CODEINN.Model
{
    namespace CODEINN.Model
    {
        public class Reservation
        {
            public int ReservationID { get; set; }
            public int GuestID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MiddleInitial { get; set; }
            public string RoomType { get; set; }
            public string RoomNumber { get; set; }
            public DateTime CheckInDate { get; set; }
            public DateTime CheckOutDate { get; set; }
            public int NumberOfNights { get; set; }
            public string Status { get; set; }

            public int RoomID { get; set; }
            public decimal? Payment { get; set; } // Nullable to account for non-paid reservations
            public decimal? Balance { get; set; } // Nullable to reflect unprocessed balance


        }
    }
}