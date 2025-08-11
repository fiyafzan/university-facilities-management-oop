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
    public partial class managefacilitiesForm : Form
    {
        public managefacilitiesForm()
        {
            InitializeComponent();
        }       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitManageUser_Click(object sender, EventArgs e)
        {
            managerForm f0 = new managerForm();
            f0.Show();
            this.Hide();
        }

        private void btnSeeFacilities_Click(object sender, EventArgs e)
        {
            dataFacilityDetails.Visible = true;
        }

        private void managefacilitiesForm_Load(object sender, EventArgs e)
        {
            dataFacilityDetails.Visible = false;
            ShowTable();
        }
        private void grpFacilitiesDetails_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnAddFacilities_Click(object sender, EventArgs e)
        {
            addfacilitiesForm f1 = new addfacilitiesForm();
            f1.Show();
            this.Hide();
        }

        private void btnDeleteFacilities_Click(object sender, EventArgs e)
        {
            deletefacilitiesForm f2 = new deletefacilitiesForm();
            f2.Show();
            this.Hide();
        }

        private void btnEditFacilities_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    string query = "SELECT * FROM facilities";

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
                        dataFacilityDetails.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show any errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
