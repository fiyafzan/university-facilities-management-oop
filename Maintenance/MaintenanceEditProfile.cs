using ioopassignment;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace iOOP_Receptionist
{
    public partial class MaintenanceEditProfile : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
        private int currentUserId;
        private MaintenanceProfile currentProfile; // Updated to use MaintenanceProfile class      

        public MaintenanceEditProfile(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void MaintenanceEditProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
            MessageBox.Show("UserID = " + currentUserId);
        }

        private void LoadProfile()
        {
            currentProfile = MaintenanceProfile.GetProfileById(currentUserId, connectionString);

            if (currentProfile != null)
            {
                useridlbl.Text = currentProfile.UserId.ToString();
                useridlbl.Enabled = false; // Non-editable UserId
                usernametxt.Text = currentProfile.Username;
                passwordtxt.Text = currentProfile.Password;
                // Role is fixed as "maintenance" and not displayed for editing
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MaintainanceForm menu = new MaintainanceForm();
            menu.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Remove if not needed
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametxt.Text) || string.IsNullOrWhiteSpace(passwordtxt.Text))
            {
                MessageBox.Show("Username and password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update profile object
            currentProfile.Username = usernametxt.Text.Trim();
            currentProfile.Password = passwordtxt.Text.Trim();
            currentProfile.Role = "maintenance"; // Fixed role

            // Save to DB
            if (currentProfile.UpdateProfile(connectionString))
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaintenanceEditProfile_Load_1(object sender, EventArgs e)
        {

        }
    }
}