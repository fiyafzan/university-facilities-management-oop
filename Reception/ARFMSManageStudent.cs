using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iOOP_Receptionist
{
    public partial class ARFMSManageStudent : Form
    {
        public ARFMSManageStudent()
        {
            InitializeComponent();
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (Searchtxt.Text == "insert ID or Name")
            {
                Searchtxt.Text = "";
            }
        }

        private void ARFMSManageStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadUniversities();
            LoadCourses();
        }

        private void LoadStudents()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT s.studentId, s.username, s.Name, c.CourseId, s.email, 
                       s.uniId, u.UniName
                FROM students s
                LEFT JOIN universities u ON s.uniId = u.UniId
                LEFT JOIN Courses c ON s.CourseId = c.CourseId";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    studentsdgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }


        private void LoadUniversities()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT UniId, UniName FROM universities";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind to ComboBox
                    unibox.DataSource = dt;
                    unibox.DisplayMember = "UniName"; // user sees this
                    unibox.ValueMember = "UniId";      // this is saved to DB
                    unibox.SelectedIndex = -1; // optional: no default
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading universities: " + ex.Message);
                }
            }
        }
        private void LoadCourses()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT CourseId, CourseName from Courses";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    CourseBox.DataSource = dt;
                    CourseBox.DisplayMember = "CourseName";
                    CourseBox.ValueMember = "CourseId";
                    CourseBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading courses:" +ex.Message);
                }
            }
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReceptionForm receptionForm = new ReceptionForm();
            receptionForm.ShowDialog();
            

        }

        private void studentsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = studentsdgv.Rows[e.RowIndex];

                StudentIDtxt.Text = row.Cells["studentId"].Value?.ToString() ?? "";
                usernametxt.Text = row.Cells["username"].Value?.ToString() ?? "";
                Nametxt.Text = row.Cells["Name"].Value?.ToString() ?? "";
                Emailtxt.Text = row.Cells["email"].Value?.ToString() ?? "";

                // select university by ID
                if (row.Cells["uniId"].Value != DBNull.Value)
                {
                    unibox.SelectedValue = row.Cells["uniId"].Value;
                }
                else
                {
                    unibox.SelectedIndex = -1;
                }

                if (row.Cells["CourseId"].Value !=DBNull.Value)
                {
                    CourseBox.SelectedValue = row.Cells["CourseId"].Value;
                }
                else
                {
                    CourseBox.SelectedIndex = -1;
                }
            }
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = Searchtxt.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(
            System.Configuration.ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT studentId, Name, CourseId, email FROM students " +
                                       "WHERE CAST(studentId AS NVARCHAR(10)) = @id OR UPPER(Name) LIKE '%' + @name + '%'";
                        using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(query, con))
                        {
                            da.SelectCommand.Parameters.AddWithValue("@id", searchText);
                            da.SelectCommand.Parameters.AddWithValue("@name", searchText);
                            System.Data.DataTable dt = new System.Data.DataTable();
                            da.Fill(dt);
                            studentsdgv.DataSource = dt;
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No students found matching your search. Searched for: " + searchText +
                                                ". Check if it is spelled correctly or exists.");
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Error searching students: " + ex.Message);
                    }
                }
            }
            else
            {
                LoadStudents(); // Reload all students if search text is empty
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text.Trim();
            string username = usernametxt.Text.Trim();
            object CourseId = CourseBox.SelectedValue;
            string email = Emailtxt.Text.Trim();
            object uniId = unibox.SelectedValue; // gets UniId from universities

            if (string.IsNullOrEmpty(name) || CourseId == null || uniId == null)
            {
                MessageBox.Show("Please fill in Name, Course, and select a University.");
                return;
            }

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                try
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        // Insert into student first, letting studentId auto-increment
                        string studentQuery = "INSERT INTO students (Name, CourseId, email, username, password, uniId) OUTPUT INSERTED.studentId VALUES (@name, @CourseId, @email, @username, @password, @uniId)";
                        int newStudentId;
                        using (SqlCommand cmdStudent = new SqlCommand(studentQuery, con, transaction))
                        {
                            cmdStudent.Parameters.AddWithValue("@name", name);
                            cmdStudent.Parameters.AddWithValue("@CourseId", CourseId);
                            cmdStudent.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                            cmdStudent.Parameters.AddWithValue("@username", username);
                            cmdStudent.Parameters.AddWithValue("@password", "ARFMS123");
                            cmdStudent.Parameters.AddWithValue("@uniId", uniId);
                            newStudentId = (int)cmdStudent.ExecuteScalar();
                        }

                        // Insert into users with the same ID as studentId, enabling IDENTITY_INSERT
                        string usersQuery = "SET IDENTITY_INSERT users ON; " +
                                           "INSERT INTO users (UserId, username, password, role) VALUES (@UserId, @username, @password, @role); " +
                                           "SET IDENTITY_INSERT users OFF;";
                        using (SqlCommand cmdUsers = new SqlCommand(usersQuery, con, transaction))
                        {
                            cmdUsers.Parameters.AddWithValue("@UserId", newStudentId);
                            cmdUsers.Parameters.AddWithValue("@username", username);
                            cmdUsers.Parameters.AddWithValue("@password", "ARFMS123");
                            cmdUsers.Parameters.AddWithValue("@role", "student");
                            cmdUsers.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Student added successfully with ID: " + newStudentId);
                        LoadStudents();
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error adding student: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }
        private void ClearFields()
        {
            StudentIDtxt.Text = "";
            Nametxt.Text = "";
            CourseBox.Text = ""; // Clear ComboBox text
            Emailtxt.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Get the selected row's studentId
            if (studentsdgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            string studentId = studentsdgv.SelectedRows[0].Cells["studentId"].Value?.ToString();
            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Invalid student ID selected.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete student ID " + studentId + "?",
                                                 "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(
                System.Configuration.ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                try
                {
                    con.Open();
                    System.Data.SqlClient.SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        // Delete from users first (due to foreign key constraints if any)
                        string usersQuery = "DELETE FROM users WHERE UserId = @userId";
                        using (System.Data.SqlClient.SqlCommand cmdUsers = new System.Data.SqlClient.SqlCommand(usersQuery, con, transaction))
                        {
                            cmdUsers.Parameters.AddWithValue("@userId", studentId);
                            int usersAffected = cmdUsers.ExecuteNonQuery();
                            if (usersAffected == 0)
                            {
                                MessageBox.Show("No user found with ID " + studentId + ".");
                                return;
                            }
                        }

                        // Delete from students
                        string studentQuery = "DELETE FROM students WHERE studentId = @studentId";
                        using (System.Data.SqlClient.SqlCommand cmdStudent = new System.Data.SqlClient.SqlCommand(studentQuery, con, transaction))
                        {
                            cmdStudent.Parameters.AddWithValue("@studentId", studentId);
                            int studentsAffected = cmdStudent.ExecuteNonQuery();
                            if (studentsAffected == 0)
                            {
                                MessageBox.Show("No student found with ID " + studentId + ".");
                                return;
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Student ID " + studentId + " deleted successfully!");
                        LoadStudents(); // Refresh the DataGridView
                    }
                    catch (System.Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error deleting student: " + ex.Message + "\nDetails: " + ex.StackTrace);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message + "\nDetails: " + ex.StackTrace);
                }
            }
        }

        private void studentsdgv_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
