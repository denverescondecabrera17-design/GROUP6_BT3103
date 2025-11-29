using System;
using System.Data;
using CODEINN.Model;
using CODEINN.Model.CODEINN.Model;
using CODEINN.Repository;
using Microsoft.Data.Sql;
using System.Data.SqlClient;

namespace CODEINN.Controller
{
    public class PaymentsController
    {
        private readonly PaymentsRepository repository;

        // Injecting the repository
        public PaymentsController(PaymentsRepository repository)
        {
            this.repository = repository;
        }

        // ✔ ADD PAYMENT
        public int AddPayment(PaymentModel payment)
        {
            return repository.AddPayment(payment);
        }

        // ✔ UPDATE PAYMENT STATUS
        public void UpdatePaymentStatus(int reservationId, string status)
        {
            repository.UpdatePaymentStatus(reservationId, status);
        }

        // ✔ GET RESERVED PAYMENTS
        public DataTable GetReservedPayments()
        {
            return repository.GetReservedPayments();
        }

        // ✔ SEARCH RESERVED PAYMENTS
        public DataTable SearchReservedPayments(string keyword)
        {
            return repository.SearchReservedPayments(keyword);
        }

        // ✔ GET BALANCE FOR RESERVATION
        public decimal GetBalanceForReservation(int reservationId)
        {
            return repository.GetBalanceForReservation(reservationId);
        }

        public void DeleteReservation(int reservationId, SqlTransaction transaction)
        {
            // Call repository method and pass the transaction
            repository.DeleteReservation(reservationId, transaction);
        }

        // Modify other methods that need the transaction as well (like UpdateRoomAvailability)


        // ✔ GET RESERVATION BY ID
        public Reservation GetReservationById(int reservationId)
        {
            return repository.GetReservationById(reservationId);
        }

        // Controller method to update room availability
        // In the PaymentsController class
        public void UpdateRoomAvailability(string roomNumber, string availability, SqlTransaction transaction)
        {
            // Pass the roomNumber and availability string to the repository, including the transaction
            repository.UpdateRoomAvailability(roomNumber, availability, transaction);
        }


    }
}
