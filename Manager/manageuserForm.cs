using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioopassignment
{
    public partial class manageuserForm : Form
    {
        public manageuserForm()
        {
            InitializeComponent();
        }

        // go to next from
        private void button1_Click(object sender, EventArgs e)
        {
            adduserForm f2 = new adduserForm();
            f2.Show();
            this.Hide();
        }

        // make it invisible
        private void grpUserDetails_Enter(object sender, EventArgs e)
        {
            
        }

        // make it visible
        private void btnSeeUser_Click(object sender, EventArgs e)
        {
            dataUserDetails.Visible = true;
        }

        // show table when the form loads
        private void manageuserForm_Load(object sender, EventArgs e)
        {
            dataUserDetails.Visible = false;
            ShowTable();
        }

        // go to the form before
        private void btnExitManageUser_Click(object sender, EventArgs e)
        {
            managerForm f1 = new managerForm();
            f1.Show();
            this.Hide();
        }

        // go to next form
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            deleteuserForm f3 = new deleteuserForm();
            f3.Show();
            this.Hide();
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
                        dataUserDetails.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show any errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataUserDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
