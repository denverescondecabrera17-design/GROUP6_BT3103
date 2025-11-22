using System.Collections.Generic;
using CODEINN.Model;
using CODEINN.Repository;

namespace CODEINN.Controller
{
    public class GuestInfoController
    {
        private readonly GuestRepository guestRepository;

        public GuestInfoController()
        {
            guestRepository = new GuestRepository();
        }

        public int AddGuest(Guests guest)
        {
            return guestRepository.AddGuest(guest);
        }

        public void EditGuest(Guests guest)
        {
            guestRepository.EditGuest(guest);
        }

        public Guests GetGuestbyID(int guestID)
        {
            return guestRepository.GetGuestByID(guestID);
        }

        public List<Guests> GetAllGuests()
        {
            return guestRepository.GetAllGuests();
        }

        public void DeleteGuest(int guestId)
        {
            guestRepository.DeleteGuest(guestId);
        }
        public List<Guests> SearchGuests(string keyword)
        {
            return guestRepository.SearchGuests(keyword);
        }

    }
}
