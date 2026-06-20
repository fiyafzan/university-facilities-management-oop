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
    public partial class manageuniversitiesForm : Form
    {
        public manageuniversitiesForm()
        {
            InitializeComponent();
        }

        private void manageuniversitiesForm_Load(object sender, EventArgs e)
        {
            dataUniversityDetails.Visible = false;
            ShowTable();
        }

        private void btnSeeUser_Click(object sender, EventArgs e)
        {
            dataUniversityDetails.Visible = true;
        }

        private void dataUniversityDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    string query = "SELECT * FROM universities";

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
                        dataUniversityDetails.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show any errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExitManageUser_Click(object sender, EventArgs e)
        {
            managerForm f1 = new managerForm();
            f1.Show();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            adduniversitiesForm f2 = new adduniversitiesForm();
            f2.Show();
            this.Hide();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            deleteuniversitiesForm f3 = new deleteuniversitiesForm();
            f3.Show();
            this.Hide();
        }
    }
}
