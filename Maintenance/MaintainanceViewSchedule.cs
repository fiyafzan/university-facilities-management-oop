using ioopassignment.Classes;
using Microsoft.VisualBasic;
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
    public partial class MaintainanceViewSchedule : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        public MaintainanceViewSchedule()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MaintainanceViewSchedule_Load(object sender, EventArgs e)
        {
            // Set default combo values
            cmbStatusFilter.Items.AddRange(new string[] { "All", "Pending", "In Progress", "Completed" });
            cmbStatusFilter.SelectedIndex = 0;

            LoadSchedule(); // load all schedules when page opens
        }

        private void btnSearchSchdule_Click(object sender, EventArgs e)
        {
            LoadSchedule(dtpSearchDate.Value, txtFacilitySearch.Text, cmbStatusFilter.SelectedItem.ToString());
        }

        private void LoadSchedule(DateTime? searchDate = null, string? facilityName = null, string? status = null)
        {
            List<Maintanance> schedules = new List<Maintanance>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT MaintananceId, FacilitiesId, [Date], Status, technician " +
                             "FROM maintanances " +
                             "WHERE technician = @staffName";

                if (searchDate.HasValue)
                    sql += " AND CAST([Date] AS DATE) = @date";

                if (!string.IsNullOrWhiteSpace(facilityName))
                    sql += " AND [facility category] LIKE @facility";

                if (!string.IsNullOrWhiteSpace(status) && status != "All")
                    sql += " AND Status = @status";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@staffName", "maintenance1");

                    if (searchDate.HasValue)
                        cmd.Parameters.AddWithValue("@date", searchDate.Value.Date);

                    if (!string.IsNullOrWhiteSpace(facilityName))
                        cmd.Parameters.AddWithValue("@facility", "%" + facilityName + "%");

                    if (!string.IsNullOrWhiteSpace(status) && status != "All")
                        cmd.Parameters.AddWithValue("@status", status);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Maintanance schedule = new Maintanance();
                        {
                            schedule.MaintenanceId = reader.GetString(0);
                            schedule.FacilitiesId = reader.GetString(2);
                            schedule.maintanance_date = reader.GetDateTime(4).ToString();
                            schedule.maintanance_technician = reader.GetString(5);
                            schedule.Status = reader.GetString(6);
                        };

                        schedules.Add(schedule);
                    }
                }
            }

            // Bind the list of objects to the DataGridView
            dgvSchedule.DataSource = schedules;
        }

        private void btnScheduleBack_Click(object sender, EventArgs e)
        {
            MaintainanceForm menu = new MaintainanceForm(); // go back to main maintenance menu
            menu.Show();
            this.Hide();
        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFacilitySearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFacilitySearch.Clear();
            cmbStatusFilter.SelectedIndex = 0;
            LoadSchedule();
        }
    }
}
