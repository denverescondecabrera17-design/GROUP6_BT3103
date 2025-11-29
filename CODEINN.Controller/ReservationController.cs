using System;
using System.Collections.Generic;
using CODEINN.Model;
using CODEINN.Model.CODEINN.Model;
using CODEINN.Repository;

namespace CODEINN.Controller
{
    public class ReservationController
    {
        private readonly ReservationRepository reservationRepository;
        private readonly RoomRepository roomRepository;

        public ReservationController()
        {
            reservationRepository = new ReservationRepository();
            roomRepository = new RoomRepository();
        }

        // ADD RESERVATION
        public int AddReservation(Reservation reservation)
        {
            if (reservation == null)
                throw new ArgumentNullException(nameof(reservation));

            return reservationRepository.AddReservation(reservation);
        }

        // UPDATE RESERVATION
        public bool UpdateReservation(Reservation reservation)
        {
            if (reservation == null)
                return false;

            return reservationRepository.UpdateReservation(reservation);
        }

        // DELETE RESERVATION
        public bool DeleteReservation(int reservationId)
        {
            if (reservationId <= 0)
                return false;

            return reservationRepository.DeleteReservation(reservationId);
        }

        // GET ALL RESERVATIONS
        public List<Reservation> GetAllReservations()
        {
            return reservationRepository.GetAllReservations();
        }

        // JOIN: Guest + Room + Reservation
        public List<ReservationDetails> GetReservationDetails()
        {
            return reservationRepository.GetReservationDetails();
        }

        // SEARCH
        public List<ReservationDetails> SearchReservations(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<ReservationDetails>();

            return reservationRepository.SearchReservations(keyword);
        }

        // GET ALL AVAILABLE ROOMS
        public List<Rooms> GetAvailableRooms()
        {
            return reservationRepository.GetAvailableRooms();
        }

        // GET AVAILABLE ROOMS BY TYPE → USE ROOM REPOSITORY (correct)
        public List<Rooms> GetAvailableRoomsByType(string roomType)
        {
            return roomRepository.GetAvailableRoomsByType(roomType);
        }

        // GET ROOM BY ID → MUST USE roomRepository (fixed)
        public Rooms GetRoomById(int roomId)
        {
            return roomRepository.GetAllRooms().Find(r => r.RoomID == roomId);
        }

        // CHECK IF GUEST HAS ACTIVE RESERVATION
        public Reservation GetActiveReservationByGuest(int guestId)
        {
            return reservationRepository.GetActiveReservationByGuest(guestId);
        }

        // UPDATE ROOM AVAILABILITY
        public bool UpdateRoomAvailability(int roomId, bool isAvailable)
        {
            return reservationRepository.UpdateRoomAvailability(roomId, isAvailable);
        }

        // GET ROOM PRICE (correct: delegate to RoomRepository)
        public decimal GetRoomPrice(int roomId)
        {
            return roomRepository.GetRoomPrice(roomId);
        }

        // ADD PAYMENT RECORD
        public int AddPayment(PaymentModel payment)
        {
            if (payment == null)
                throw new ArgumentNullException(nameof(payment));

            return reservationRepository.AddPayment(payment);
        }


    }
}
