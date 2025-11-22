using CODEINN.Model;
using CODEINN.Model.CODEINN.Model;
using CODEINN.Repository;

public class ReservationController
{
    private readonly ReservationRepository repository;

    public ReservationController()
    {
        repository = new ReservationRepository();
    }

    public int AddReservation(Reservation reservation)
    {
        return repository.AddReservation(reservation);
    }

    public bool UpdateReservation(Reservation reservation)
    {
        return repository.UpdateReservation(reservation);
    }

    public List<Reservation> GetAllReservations()
    {
        return repository.GetAllReservations();
    }

    public List<Rooms> GetAvailableRoomsByType(string roomType)
    {
        return repository.GetAvailableRoomsByType(roomType);
    }

    public Reservation GetActiveReservationByGuest(int guestId)
    {
        return repository.GetActiveReservationByGuest(guestId);
    }

    public bool DeleteReservation(int reservationId)
    {
        return repository.DeleteReservation(reservationId);
    }


    public bool UpdateRoomAvailability(int roomId, bool isAvailable)
    {
        return repository.UpdateRoomAvailability(roomId, isAvailable);
    }

    public List<ReservationDetails> GetReservationDetails()
    {
        return repository.GetReservationDetails();
    }

   
    public Rooms GetRoomById(int roomId)
    {
        return repository.GetRoomById(roomId);
    }
    public List<ReservationDetails> SearchReservations(string keyword)
    {
        var repo = new ReservationRepository();
        return repo.SearchReservations(keyword);
    }
    public List<Guests> SearchGuests(string keyword)
    {
        var repo = new GuestRepository();
        return repo.SearchGuests(keyword);
    }


}
