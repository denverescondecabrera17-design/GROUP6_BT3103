using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CODEINN.Model;

namespace CODEINN.Repository
{
    public class RoomRepository
    {
        private readonly string connectionString =
            "Data Source=LAPTOP-JCHBPFPV\\SQLEXPRESS01;Initial Catalog=HOTELFinalldb;Integrated Security=True;TrustServerCertificate=True";

   
        public List<Rooms> GetAllRooms()
        {
            var rooms = new List<Rooms>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT RoomID, RoomType, RoomNumber, Price, Status, IsAvailable FROM Rooms";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rooms.Add(new Rooms
                {
                    RoomID = reader.GetInt32(0),
                    RoomType = reader.GetString(1),
                    RoomNumber = reader.GetString(2),
                    Price = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Status = reader.IsDBNull(4) ? "Available" : reader.GetString(4),
                    IsAvailable = !reader.IsDBNull(5) && reader.GetBoolean(5)
                });
            }

            return rooms;
        }

        public int AddRoom(Rooms room)
        {
            if (room == null) throw new ArgumentNullException(nameof(room));

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                INSERT INTO Rooms (RoomType, RoomNumber, Price, Status, IsAvailable)
                OUTPUT INSERTED.RoomID
                VALUES (@RoomType, @RoomNumber, @Price, @Status, @IsAvailable)";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
            cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@Price", room.Price);
            cmd.Parameters.AddWithValue("@Status", room.Status ?? "Available");
            cmd.Parameters.AddWithValue("@IsAvailable", room.IsAvailable);

            return (int)cmd.ExecuteScalar();
        }

  
        public void EditRoom(Rooms room)
        {
            if (room == null) throw new ArgumentNullException(nameof(room));

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                UPDATE Rooms
                SET RoomType = @RoomType,
                    RoomNumber = @RoomNumber,
                    Price = @Price,
                    Status = @Status,
                    IsAvailable = @IsAvailable
                WHERE RoomID = @RoomID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
            cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
            cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@Price", room.Price);
            cmd.Parameters.AddWithValue("@Status", room.Status ?? "Available");
            cmd.Parameters.AddWithValue("@IsAvailable", room.IsAvailable);

            cmd.ExecuteNonQuery();
        }

  
        public void DeleteRoom(int roomId)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomID", roomId);

            cmd.ExecuteNonQuery();
        }

     
        public decimal GetPriceByRoomType(string roomType)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT TOP 1 Price FROM Rooms WHERE RoomType = @RoomType";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomType", roomType);

            var result = cmd.ExecuteScalar();
            return result == null ? 0 : Convert.ToDecimal(result);
        }

    
        public string GetStatusByRoomNumber(string roomNumber)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT Status FROM Rooms WHERE RoomNumber = @RoomNumber";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

            var result = cmd.ExecuteScalar();
            return result?.ToString() ?? "Available";
        }

        public int GetAvailableRoomsCount()
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Rooms WHERE IsAvailable = 1";

            using var cmd = new SqlCommand(query, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public int GetOccupiedRoomsCount()
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Rooms WHERE Status = 'Occupied'";

            using var cmd = new SqlCommand(query, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }


    }
}
