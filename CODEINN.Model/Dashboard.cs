using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEINN.Model
{
    public class RoomsGuest
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; } 
        public string RoomType { get; set; }  
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    
    public class GuestModel
    {
        public int GuestId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        public ICollection<Booking> Bookings { get; set; }
    }


    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int RoomId { get; set; }
        public RoomsGuest Room { get; set; } 
        public int GuestId { get; set; }
        public GuestModel Guest { get; set; } 
        public bool IsCheckedIn { get; set; } = false;
    }


    public class Payments
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; } 
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } 
    }
}
