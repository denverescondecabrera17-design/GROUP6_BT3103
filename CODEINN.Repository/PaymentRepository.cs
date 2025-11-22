using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CODEINN.Model;

namespace CODEINN.Repository
{
    public class PaymentsRepository
    {
        private readonly string connectionString =
            "Data Source=LAPTOP-JCHBPFPV\\SQLEXPRESS01;Initial Catalog=HOTELFinalldb;Integrated Security=True;TrustServerCertificate=True";

        public void AddPayment(PaymentModel payment)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    INSERT INTO Payments (ReservationID, AmountReceived, Change, Price, PaymentDate, Status)
                    VALUES (@ReservationID, @AmountReceived, @Change, @Price, GETDATE(), @Status)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", payment.ReservationID);
                    cmd.Parameters.AddWithValue("@AmountReceived", payment.AmountReceived);
                    cmd.Parameters.AddWithValue("@Change", payment.Change);
                    cmd.Parameters.AddWithValue("@Price", payment.Price);
                    cmd.Parameters.AddWithValue("@Status", payment.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePaymentStatus(int reservationId, string status)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    UPDATE Reservations 
                    SET Status = @Status 
                    WHERE ReservationID = @ReservationID";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

  
        public DataTable GetReservedPayments()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        r.ReservationID,
                        g.LastName,
                        g.FirstName,
                        g.MiddleInitial,
                        rm.RoomType,
                        rm.Price,
                        CONVERT(VARCHAR(10), r.CheckInDate, 23) AS CheckInDate,   -- ✅ yyyy-MM-dd
                        CONVERT(VARCHAR(10), r.CheckOutDate, 23) AS CheckOutDate, -- ✅ yyyy-MM-dd
                        r.NumberOfNights,
                        r.Status
                    FROM Reservations r
                    INNER JOIN Guests g ON r.GuestID = g.GuestID
                    INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
                    WHERE r.Status IN ('Reserved', 'Booked', 'Occupied');";

                using (var cmd = new SqlCommand(query, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

   
        public DataTable SearchReservedPayments(string keyword)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        r.ReservationID,
                        g.LastName,
                        g.FirstName,
                        g.MiddleInitial,
                        rm.RoomType,
                        rm.Price,
                        CONVERT(VARCHAR(10), r.CheckInDate, 23) AS CheckInDate,   -- ✅ yyyy-MM-dd
                        CONVERT(VARCHAR(10), r.CheckOutDate, 23) AS CheckOutDate, -- ✅ yyyy-MM-dd
                        r.NumberOfNights,
                        r.Status
                    FROM Reservations r
                    INNER JOIN Guests g ON r.GuestID = g.GuestID
                    INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
                    WHERE 
                        r.Status IN ('Reserved', 'Booked', 'Occupied') AND
                        (
                            g.LastName LIKE @keyword OR
                            g.FirstName LIKE @keyword OR
                            g.MiddleInitial LIKE @keyword OR
                            rm.RoomType LIKE @keyword
                        );";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

    
        public void UpdateRoomAvailability(int reservationId, string availability)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                UPDATE Rooms
                SET Status = @Availability
                WHERE RoomID = (
                    SELECT RoomID FROM Reservations WHERE ReservationID = @ReservationID
                )";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Availability", availability);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
