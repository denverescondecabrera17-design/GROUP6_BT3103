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

        // ADD ----------------------------------------------------------
        public int AddGuest(Guests guest)
        {
            if (guest == null) throw new ArgumentNullException(nameof(guest));

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
            INSERT INTO Guests
            (LastName, FirstName, MiddleInitial, Suffix, ContactNumber, Email, BirthDate, Age, Gender, Address, IDType)
            OUTPUT INSERTED.GuestID
            VALUES 
            (@LastName, @FirstName, @MiddleInitial, @Suffix, @ContactNumber, @Email, @BirthDate, @Age, @Gender, @Address, @IDType)";

            using var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LastName", guest.LastName);
            cmd.Parameters.AddWithValue("@FirstName", guest.FirstName);
            cmd.Parameters.AddWithValue("@MiddleInitial", (object)guest.MiddleInitial ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Suffix", (object)guest.Suffix ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ContactNumber", (object)guest.ContactNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)guest.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@BirthDate", (object)guest.BirthDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Age", (object)guest.Age ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Gender", (object)guest.Gender ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", (object)guest.Address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@IDType", (object)guest.IDType ?? DBNull.Value);

            return (int)cmd.ExecuteScalar();
        }

        // EDIT ----------------------------------------------------------
        public void EditGuest(Guests guest)
        {
            if (guest == null) throw new ArgumentNullException(nameof(guest));

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
            UPDATE Guests
            SET LastName=@LastName, FirstName=@FirstName, MiddleInitial=@MiddleInitial,
                Suffix=@Suffix, ContactNumber=@ContactNumber, Email=@Email,
                BirthDate=@BirthDate, Age=@Age, Gender=@Gender, Address=@Address,
                IDType=@IDType
            WHERE GuestID=@GuestID";

            using var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@GuestID", guest.GuestID);
            cmd.Parameters.AddWithValue("@LastName", guest.LastName);
            cmd.Parameters.AddWithValue("@FirstName", guest.FirstName);
            cmd.Parameters.AddWithValue("@MiddleInitial", (object)guest.MiddleInitial ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Suffix", (object)guest.Suffix ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ContactNumber", (object)guest.ContactNumber ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object)guest.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@BirthDate", (object)guest.BirthDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Age", (object)guest.Age ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Gender", (object)guest.Gender ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", (object)guest.Address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@IDType", (object)guest.IDType ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        // GET BY ID ----------------------------------------------------------
        public Guests GetGuestByID(int guestID)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
            SELECT GuestID, LastName, FirstName, MiddleInitial, Suffix,
                   ContactNumber, Email, BirthDate, Age, Gender, Address, IDType
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
                    Suffix = reader.IsDBNull(4) ? null : reader.GetString(4),
                    ContactNumber = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Email = reader.IsDBNull(6) ? null : reader.GetString(6),
                    BirthDate = reader.IsDBNull(7) ? null : reader.GetDateTime(7),
                    Age = reader.IsDBNull(8) ? null : reader.GetInt32(8),
                    Gender = reader.IsDBNull(9) ? null : reader.GetString(9),
                    Address = reader.IsDBNull(10) ? null : reader.GetString(10),
                    IDType = reader.IsDBNull(11) ? null : reader.GetString(11)
                };
            }
            return null;
        }

        // GET ALL ----------------------------------------------------------
        public List<Guests> GetAllGuests()
        {
            var list = new List<Guests>();
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
            SELECT GuestID, LastName, FirstName, MiddleInitial, Suffix,
                   ContactNumber, Email, BirthDate, Age, Gender, Address, IDType 
            FROM Guests";

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
                    Suffix = reader.IsDBNull(4) ? null : reader.GetString(4),
                    ContactNumber = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Email = reader.IsDBNull(6) ? null : reader.GetString(6),
                    BirthDate = reader.IsDBNull(7) ? null : reader.GetDateTime(7),
                    Age = reader.IsDBNull(8) ? null : reader.GetInt32(8),
                    Gender = reader.IsDBNull(9) ? null : reader.GetString(9),
                    Address = reader.IsDBNull(10) ? null : reader.GetString(10),
                    IDType = reader.IsDBNull(11) ? null : reader.GetString(11)
                });
            }

            return list;
        }

        // DELETE ----------------------------------------------------------
        public void DeleteGuest(int guestId)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "DELETE FROM Guest WHERE GuestID = @GuestID";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GuestID", guestId);

            cmd.ExecuteNonQuery();
        }

        // SEARCH ----------------------------------------------------------
        public List<Guests> SearchGuests(string keyword)
        {
            var list = new List<Guests>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"
            SELECT GuestID, LastName, FirstName, MiddleInitial, Suffix,
                   ContactNumber, Email, BirthDate, Age, Gender, Address, IDType
            FROM Guests
            WHERE 
                LastName LIKE @keyword OR
                FirstName LIKE @keyword OR
                MiddleInitial LIKE @keyword OR
                ContactNumber LIKE @keyword OR
                Email LIKE @keyword OR
                Address LIKE @keyword OR
                Gender LIKE @keyword OR
                IDType LIKE @keyword
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
                    Suffix = reader.IsDBNull(4) ? null : reader.GetString(4),
                    ContactNumber = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Email = reader.IsDBNull(6) ? null : reader.GetString(6),
                    BirthDate = reader.IsDBNull(7) ? null : reader.GetDateTime(7),
                    Age = reader.IsDBNull(8) ? null : reader.GetInt32(8),
                    Gender = reader.IsDBNull(9) ? null : reader.GetString(9),
                    Address = reader.IsDBNull(10) ? null : reader.GetString(10),
                    IDType = reader.IsDBNull(11) ? null : reader.GetString(11)
                });
            }

            return list;
        }
    }
}
