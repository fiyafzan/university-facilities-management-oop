using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioopassignment
{
    public partial class handlemaintanancerequestForm : Form
    {
        // get connection string from app.config (mycs is the name we create)
        string connString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
        public handlemaintanancerequestForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDeclineRequest_Click(object sender, EventArgs e)
        {
            declineRequest();
        }

        private void btnExitHandleRequest_Click(object sender, EventArgs e)
        {
            managerForm f1 = new managerForm();
            f1.Show();
            this.Hide();
        }

        private void handlemaintanancerequestForm_Load(object sender, EventArgs e)
        {
            ShowTable();
            dataMaintananceReqDetails.Visible = false;
            dataMaintananceReqDetails2.Visible = false;
        }

        private void btnSeeMaintananceReq_Click(object sender, EventArgs e)
        {
            dataMaintananceReqDetails.Visible = true;
            dataMaintananceReqDetails2.Visible = true;
        }

        private void ShowTable()
        {
            try
            {                

                // Create the sql connection
                using (SqlConnection con = new SqlConnection(connString))
                {
                    // Write the SQL query (adjust table name & columns to match your DB)
                    string query = "SELECT * FROM ReplacementRequests";
                    string query2 = "SELECT * FROM EquipmentRequests";

                    // Open the connection
                    con.Open();

                    // Use SqlDataAdapter to fill a DataTable
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    SqlDataAdapter da2 = new SqlDataAdapter(query2, con);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataMaintananceReqDetails2.DataSource = dt2;

                    // Bind the DataTable to the dataUserDetails
                    dataMaintananceReqDetails.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Show any errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void grpHandleRequest_Enter(object sender, EventArgs e)
        {

        }

        private void dataMaintananceReqDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            approveRequest();
        }

        private void approveRequest()
        {            
            try
            {
                // Check if a row is selected
                if (dataMaintananceReqDetails.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a request to approve.");
                    return;
                }

                if (dataMaintananceReqDetails2.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a request to approve.");
                    return;
                }

                // Get RequestId from the selected row
                int requestId = Convert.ToInt32(dataMaintananceReqDetails.SelectedRows[0].Cells["RequestId"].Value);
                int requestId2 = Convert.ToInt32(dataMaintananceReqDetails2.SelectedRows[0].Cells["RequestId"].Value);

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    // Update query
                    string query = "UPDATE EquipmentRequests SET ReqStatus = 'Approved' WHERE RequestId = @id";
                    string query2 = "UPDATE ReplacementRequests SET ReqStatus = 'Approved' WHERE RequestId = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd.Parameters.AddWithValue("@id", requestId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Request approved successfully!");
                    else
                        MessageBox.Show("Failed to approve request.");
                }

                // Refresh table to show updated status
                ShowTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error approving request: " + ex.Message);
            }
        }

        private void declineRequest()
        {
            try
            {
                // Check if a row is selected
                if (dataMaintananceReqDetails.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a request to decline.");
                    return;
                }

                if (dataMaintananceReqDetails2.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a request to decline.");
                    return;
                }

                // Get RequestId from the selected row
                int requestId = Convert.ToInt32(dataMaintananceReqDetails.SelectedRows[0].Cells["RequestId"].Value);
                int requestId2 = Convert.ToInt32(dataMaintananceReqDetails2.SelectedRows[0].Cells["RequestId"].Value);

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    // Update query
                    string query = "UPDATE EquipmentRequests SET ReqStatus = 'Declined' WHERE RequestId = @id";
                    string query2 = "UPDATE ReplacementRequests SET ReqStatus = 'Declined' WHERE RequestId = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd.Parameters.AddWithValue("@id", requestId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Request declined successfully!");
                    else
                        MessageBox.Show("Failed to decline request.");
                }

                // Refresh table to show updated status
                ShowTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error declining request: " + ex.Message);
            }
        }

    }
}

