using CODEINN.Model;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CODEINN.Repository
{
    public class HistoryRepository
    {
        private readonly string _connectionString =
            "Data Source=LAPTOP-JCHBPFPV\\SQLEXPRESS01;Initial Catalog=HOTELFinalldb;Integrated Security=True;TrustServerCertificate=True";

        // Method to add to the History table with a transaction
        public void AddToHistory(History history, SqlTransaction transaction)
        {
            try
            {
                string query = @"
                INSERT INTO History 
                (PaymentID, LastName, FirstName, MiddleInitial, RoomType, Status, NumberOfNights, 
                 CheckInDate, CheckOutDate, Balance, AmountReceived, Change, RoomNumber, CheckOutDateTime)
                VALUES 
                (@PaymentID, @LastName, @FirstName, @MiddleInitial, @RoomType, @Status, @NumberOfNights, 
                 @CheckInDate, @CheckOutDate, @Balance, @AmountReceived, @Change, @RoomNumber, @CheckOutDateTime)";

                using var cmd = new SqlCommand(query, transaction.Connection, transaction);
                cmd.Parameters.AddWithValue("@PaymentID", history.PaymentID);
                cmd.Parameters.AddWithValue("@LastName", history.LastName);
                cmd.Parameters.AddWithValue("@FirstName", history.FirstName);
                cmd.Parameters.AddWithValue("@MiddleInitial", history.MiddleInitial);
                cmd.Parameters.AddWithValue("@RoomType", history.RoomType);
                cmd.Parameters.AddWithValue("@Status", history.Status);
                cmd.Parameters.AddWithValue("@NumberOfNights", history.NumberOfNights);
                cmd.Parameters.AddWithValue("@CheckInDate", history.CheckInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", history.CheckOutDate);
                cmd.Parameters.AddWithValue("@Balance", history.Balance);
                cmd.Parameters.AddWithValue("@AmountReceived", history.AmountReceived);
                cmd.Parameters.AddWithValue("@Change", history.Change);
                cmd.Parameters.AddWithValue("@RoomNumber", history.RoomNumber);
                cmd.Parameters.AddWithValue("@CheckOutDateTime", history.CheckOutDateTime);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error transferring data to History: " + ex.Message);
            }
        }

    }

}
