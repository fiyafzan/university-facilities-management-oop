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

namespace ioopassignment.Manager
{
    public partial class editfacilitiesForm : Form
    {
        // get connection string from app.config (mycs is the name we create)
        string connString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        DataTable dt = new DataTable();
        public editfacilitiesForm()
        {
            InitializeComponent();
        }

        private void dataFacilityDetails2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editfacilitiesForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void btnExitEditFacilities_Click(object sender, EventArgs e)
        {
            managefacilitiesForm f1 = new managefacilitiesForm();
            f1.Show();
            this.Hide();
        }

        private void ShowTable()
        {
            try
            {                
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
                        da.Fill(dt);

                        // Bind the DataTable to the dataUserDetails
                        dataFacilityDetails3.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show any errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConfirmEditFacilities_Click(object sender, EventArgs e)
        {
            editFacility();
        }

        private void editFacility()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                //fetches data from database and send back data updates to database
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Facilities", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da); // Auto-generate SQL for update                
                da.Update(dt); // Save changes back to database
                MessageBox.Show("Changes saved successfully!");

                // Bind the DataTable to the dataUserDetails
                dataFacilityDetails3.DataSource = dt;
            }
        }
    }
}
