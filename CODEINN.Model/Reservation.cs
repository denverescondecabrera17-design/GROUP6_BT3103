using System;

namespace CODEINN.Model
{
    namespace CODEINN.Model
    {
        public class Reservation
        {
            public int ReservationID { get; set; }
            public int GuestID { get; set; }
            public int RoomID { get; set; }
            public DateTime CheckInDate { get; set; }
            public DateTime CheckOutDate { get; set; }
            public int NumberOfNights { get; set; }
            public string Status { get; set; }

            public string? CheckInTime { get; set; } 
        }
    }
}