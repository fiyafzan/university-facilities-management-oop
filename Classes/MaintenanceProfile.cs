using System;
using System.Data.SqlClient;

namespace iOOP_Receptionist
{
    public class MaintenanceProfile
    {
        // Properties (getter/setter)
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ARFMS_DB;Integrated Security=True";

        // Method: Load a user profile from DB
        public static MaintenanceProfile GetProfileById(int id, string connectionString)
        {
            MaintenanceProfile profile = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UserId, username, password, role FROM users WHERE UserId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            profile = new MaintenanceProfile
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                                Role = reader["role"].ToString()
                            };
                        }
                    }
                }
            }

            return profile;
        }

        // Method: Update user profile in DB
        public bool UpdateProfile(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = @"UPDATE users 
                                   SET username = @username, password = @password, role = @role 
                                   WHERE UserId = @id";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", UserId);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@role", Role); // Fixed as "maintenance" in form logic
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}