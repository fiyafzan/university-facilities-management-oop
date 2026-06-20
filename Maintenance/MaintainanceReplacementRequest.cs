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
    public partial class MaintainanceReplacementRequest : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        public MaintainanceReplacementRequest()
        {
            InitializeComponent();
        }

        private void MaintainanceReplacementRequest_Load(object sender, EventArgs e)
        {
            LoadRequests();

        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (!ValidateRequest()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO ReplacementRequests (EquipmentName, RequestType, RequestDate, ProblemDescription) VALUES (@name, @type, @date, @desc)", conn);
                cmd.Parameters.AddWithValue("@name", txtEquipName.Text.Trim());
                cmd.Parameters.AddWithValue("@type", cmbRepairType.Text.Trim());
                cmd.Parameters.AddWithValue("@date", dtpRequestDate.Value.Date);
                cmd.Parameters.AddWithValue("@desc", txtProblemDesc.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Request submitted successfully!");
            LoadRequests();

        }

        private void LoadRequests()
        {
            List<ReplacementRequest> requests = new List<ReplacementRequest>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT RequestID, EquipmentName, RequestType, RequestDate, ProblemDescription FROM ReplacementRequests";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    requests.Add(new ReplacementRequest
                    {
                        RequestID = reader.GetInt32(0),
                        EquipmentName = reader.GetString(1),
                        RequestType = reader.GetString(2),
                        RequestDate = reader.GetDateTime(3),
                        ProblemDescription = reader.GetString(4)
                    });
                }
            }

            dgvRequests.DataSource = requests;

        }


        private void btnBackReplacementRequest_Click(object sender, EventArgs e)
        {
            MaintainanceForm menu = new MaintainanceForm();
            menu.Show();
            this.Hide();
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request to cancel.");
                return;
            }

            int requestId = (int)dgvRequests.SelectedRows[0].Cells["RequestID"].Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ReplacementRequests WHERE RequestID=@id", conn);
                cmd.Parameters.AddWithValue("@id", requestId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Request cancelled successfully!");
            LoadRequests();
        }

        private void cmbRepairType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateRequest()
        {
            if (string.IsNullOrWhiteSpace(txtEquipName.Text) ||
                string.IsNullOrWhiteSpace(cmbRepairType.Text) ||
                string.IsNullOrWhiteSpace(txtProblemDesc.Text))
            {
                MessageBox.Show("Please fill in all fields.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
