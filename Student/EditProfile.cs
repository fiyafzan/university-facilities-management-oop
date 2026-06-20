using ioopassignment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioopassignment
{
    public partial class EditProfile : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
        private int currentUserId;
        private Student currentStudent;
        


        public EditProfile(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }


        private void EditProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
            MessageBox.Show("UserID = " + currentUserId);

        }

        private void LoadProfile()
        {
            currentStudent = Student.GetStudentById(currentUserId, connectionString);

            if (currentStudent != null)
            {
                txtName.Text = currentStudent.Name;
                txtEmail.Text = currentStudent.Email;
                txtCourseID.Text = currentStudent.CourseId.ToString();
                txtUsername.Text = currentStudent.Username;
                txtPassword.Text = currentStudent.Password;
                txtUniID.Text = currentStudent.UniId.ToString();
            }
            else
            {
                MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void EditProfileBackBtn_Click(object sender, EventArgs e)
        {
            StudentForm menu = new StudentForm(0.ToString());
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelUpdateProfile_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdatePrf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Name and Email cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // update student object
            currentStudent.Name = txtName.Text.Trim();
            currentStudent.Email = txtEmail.Text.Trim();
            currentStudent.CourseId = int.TryParse(txtCourseID.Text, out int course) ? course : 0;
            currentStudent.Username = txtUsername.Text.Trim();
            currentStudent.Password = txtPassword.Text.Trim();
            currentStudent.UniId = int.TryParse(txtUniID.Text, out int unil) ? unil : 0;

            // save to DB
            if (currentStudent.UpdateStudent(connectionString))
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

