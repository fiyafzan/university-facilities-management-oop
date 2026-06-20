using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment.Classes
{
    public class Student
    {
        // Properties (getter/setter)
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CourseId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UniId { get; set; }

        public string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        // Method: Load a student from DB
        public static Student GetStudentById(int id, string connectionString)
        {
            Student student = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT studentId, Name, email, CourseId, username, password, uniId " +
                               "FROM students WHERE studentId = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    student = new Student
                    {
                        StudentId = Convert.ToInt32(reader["studentId"]),
                        Name = reader["Name"].ToString(),
                        Email = reader["email"].ToString(),
                        CourseId = reader["CourseId"] != DBNull.Value ? Convert.ToInt32(reader["CourseId"]) : 0,
                        Username = reader["username"].ToString(),
                        Password = reader["password"].ToString(),
                        UniId = Convert.ToInt32(reader["uniId"])
                    };
                }
            }

            return student;
        }

       
        public bool UpdateStudent(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = @"UPDATE students
                                   SET Name = @name, email = @mail, CourseId = @course,
                                       username = @uname, password = @pwd, uniId = @uni
                                   WHERE studentId = @id";

                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@mail", Email);
                cmd.Parameters.AddWithValue("@course", CourseId);
                cmd.Parameters.AddWithValue("@uname", Username);
                cmd.Parameters.AddWithValue("@pwd", Password);
                cmd.Parameters.AddWithValue("@uni", UniId);
                cmd.Parameters.AddWithValue("@id", StudentId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

}
