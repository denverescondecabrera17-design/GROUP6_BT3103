using System;
using System.Data;
using CODEINN.Model;
using CODEINN.Model.CODEINN.Model;
using System.Data.SqlClient;

namespace CODEINN.Repository
{
    public class PaymentsRepository
    {
        private readonly string connectionString =
            "Data Source=LAPTOP-JCHBPFPV\\SQLEXPRESS01;Initial Catalog=HOTELFinalldb;Integrated Security=True;TrustServerCertificate=True";

        // ✔ ADD PAYMENT
        public int AddPayment(PaymentModel payment)
        {
            if (payment == null) throw new ArgumentNullException(nameof(payment));

            try
            {
                using var conn = new System.Data.SqlClient.SqlConnection(connectionString);
                conn.Open();

                // Start a transaction to ensure atomicity
                using var transaction = conn.BeginTransaction();
                try
                {
                    // Insert payment record
                    string paymentQuery = @"
                INSERT INTO Payments
                    (ReservationID, AmountReceived, [Change], Price, PaymentDate, [Status])
                OUTPUT INSERTED.PaymentID
                VALUES
                    (@ReservationID, @AmountReceived, @Change, @Price, @PaymentDate, @Status);";

                    using var cmd = new System.Data.SqlClient.SqlCommand(paymentQuery, conn, transaction);
                    cmd.Parameters.AddWithValue("@ReservationID", payment.ReservationID);
                    cmd.Parameters.AddWithValue("@AmountReceived", payment.AmountReceived);
                    cmd.Parameters.AddWithValue("@Change", payment.Change);
                    cmd.Parameters.AddWithValue("@Price", payment.Price);
                    cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate == default ? DateTime.Now : payment.PaymentDate);
                    cmd.Parameters.AddWithValue("@Status", payment.Status ?? "Partial");

                    var paymentId = cmd.ExecuteScalar();

                    // Get the updated balance
                    decimal balance = GetBalanceForReservation(payment.ReservationID);

                    // Update the reservation's balance
                    string updateBalanceQuery = @"
                UPDATE Reservations
                SET Balance = @Balance
                WHERE ReservationID = @ReservationID";

                    using var balanceCmd = new System.Data.SqlClient.SqlCommand(updateBalanceQuery, conn, transaction);
                    balanceCmd.Parameters.AddWithValue("@Balance", balance);
                    balanceCmd.Parameters.AddWithValue("@ReservationID", payment.ReservationID);
                    balanceCmd.ExecuteNonQuery();

                    // If the balance reaches 0, update the reservation status to "Paid"
                    if (balance <= 0)
                    {
                        UpdatePaymentStatus(payment.ReservationID, "Paid");
                    }

                    transaction.Commit();
                    return paymentId != null ? Convert.ToInt32(paymentId) : 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void UpdatePaymentStatus(int reservationId, string status)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                    UPDATE Reservations
                    SET Status = @Status
                    WHERE ReservationID = @ReservationID";

                        using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Status", status);
                            cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                            cmd.ExecuteNonQuery();
                        }

                        // Commit the transaction if everything is successful
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction in case of an error
                        transaction.Rollback();
                        throw new Exception("Error updating payment status", ex);
                    }
                }
            }
        }



        // Modified GetReservedPayments Method to retrieve reservation data
        // Fetch reservation data directly
        public DataTable GetReservedPayments()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Select data from the Reservations table, including room type, balance, and payment info
                string query = @"
            SELECT 
                r.ReservationID,
                g.LastName,
                g.FirstName,
                g.MiddleInitial,
                rm.RoomType,
                rm.RoomNumber,
                r.CheckInDate,
                r.CheckOutDate,
                r.NumberOfNights,
                r.Status,
                r.Balance,
                ISNULL(SUM(p.AmountReceived), 0) AS TotalPaid,
                (rm.Price * r.NumberOfNights) - ISNULL(SUM(p.AmountReceived), 0) AS RemainingBalance
            FROM Reservations r
            INNER JOIN Guests g ON r.GuestID = g.GuestID
            INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
            LEFT JOIN Payments p ON r.ReservationID = p.ReservationID
            WHERE r.Status IN ('Reserved', 'Booked', 'Occupied')
            GROUP BY 
                r.ReservationID, r.GuestID, g.LastName, g.FirstName, g.MiddleInitial, rm.RoomType, rm.RoomNumber,
                r.CheckInDate, r.CheckOutDate, r.NumberOfNights, r.Status, r.Balance, rm.Price
            ORDER BY r.CheckInDate;";

                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }



        // Updated SearchReservedPayments Method
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
                r.NumberOfNights,
                CONVERT(VARCHAR(10), r.CheckInDate, 23) AS CheckInDate,
                CONVERT(VARCHAR(10), r.CheckOutDate, 23) AS CheckOutDate,
                r.Status,
                ISNULL(SUM(p.AmountReceived), 0) AS TotalPaid,  -- Total paid amount
                (rm.Price * r.NumberOfNights) - ISNULL(SUM(p.AmountReceived), 0) AS Balance  -- Calculating balance
            FROM Reservations r
            INNER JOIN Guests g ON r.GuestID = g.GuestID
            INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
            LEFT JOIN Payments p ON r.ReservationID = p.ReservationID  -- Left join to consider all payments made
            WHERE 
                r.Status IN ('Reserved', 'Booked', 'Occupied')
                AND (
                    g.LastName LIKE @keyword OR
                    g.FirstName LIKE @keyword OR
                    g.MiddleInitial LIKE @keyword OR
                    rm.RoomType LIKE @keyword
                )
            GROUP BY 
                r.ReservationID, g.LastName, g.FirstName, g.MiddleInitial, rm.RoomType, rm.Price, 
                r.NumberOfNights, r.CheckInDate, r.CheckOutDate, r.Status
            ORDER BY r.CheckInDate;";

                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
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


        // ✔ UPDATE ROOM STATUS
        // In the PaymentsRepository class
        public void UpdateRoomAvailability(string roomNumber, string availability, System.Data.SqlClient.SqlTransaction transaction)
        {
            // Ensure transaction is passed correctly and open
            if (transaction.Connection == null)
            {
                throw new InvalidOperationException("Transaction does not have an open connection.");
            }

            // Update query for the room availability
            string query = "UPDATE Rooms SET IsAvailable = @IsAvailable WHERE RoomNumber = @RoomNumber";

            using (var cmd = new System.Data.SqlClient.SqlCommand(query, transaction.Connection, transaction))
            {
                // Use parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);  // roomNumber is a string
                cmd.Parameters.AddWithValue("@IsAvailable", availability == "Available" ? 1 : 0);  // Convert "Available" to 1, else 0

                cmd.ExecuteNonQuery();
            }
        }



        // Add this method inside PaymentsRepository
        public decimal GetBalanceForReservation(int reservationId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                (rm.Price * r.NumberOfNights) - ISNULL(SUM(p.AmountReceived), 0) AS Balance
            FROM Reservations r
            INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
            LEFT JOIN Payments p ON r.ReservationID = p.ReservationID
            WHERE r.ReservationID = @ReservationID
            GROUP BY rm.Price, r.NumberOfNights";

                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        // ✔ ADD TO HISTORY
        public void AddToHistory(History history, System.Data.SqlClient.SqlTransaction transaction)
        {
            if (history == null) throw new ArgumentNullException(nameof(history));

            try
            {
                string historyQuery = @"
        INSERT INTO History
            (PaymentID, LastName, FirstName, MiddleInitial, RoomType, Status, NumberOfNights, CheckInDate, 
             CheckOutDate, Balance, AmountReceived, Change, RoomNumber, CheckOutDateTime)
        VALUES
            (@PaymentID, @LastName, @FirstName, @MiddleInitial, @RoomType, @Status, @NumberOfNights, @CheckInDate,
             @CheckOutDate, @Balance, @AmountReceived, @Change, @RoomNumber, @CheckOutDateTime)";

                using (var cmd = new System.Data.SqlClient.SqlCommand(historyQuery, transaction.Connection, transaction))
                {
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
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding to history", ex);
            }
        }


        // ✔ DELETE RESERVATION
        public void DeleteReservation(int reservationId, System.Data.SqlClient.SqlTransaction transaction)
        {
            using (var cmd = new System.Data.SqlClient.SqlCommand("DELETE FROM Reservations WHERE ReservationID = @ReservationID", transaction.Connection, transaction))
            {
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                cmd.ExecuteNonQuery();
            }
        }

        // ✔ GET RESERVATION BY ID
        public Reservation GetReservationById(int reservationId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                r.ReservationID,
                r.GuestID,
                g.LastName,
                g.FirstName,
                g.MiddleInitial,
                rm.RoomType,
                rm.RoomNumber,
                r.CheckInDate,
                r.CheckOutDate,
                r.NumberOfNights,
                r.Status,
                r.Balance
            FROM Reservations r
            INNER JOIN Guests g ON r.GuestID = g.GuestID
            INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
            WHERE r.ReservationID = @ReservationID";

                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Reservation
                            {
                                ReservationID = reader.GetInt32(0),
                                GuestID = reader.GetInt32(1),
                                LastName = reader.GetString(2),
                                FirstName = reader.GetString(3),
                                MiddleInitial = reader.GetString(4),
                                RoomType = reader.GetString(5),

                                // Check if RoomNumber is nullable and handle accordingly
                                RoomNumber = reader.IsDBNull(6) ? null : reader.GetString(6), // Assuming RoomNumber is a string or nullable

                                CheckInDate = reader.GetDateTime(7),
                                CheckOutDate = reader.GetDateTime(8),
                                NumberOfNights = reader.GetInt32(9),
                                Status = reader.GetString(10),
                                Balance = reader.GetDecimal(11)
                            };
                        }
                    }
                }

                return null; // If reservation not found
            }
        }

        
    

    }
}
