using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CODEINN.Model;

namespace CODEINN.Repository
{
    public class GuestRepository
    {
        private readonly string connectionString =
            "Data Source=LAPTOP-JCHBPFPV\\SQLEXPRESS01;Initial Catalog=HOTELFinalldb;Integrated Security=True;TrustServerCertificate=True";

        public int AddGuest(Guests guest)
        {
            if (guest == null) throw new ArgumentNullException(nameof(guest));

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                INSERT INTO Guests (LastName, FirstName, MiddleInitial, ContactNumber, Email, BirthDate, Age, Gender, Address)
                OUTPUT INSERTED.GuestID
                VALUES (@LastName, @FirstName, @MiddleInitial, @ContactNumber, @Email, @BirthDate, @Age, @Gender, @Address)";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LastName", guest.LastName);
            cmd.Parameters.AddWithValue("@FirstName", guest.FirstName);
            cmd.Parameters.AddWithValue("@MiddleInitial", (object)guest.MiddleInitial ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ContactNumber", (object)guest.ContactNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)guest.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@BirthDate", (object)guest.BirthDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Age", (object)guest.Age ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Gender", (object)guest.Gender ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", (object)guest.Address ?? DBNull.Value);

            return (int)cmd.ExecuteScalar();
        }

        public void EditGuest(Guests guest)
        {
            if (guest == null) throw new ArgumentNullException(nameof(guest));

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                UPDATE Guests
                SET LastName=@LastName, FirstName=@FirstName, MiddleInitial=@MiddleInitial,
                    ContactNumber=@ContactNumber, Email=@Email,
                    BirthDate=@BirthDate, Age=@Age, Gender=@Gender, Address=@Address
                WHERE GuestID=@GuestID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GuestID", guest.GuestID);
            cmd.Parameters.AddWithValue("@LastName", guest.LastName);
            cmd.Parameters.AddWithValue("@FirstName", guest.FirstName);
            cmd.Parameters.AddWithValue("@MiddleInitial", (object)guest.MiddleInitial ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ContactNumber", (object)guest.ContactNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)guest.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@BirthDate", (object)guest.BirthDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Age", (object)guest.Age ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Gender", (object)guest.Gender ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", (object)guest.Address ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        public Guests GetGuestByID(int guestID)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
                SELECT GuestID, LastName, FirstName, MiddleInitial, ContactNumber, Email, BirthDate, Age, Gender, Address 
                FROM Guests 
                WHERE GuestID=@GuestID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GuestID", guestID);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Guests
                {
                    GuestID = reader.GetInt32(0),
                    LastName = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    MiddleInitial = reader.IsDBNull(3) ? null : reader.GetString(3),
                    ContactNumber = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                    BirthDate = reader.IsDBNull(6) ? null : reader.GetDateTime(6),
                    Age = reader.IsDBNull(7) ? null : reader.GetInt32(7),
                    Gender = reader.IsDBNull(8) ? null : reader.GetString(8),
                    Address = reader.IsDBNull(9) ? null : reader.GetString(9)
                };
            }
            return null;
        }

        public List<Guests> GetAllGuests()
        {
            var list = new List<Guests>();
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT GuestID, LastName, FirstName, MiddleInitial, ContactNumber, Email, BirthDate, Age, Gender, Address FROM Guests";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Guests
                {
                    GuestID = reader.GetInt32(0),
                    LastName = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    MiddleInitial = reader.IsDBNull(3) ? null : reader.GetString(3),
                    ContactNumber = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                    BirthDate = reader.IsDBNull(6) ? null : reader.GetDateTime(6),
                    Age = reader.IsDBNull(7) ? null : reader.GetInt32(7),
                    Gender = reader.IsDBNull(8) ? null : reader.GetString(8),
                    Address = reader.IsDBNull(9) ? null : reader.GetString(9)
                });
            }
            return list;
        }

        public void DeleteGuest(int guestId)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "DELETE FROM Guests WHERE GuestID = @GuestID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GuestID", guestId);

            cmd.ExecuteNonQuery();
        }
        public List<Guests> SearchGuests(string keyword)
        {
            var list = new List<Guests>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
        SELECT GuestID, LastName, FirstName, MiddleInitial, ContactNumber, Email, BirthDate, Age, Gender, Address
        FROM Guests
        WHERE 
            LastName LIKE @keyword OR
            FirstName LIKE @keyword OR
            MiddleInitial LIKE @keyword OR
            ContactNumber LIKE @keyword OR
            Email LIKE @keyword OR
            Address LIKE @keyword
        ORDER BY LastName ASC";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Guests
                {
                    GuestID = reader.GetInt32(0),
                    LastName = reader.GetString(1),
                    FirstName = reader.GetString(2),
                    MiddleInitial = reader.IsDBNull(3) ? null : reader.GetString(3),
                    ContactNumber = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                    BirthDate = reader.IsDBNull(6) ? null : reader.GetDateTime(6),
                    Age = reader.IsDBNull(7) ? null : reader.GetInt32(7),
                    Gender = reader.IsDBNull(8) ? null : reader.GetString(8),
                    Address = reader.IsDBNull(9) ? null : reader.GetString(9)
                });
            }

            return list;
        }

    }
}
