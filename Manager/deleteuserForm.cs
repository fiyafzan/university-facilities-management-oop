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
    public partial class deleteuserForm : Form
    {
        // get connection string from app.config (mycs is the name we create)
        string connString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
        public deleteuserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // go to form before
        private void btnExitDeleteUser_Click(object sender, EventArgs e)
        {
            manageuserForm f1 = new manageuserForm();
            f1.Show();
            this.Hide();
        }

        private void deleteuserForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void ShowTable()
        {
            try
            {                                
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
                        dataUserDetails2.DataSource = dt;
                    }
                }


            }
            catch (Exception ex)
            {
                // Show any errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataUserDetails2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmDeleteUser_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void deleteUser()
        {

            try
            {
                // Check if the user selected a row
                if (dataUserDetails2.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.");
                    return; // Stop here if nothing is selected
                }

                // Get the ID value from the first cell in the selected row
                // convert.toint16 is to convert the id(string) to 16-bit integer
                int selectedId = Convert.ToInt16(dataUserDetails2.SelectedRows[0].Cells["UserId"].Value);

                // Confirm before deleting
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?",
                                                       "Confirm Delete",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);
                if (confirm == DialogResult.No)
                {
                    return; // If user clicks No, stop here
                }

                // Delete from database
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM users WHERE UserId = @UserId"; // Delete specific row
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@UserId", selectedId);
                    cmd.ExecuteNonQuery(); // Run the delete command
                }

                // Refresh the table
                ShowTable();

                MessageBox.Show("Record deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
        }
    }
}
