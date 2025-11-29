using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CODEINN.Model;
using CODEINN.Model.CODEINN.Model;
using Microsoft.Extensions.Logging;
using System.Transactions;

namespace CODEINN.Repository
{
    public class ReservationRepository
    {
        private readonly string connectionString =
            "Data Source=LAPTOP-JCHBPFPV\\SQLEXPRESS01;Initial Catalog=HOTELFinalldb;Integrated Security=True;TrustServerCertificate=True";


        // Constants for Statuses
        private const string StatusReserved = "Reserved";
        private const string StatusCheckedIn = "CheckedIn";
        private const string StatusPartial = "Partial";

        // ADD RESERVATION
        public int AddReservation(Reservation reservation)
        {
            if (reservation == null) throw new ArgumentNullException(nameof(reservation));

            decimal roomPrice = GetRoomPrice(reservation.RoomID);
            decimal totalAmount = roomPrice * reservation.NumberOfNights;

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"
                INSERT INTO Reservations 
                (GuestID, RoomID, CheckInDate, CheckOutDate, NumberOfNights, Status, Payment, Balance)
                OUTPUT INSERTED.ReservationID
                VALUES (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @NumberOfNights, @Status, 0, @Balance)";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GuestID", reservation.GuestID);
                cmd.Parameters.AddWithValue("@RoomID", reservation.RoomID);
                cmd.Parameters.AddWithValue("@CheckInDate", reservation.CheckInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", reservation.CheckOutDate);
                cmd.Parameters.AddWithValue("@NumberOfNights", reservation.NumberOfNights);
                cmd.Parameters.AddWithValue("@Status", reservation.Status ?? StatusReserved);
                cmd.Parameters.AddWithValue("@Balance", totalAmount);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // UPDATE RESERVATION
        public bool UpdateReservation(Reservation reservation)
        {
            if (reservation == null) return false;

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"
                    UPDATE Reservations
                    SET RoomID = @RoomID,
                        CheckInDate = @CheckInDate,
                        CheckOutDate = @CheckOutDate,
                        NumberOfNights = @NumberOfNights,
                        Status = @Status
                    WHERE ReservationID = @ReservationID";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ReservationID", reservation.ReservationID);
                cmd.Parameters.AddWithValue("@RoomID", reservation.RoomID);
                cmd.Parameters.AddWithValue("@CheckInDate", reservation.CheckInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", reservation.CheckOutDate);
                cmd.Parameters.AddWithValue("@NumberOfNights", reservation.NumberOfNights);
                cmd.Parameters.AddWithValue("@Status", reservation.Status ?? StatusReserved);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        // GET ALL RESERVATIONS
        public List<Reservation> GetAllReservations()
        {
            var list = new List<Reservation>();
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                SELECT ReservationID, GuestID, RoomID, CheckInDate, CheckOutDate, NumberOfNights, Status
                FROM Reservations";

            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Reservation
                {
                    ReservationID = reader.GetInt32(reader.GetOrdinal("ReservationID")),
                    GuestID = reader.GetInt32(reader.GetOrdinal("GuestID")),
                    RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                    CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                    CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                    NumberOfNights = reader.GetInt32(reader.GetOrdinal("NumberOfNights")),
                    Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "" : reader.GetString(reader.GetOrdinal("Status"))
                });
            }

            return list;
        }

