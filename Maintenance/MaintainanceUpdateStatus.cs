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
    public partial class MaintainanceUpdateStatus : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
        private string loggedInStaff = "maintenance1"; // Replace with actual login username

        public MaintainanceUpdateStatus()
        {
            InitializeComponent();
        }

        private void MaintainanceUpdateStatus_Load(object sender, EventArgs e)
        {
            LoadTasks();
            LoadStatusOptions();
            LoadMyTasks();
        }

        private void dgvMyTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadMyTasks()
        {
            List<Maintanance> tasks = new List<Maintanance>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT MaintananceId, FacilitiesId, Status
                       FROM Maintanances
                       WHERE technician = @staff";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@staff", loggedInStaff);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tasks.Add(new Maintanance
                    {
                        MaintenanceId = reader.GetString(0),
                        facility_category = reader.GetString(1),
                        Status = reader.GetString(2),
                        maintanance_technician = loggedInStaff
                    });
                }
            }

            dgvTasks.DataSource = tasks;
        
        }


        private void LoadStatusOptions()
        {
            cmbNewStatus.Items.Clear();
            cmbNewStatus.Items.Add("Pending");
            cmbNewStatus.Items.Add("In Progress");
            cmbNewStatus.Items.Add("Completed");
            cmbNewStatus.SelectedIndex = 0;
        }

        private void LoadTasks()
        {
            List<Maintanance> tasks = new List<Maintanance>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT MaintananceId, FacilitiesId
                       FROM Maintanances 
                       WHERE technician = @staff";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@staff", loggedInStaff);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tasks.Add(new Maintanance
                    {
                        MaintenanceId = reader.GetString(0),
                        FacilitiesId = reader.GetString(1),
                        maintanance_technician = loggedInStaff
                    });
                }
            }

            cmbTask.DataSource = tasks;
            cmbTask.DisplayMember = "FacilityName";
            cmbTask.ValueMember = "FacilitiesId";
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (cmbTask.SelectedValue == null)
            {
                MessageBox.Show("Please select a task.");
                return;
            }

            int scheduleId = Convert.ToInt32(cmbTask.SelectedValue);
            string newStatus = cmbNewStatus.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE MaintenanceSchedule3 SET Status = @status WHERE ScheduleID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", scheduleId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Status updated successfully!");

            LoadMyTasks(); 
            LoadTasks();   
        }



        private void UpdateMaintenanceStatus_Load(object sender, EventArgs e)
        {
            LoadTasks();          
            LoadStatusOptions();  
        }

        private void btnMaintUpdateMenu_Click(object sender, EventArgs e)
        {

        }

        private void cmbTask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMaintUpdateMenu_Click_1(object sender, EventArgs e)
        {
            MaintainanceForm menu = new MaintainanceForm(); // go back to main maintenance menu
            menu.Show();
            this.Hide();
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
