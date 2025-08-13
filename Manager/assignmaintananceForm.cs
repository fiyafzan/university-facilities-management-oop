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
    public partial class assignmaintananceForm : Form
    {
        public assignmaintananceForm()
        {
            InitializeComponent();
        }

        private void btnAssignMaintanance_Click(object sender, EventArgs e)
        {
            assignmaintanance2Form f2 = new assignmaintanance2Form();
            f2.Show();
            this.Hide();
        }

        private void btnExitAssignMaintanace_Click(object sender, EventArgs e)
        {
            managerForm f1 = new managerForm();
            f1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assignmaintananceForm_Load(object sender, EventArgs e)
        {
            dataMaintanance1.Hide();
            ShowTable();
        }

        private void btnSeeAssignMaintanance_Click(object sender, EventArgs e)
        {
            dataMaintanance1.Show();
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
                    string query = "SELECT * FROM maintanances";

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
                        dataMaintanance1.DataSource = dt;
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