        // GET RESERVATION DETAILS
        public List<ReservationDetails> GetReservationDetails()
        {
            var list = new List<ReservationDetails>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            // Updated query to join with Payments table and calculate total payment for each reservation
            string query = @"
        SELECT 
            r.ReservationID,
            r.RoomID,
            g.GuestID,
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
            ISNULL(SUM(p.AmountReceived), 0) AS Payment  -- Sum the payments (AmountReceived) for the reservation
        FROM Reservations r
        INNER JOIN Guests g ON r.GuestID = g.GuestID
        INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
        LEFT JOIN Payments p ON r.ReservationID = p.ReservationID  -- Left join to include payments for each reservation
        GROUP BY 
            r.ReservationID, r.RoomID, g.GuestID, g.LastName, g.FirstName, g.MiddleInitial, 
            rm.RoomType, rm.RoomNumber, r.CheckInDate, r.CheckOutDate, r.NumberOfNights, r.Status, r.Balance
        ORDER BY r.CheckInDate DESC;";

            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ReservationDetails
                {
                    ReservationID = reader.GetInt32(reader.GetOrdinal("ReservationID")),
                    GuestID = reader.GetInt32(reader.GetOrdinal("GuestID")),
                    RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    MiddleInitial = reader.IsDBNull(reader.GetOrdinal("MiddleInitial")) ? "" : reader.GetString(reader.GetOrdinal("MiddleInitial")),
                    RoomType = reader.GetString(reader.GetOrdinal("RoomType")),
                    RoomNumber = reader.GetString(reader.GetOrdinal("RoomNumber")),
                    CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                    CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                    NumberOfNights = reader.GetInt32(reader.GetOrdinal("NumberOfNights")),
                    Status = reader.GetString(reader.GetOrdinal("Status")),

                    // Check for null Balance
                    Balance = reader.IsDBNull(reader.GetOrdinal("Balance")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Balance")),

                    // Check for null Payment
                    Payment = reader.IsDBNull(reader.GetOrdinal("Payment")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Payment"))
                });
            }

            return list;
        }


