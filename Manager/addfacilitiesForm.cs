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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ioopassignment
{
    public partial class addfacilitiesForm : Form
    {
        public addfacilitiesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExitAddFacility_Click(object sender, EventArgs e)
        {
            managefacilitiesForm f1 = new managefacilitiesForm();
            f1.Show();
            this.Hide();
        }

        private void btnConfirmAddFacility_Click(object sender, EventArgs e)
        {
            // define adduser as Username, Password, and Role from User class
            Facility addfacility = new Facility(cboUniversity.SelectedValue.ToString(), txtAddFacilityCategory.Text, txtAddFacilityRate.Text, txtAddFacilityCapacity.Text, txtAddAvailability.Text);

            // show message box for adduser from addUser(User constructor)
            MessageBox.Show(addfacility.addFacility());

            //convert to string from text
           
            txtAddFacilityRate.Text = String.Empty;
            txtAddFacilityCapacity.Text = String.Empty;
            txtAddAvailability.Text = String.Empty;
        }

        private void txtAddFacilityCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void addfacilitiesForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            string connString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            // Step 1: Create the connection to SQL Server
            using (SqlConnection con = new SqlConnection(connString))
            {
                // Step 2: Create the SQL query
                string query = "SELECT UniId, uniName FROM universities"; // Change to your table and column names

                // Step 3: Use DataAdapter to fill the data
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                // Step 4: Create a DataTable to hold the data
                DataTable dt = new DataTable();

                // Step 5: Fill the DataTable
                da.Fill(dt);

                // Step 6: Bind the ComboBox to the DataTable
                cboUniversity.DataSource = dt;          // The whole table is the source
                cboUniversity.DisplayMember = "uniName"; // What the user sees
                cboUniversity.ValueMember = "UniId";     // The actual value (ID)
            }
        }
    }
}
