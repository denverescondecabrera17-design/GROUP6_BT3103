using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CODEINN.Model;
using CODEINN.Model.CODEINN.Model;

namespace CODEINN.Repository
{
    public class ReservationRepository
    {
        private readonly string connectionString =
            "Data Source=LAPTOP-JCHBPFPV\\SQLEXPRESS01;Initial Catalog=HOTELFinalldb;Integrated Security=True;TrustServerCertificate=True";

      
        public int AddReservation(Reservation reservation)
        {
            if (reservation == null) throw new ArgumentNullException(nameof(reservation));

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                INSERT INTO Reservations 
                (GuestID, RoomID, CheckInDate, CheckOutDate, CheckInTime, NumberOfNights, Status)
                OUTPUT INSERTED.ReservationID
                VALUES (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @CheckInTime, @NumberOfNights, @Status)";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GuestID", reservation.GuestID);
            cmd.Parameters.AddWithValue("@RoomID", reservation.RoomID);
            cmd.Parameters.AddWithValue("@CheckInDate", reservation.CheckInDate);
            cmd.Parameters.AddWithValue("@CheckOutDate", reservation.CheckOutDate);
            cmd.Parameters.AddWithValue("@CheckInTime", reservation.CheckInTime ?? "");
            cmd.Parameters.AddWithValue("@NumberOfNights", reservation.NumberOfNights);
            cmd.Parameters.AddWithValue("@Status", reservation.Status ?? "Reserved");

            return (int)cmd.ExecuteScalar();
        }

    
        public bool UpdateReservation(Reservation reservation)
        {
            if (reservation == null) return false;

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                UPDATE Reservations
                SET RoomID=@RoomID, 
                    CheckInDate=@CheckInDate, 
                    CheckOutDate=@CheckOutDate,
                    CheckInTime=@CheckInTime,
                    NumberOfNights=@NumberOfNights, 
                    Status=@Status
                WHERE ReservationID=@ReservationID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ReservationID", reservation.ReservationID);
            cmd.Parameters.AddWithValue("@RoomID", reservation.RoomID);
            cmd.Parameters.AddWithValue("@CheckInDate", reservation.CheckInDate);
            cmd.Parameters.AddWithValue("@CheckOutDate", reservation.CheckOutDate);
            cmd.Parameters.AddWithValue("@CheckInTime", reservation.CheckInTime ?? "");
            cmd.Parameters.AddWithValue("@NumberOfNights", reservation.NumberOfNights);
            cmd.Parameters.AddWithValue("@Status", reservation.Status ?? "Reserved");

            return cmd.ExecuteNonQuery() > 0;
        }