        // UPDATE ROOM AVAILABILITY
        public bool UpdateRoomAvailability(int roomId, bool isAvailable)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "UPDATE Rooms SET IsAvailable = @IsAvailable WHERE RoomID = @RoomID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomID", roomId);
            cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);

            return cmd.ExecuteNonQuery() > 0;
        }

        // ACTIVE RESERVATION BY GUEST
        public Reservation GetActiveReservationByGuest(int guestId)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                SELECT TOP 1 ReservationID, GuestID, RoomID, CheckInDate, CheckOutDate, NumberOfNights, Status
                FROM Reservations
                WHERE GuestID = @GuestID AND (Status = 'Reserved' OR Status = 'CheckedIn')
                ORDER BY CheckInDate DESC";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GuestID", guestId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Reservation
                {
                    ReservationID = reader.GetInt32(reader.GetOrdinal("ReservationID")),
                    GuestID = reader.GetInt32(reader.GetOrdinal("GuestID")),
                    RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                    CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                    CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                    NumberOfNights = reader.GetInt32(reader.GetOrdinal("NumberOfNights")),
                    Status = reader.GetString(reader.GetOrdinal("Status"))
                };
            }

            return null;
        }

        // DELETE RESERVATION
        public bool DeleteReservation(int reservationId)
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                string getRoomQuery = "SELECT RoomID FROM Reservations WHERE ReservationID = @ReservationID";
                int roomId = 0;

                using (var getCmd = new SqlCommand(getRoomQuery, conn))
                {
                    getCmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    var result = getCmd.ExecuteScalar();
                    if (result != null) roomId = Convert.ToInt32(result);
                }

                if (roomId == 0) return false;

                string deleteQuery = "DELETE FROM Reservations WHERE ReservationID = @ReservationID";
                using (var deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    deleteCmd.ExecuteNonQuery();
                }

                string updateRoomQuery = "UPDATE Rooms SET IsAvailable = 1 WHERE RoomID = @RoomID";
                using (var roomCmd = new SqlCommand(updateRoomQuery, conn))
                {
                    roomCmd.Parameters.AddWithValue("@RoomID", roomId);
                    roomCmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // GET ROOM BY ID
        public Rooms GetRoomById(int roomId)
        {
            Rooms room = null;

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT RoomID, RoomType, RoomNumber, IsAvailable, Price, Status FROM Rooms WHERE RoomID = @RoomID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomID", roomId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                room = new Rooms
                {
                    RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                    RoomType = reader.GetString(reader.GetOrdinal("RoomType")),
                    RoomNumber = reader.GetString(reader.GetOrdinal("RoomNumber")),
                    IsAvailable = reader.GetBoolean(reader.GetOrdinal("IsAvailable")),
                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                    Status = reader.GetString(reader.GetOrdinal("Status"))
                };
            }

            return room;
        }

        // SEARCH RESERVATIONS
        public List<ReservationDetails> SearchReservations(string keyword)
        {
            var list = new List<ReservationDetails>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            // Updated query to join with the Payments table and fetch the total payment (AmountReceived)
            string query = @"
        SELECT 
            r.ReservationID,
            r.RoomID,
            g.GuestID,
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
            ISNULL(SUM(p.AmountReceived), 0) AS Payment  -- Sum of all payments for this reservation
        FROM Reservations r
        INNER JOIN Guests g ON r.GuestID = g.GuestID
        INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
        LEFT JOIN Payments p ON r.ReservationID = p.ReservationID  -- Join with Payments table
        WHERE 
            g.FirstName LIKE @keyword OR
            g.LastName LIKE @keyword OR
            rm.RoomNumber LIKE @keyword OR
            r.Status LIKE @keyword
        GROUP BY 
            r.ReservationID, r.RoomID, g.GuestID, g.LastName, g.FirstName, g.MiddleInitial, 
            rm.RoomType, rm.RoomNumber, r.CheckInDate, r.CheckOutDate, r.NumberOfNights, r.Status, r.Balance
        ORDER BY r.CheckInDate DESC";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ReservationDetails
                {
                    ReservationID = reader.GetInt32(reader.GetOrdinal("ReservationID")),
                    GuestID = reader.GetInt32(reader.GetOrdinal("GuestID")),
                    RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    MiddleInitial = reader.IsDBNull(reader.GetOrdinal("MiddleInitial")) ? "" : reader.GetString(reader.GetOrdinal("MiddleInitial")),
                    RoomType = reader.GetString(reader.GetOrdinal("RoomType")),
                    RoomNumber = reader.GetString(reader.GetOrdinal("RoomNumber")),
                    CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                    CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                    NumberOfNights = reader.GetInt32(reader.GetOrdinal("NumberOfNights")),
                    Status = reader.GetString(reader.GetOrdinal("Status")),
                    Balance = reader.GetDecimal(reader.GetOrdinal("Balance")),
                    Payment = reader.GetDecimal(reader.GetOrdinal("Payment"))  // Assign the total payment
                });
            }

            return list;
        }


        // GET AVAILABLE ROOMS
        public List<Rooms> GetAvailableRooms()
        {
            var rooms = new List<Rooms>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                SELECT RoomID, RoomType, RoomNumber, IsAvailable
                FROM Rooms
                WHERE IsAvailable = 1
                ORDER BY RoomNumber ASC";

            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rooms.Add(new Rooms
                {
                    RoomID = reader.GetInt32(reader.GetOrdinal("RoomID")),
                    RoomType = reader.GetString(reader.GetOrdinal("RoomType")),
                    RoomNumber = reader.GetString(reader.GetOrdinal("RoomNumber")),
                    IsAvailable = reader.GetBoolean(reader.GetOrdinal("IsAvailable"))
                });
            }

            return rooms;
        }

        // GET AVAILABLE ROOMS BY TYPE
        public List<Rooms> GetAvailableRoomsByType(string roomType)
        {
            var rooms = new List<Rooms>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                SELECT RoomID, RoomType, RoomNumber, Price, Status, IsAvailable
                FROM Rooms
                WHERE RoomType = @RoomType AND IsAvailable = 1";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomType", roomType);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rooms.Add(new Rooms
                {
                    RoomID = reader.GetInt32(0),
                    RoomType = reader.GetString(1),
                    RoomNumber = reader.GetString(2),
                    Price = reader.GetDecimal(3),
                    Status = reader.GetString(4),
                    IsAvailable = reader.GetBoolean(5)
                });
            }

            return rooms;
        }

        // GET ROOM PRICE
        public decimal GetRoomPrice(int roomId)
        {
            string query = "SELECT Price FROM Rooms WHERE RoomID = @RoomID";

            using var con = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@RoomID", roomId);

            con.Open();
            return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        // ADD PAYMENT (partial/full)
        public int AddPayment(PaymentModel payment)
        {
            if (payment == null) throw new ArgumentNullException(nameof(payment));

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                // Start a transaction to ensure atomicity
                using var transaction = conn.BeginTransaction();
                try
                {
                    string paymentQuery = @"
            INSERT INTO Payments    
                (ReservationID, AmountReceived, [Change], Price, PaymentDate, [Status])
            OUTPUT INSERTED.PaymentID
            VALUES
                (@ReservationID, @AmountReceived, @Change, @Price, @PaymentDate, @Status);";

                    using var cmd = new SqlCommand(paymentQuery, conn, transaction);
                    cmd.Parameters.AddWithValue("@ReservationID", payment.ReservationID);
                    cmd.Parameters.AddWithValue("@AmountReceived", payment.AmountReceived);
                    cmd.Parameters.AddWithValue("@Change", payment.Change);
                    cmd.Parameters.AddWithValue("@Price", payment.Price);
                    cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate == default ? DateTime.Now : payment.PaymentDate);
                    cmd.Parameters.AddWithValue("@Status", payment.Status ?? StatusPartial);

                    var paymentId = cmd.ExecuteScalar();

                    // Get the original total reservation amount
                    decimal totalAmount = GetReservationTotalAmount(payment.ReservationID);

                    // Update reservation balance (total - amount received)
                    decimal balance = totalAmount - payment.AmountReceived;

                    string updateBalanceQuery = @"
            UPDATE Reservations
            SET Balance = @Balance
            WHERE ReservationID = @ReservationID";

                    using var balanceCmd = new SqlCommand(updateBalanceQuery, conn, transaction);
                    balanceCmd.Parameters.AddWithValue("@Balance", balance);
                    balanceCmd.Parameters.AddWithValue("@ReservationID", payment.ReservationID);
                    balanceCmd.ExecuteNonQuery();

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

        public decimal GetReservationTotalAmount(int reservationID)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
            SELECT (Price * NumberOfNights) AS TotalAmount
            FROM Reservations r
            INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
            WHERE r.ReservationID = @ReservationID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ReservationID", reservationID);

            var result = cmd.ExecuteScalar();
            return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        }

        // Check-out Method (Transfer to History & Delete from Reservations)

        public bool CheckOutReservation(int reservationID)
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                // Start a transaction to ensure atomicity
                using var transaction = conn.BeginTransaction();

                // Fetch reservation data along with the payment details
                string query = @"
            SELECT r.*, p.AmountReceived, p.Change
            FROM Reservations r
            LEFT JOIN Payments p ON r.ReservationID = p.ReservationID
            WHERE r.ReservationID = @ReservationID";

                using var cmd = new SqlCommand(query, conn, transaction); // Pass the transaction here
                cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Create a History object to transfer data
                    var history = new History
                    {
                        PaymentID = reader.GetInt32(reader.GetOrdinal("ReservationID")), // Assuming ReservationID is the PaymentID
                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        MiddleInitial = reader.IsDBNull(reader.GetOrdinal("MiddleInitial")) ? "" : reader.GetString(reader.GetOrdinal("MiddleInitial")),
                        RoomType = reader.GetString(reader.GetOrdinal("RoomType")),
                        Status = reader.GetString(reader.GetOrdinal("Status")),
                        NumberOfNights = reader.GetInt32(reader.GetOrdinal("NumberOfNights")),
                        CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                        CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                        Balance = reader.GetDecimal(reader.GetOrdinal("Balance")),
                        AmountReceived = reader.IsDBNull(reader.GetOrdinal("AmountReceived")) ? 0 : reader.GetDecimal(reader.GetOrdinal("AmountReceived")),
                        Change = reader.IsDBNull(reader.GetOrdinal("Change")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Change")),
                        RoomNumber = reader.GetString(reader.GetOrdinal("RoomNumber")),
                        CheckOutDateTime = DateTime.Now // Record the current time as check-out time
                    };

                    // Pass the transaction to AddToHistory to ensure it's part of the same transaction
                    var historyRepository = new HistoryRepository();
                    //historyRepository.AddToHistory(history, transaction); // Pass transaction here

                    // Delete reservation from Reservations table
                    string deleteQuery = "DELETE FROM Reservations WHERE ReservationID = @ReservationID";
                    using var deleteCmd = new SqlCommand(deleteQuery, conn, transaction);
                    deleteCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    deleteCmd.ExecuteNonQuery();

                    // Commit the transaction to save both operations
                    transaction.Commit();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                // If something goes wrong, rollback the transaction
                throw new Exception("Error during check-out: " + ex.Message);
            }
        }

    }

}

