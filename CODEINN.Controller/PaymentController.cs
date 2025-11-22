using System.Data;
using CODEINN.Model;
using CODEINN.Repository;

namespace CODEINN.Controller
{
    public class PaymentsController
    {
        private readonly PaymentsRepository repository;

        public PaymentsController()
        {
            repository = new PaymentsRepository();
        }

        public void AddPayment(PaymentModel payment)
        {
            repository.AddPayment(payment);
        }

        public void UpdatePaymentStatus(int reservationId, string status)
        {
            repository.UpdatePaymentStatus(reservationId, status);
        }

        public DataTable GetReservedPayments()
        {
            return repository.GetReservedPayments();
        }
        public DataTable SearchReservedPayments(string keyword)
        {
            return repository.SearchReservedPayments(keyword);
        }
        public void UpdateRoomAvailability(int reservationId, string availability)
        {
            var repo = new PaymentsRepository();
            repo.UpdateRoomAvailability(reservationId, availability);
        }

    }
}