        public List<Reservation> GetAllReservations()
        {
            var list = new List<Reservation>();
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT ReservationID, GuestID, RoomID, CheckInDate, CheckOutDate, CheckInTime, NumberOfNights, Status FROM Reservations";
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
                    CheckInTime = reader.IsDBNull(reader.GetOrdinal("CheckInTime")) ? "" : reader.GetString(reader.GetOrdinal("CheckInTime")),
                    NumberOfNights = reader.GetInt32(reader.GetOrdinal("NumberOfNights")),
                    Status = reader.GetString(reader.GetOrdinal("Status"))
                });
            }
            return list;
        }

 
        public List<Rooms> GetAvailableRoomsByType(string roomType)
        {
            var list = new List<Rooms>();
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT RoomID, RoomType, RoomNumber, IsAvailable FROM Rooms WHERE RoomType=@Type AND IsAvailable=1";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Type", roomType);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Rooms
                {
                    RoomID = reader.GetInt32(0),
                    RoomType = reader.GetString(1),
                    RoomNumber = reader.GetString(2),
                    IsAvailable = reader.GetBoolean(3)
                });
            }
            return list;
        }

      
        public List<ReservationDetails> GetReservationDetails()
        {
            var list = new List<ReservationDetails>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
        SELECT 
            r.ReservationID,
            r.RoomID,              -- ✅ Include RoomID here
            g.GuestID,
            g.LastName,
            g.FirstName,
            g.MiddleInitial,
            rm.RoomType,
            rm.RoomNumber,
            r.CheckInDate,
            r.CheckInTime,
            r.CheckOutDate,
            r.NumberOfNights,
            r.Status
        FROM Reservations r
        INNER JOIN Guests g ON r.GuestID = g.GuestID
        INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
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
                    CheckInTime = reader.IsDBNull(reader.GetOrdinal("CheckInTime")) ? "" : reader.GetString(reader.GetOrdinal("CheckInTime")),
                    CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                    NumberOfNights = reader.GetInt32(reader.GetOrdinal("NumberOfNights")),
                    Status = reader.GetString(reader.GetOrdinal("Status"))
                });
            }

            return list;
        }


      
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

        // Get active reservation by guest
        public Reservation GetActiveReservationByGuest(int guestId)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                SELECT TOP 1 ReservationID, GuestID, RoomID, CheckInDate, CheckOutDate, CheckInTime, NumberOfNights, Status
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
                    CheckInTime = reader.IsDBNull(reader.GetOrdinal("CheckInTime")) ? "" : reader.GetString(reader.GetOrdinal("CheckInTime")),
                    NumberOfNights = reader.GetInt32(reader.GetOrdinal("NumberOfNights")),
                    Status = reader.GetString(reader.GetOrdinal("Status"))
                };
            }

            return null;
        }

     
        public bool DeleteReservation(int reservationId)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

      
            string getRoomQuery = "SELECT RoomID FROM Reservations WHERE ReservationID = @ReservationID";
            int roomId = 0;

            using (var getCmd = new SqlCommand(getRoomQuery, conn))
            {
                getCmd.Parameters.AddWithValue("@ReservationID", reservationId);
                var result = getCmd.ExecuteScalar();
                if (result != null)
                    roomId = Convert.ToInt32(result);
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

       
        public Rooms GetRoomById(int roomId)
        {
            Rooms room = null;

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT RoomID, RoomType, RoomNumber, IsAvailable FROM Rooms WHERE RoomID = @RoomID";

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
                    IsAvailable = reader.GetBoolean(reader.GetOrdinal("IsAvailable"))
                };
            }

            return room;
        }
       
        public List<ReservationDetails> SearchReservations(string keyword)
        {
            var list = new List<ReservationDetails>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
        SELECT 
            r.ReservationID,
            g.GuestID,
            g.LastName,
            g.FirstName,
            g.MiddleInitial,
            rm.RoomType,
            rm.RoomNumber,
            r.CheckInDate,
            r.CheckInTime,
            r.CheckOutDate,
            r.NumberOfNights,
            r.Status
        FROM Reservations r
        INNER JOIN Guests g ON r.GuestID = g.GuestID
        INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
        WHERE 
            g.FirstName LIKE @keyword OR
            g.LastName LIKE @keyword OR
            rm.RoomNumber LIKE @keyword OR
            r.Status LIKE @keyword
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
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    MiddleInitial = reader.IsDBNull(reader.GetOrdinal("MiddleInitial")) ? "" : reader.GetString(reader.GetOrdinal("MiddleInitial")),
                    RoomType = reader.GetString(reader.GetOrdinal("RoomType")),
                    RoomNumber = reader.GetString(reader.GetOrdinal("RoomNumber")),
                    CheckInDate = reader.GetDateTime(reader.GetOrdinal("CheckInDate")),
                    CheckInTime = reader.IsDBNull(reader.GetOrdinal("CheckInTime")) ? "" : reader.GetString(reader.GetOrdinal("CheckInTime")),
                    CheckOutDate = reader.GetDateTime(reader.GetOrdinal("CheckOutDate")),
                    NumberOfNights = reader.GetInt32(reader.GetOrdinal("NumberOfNights")),
                    Status = reader.GetString(reader.GetOrdinal("Status"))
                });
            }

            return list;
        }
    }
}
