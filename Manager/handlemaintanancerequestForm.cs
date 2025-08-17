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
    public partial class handlemaintanancerequestForm : Form
    {
        public handlemaintanancerequestForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDeclineRequest_Click(object sender, EventArgs e)
        {
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
        }

        private void btnSeeMaintananceReq_Click(object sender, EventArgs e)
        {
            dataMaintananceReqDetails.Visible = true;
        }

        private void ShowTable()
        {
            try
            {
                // get connection string from app.config (mycs is the name we create)
                string connString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

                // Create the sql connection
                using (SqlConnection con = new SqlConnection(connString))
                {
                    // Write the SQL query (adjust table name & columns to match your DB)
                    string query = "SELECT * FROM users";

                    // Create the sql command
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Open the connection
                        con.Open();

                        // Use SqlDataAdapter to fill a DataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind the DataTable to the dataUserDetails
                        dataMaintananceReqDetails.DataSource = dt;
                    }
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
    }
}
