using System;
using Microsoft.Data.SqlClient;
using CODEINN.Model;

namespace CODEINN.Repository   
{
    public class UserRepository
    {
        private const string connectionString = "Data Source=LAPTOP-JCHBPFPV\\SQLEXPRESS01;Initial Catalog=HOTELFinalldb;Integrated Security=True;TrustServerCertificate=True";


        public User ValidateUser(string username, string password)
        {
            User user = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username, Password FROM Users WHERE Username = @Username AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new User
                    {
                        UserID = (int)reader["UserID"],
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString()
                    };
                }
            }

            return user;
        }
    }
}
