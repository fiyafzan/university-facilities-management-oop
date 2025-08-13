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
    public partial class assignmaintanance2Form : Form
    {
        public assignmaintanance2Form()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExitAddMaintanance_Click(object sender, EventArgs e)
        {
            assignmaintananceForm f1 = new assignmaintananceForm();
            f1.Show();
            this.Hide();
        }

        private void assignmaintanance2Form_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            // get connection string from app.config (mycs is the name we create)
            string connString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            // Create the connection to SQL Server
            using (SqlConnection con = new SqlConnection(connString))
            {
                // Create the SQL query
                string query = "SELECT university, [facility category] FROM Facilities"; // Change to your table and column names

                // Use DataAdapter to fill the data
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                // Create a DataTable to hold the data
                DataTable dt = new DataTable();

                // Fill the DataTable
                da.Fill(dt);

                // Step 6: Bind the ComboBox to the DataTable
                comboboxUniversity.DataSource = dt; // The whole table is the source
                comboboxUniversity.DisplayMember = "university"; // What the user sees                

                comboboxFacilityType.DataSource = dt;
                comboboxFacilityType.DisplayMember = "facility category";                
            }

            var durations = new[]
            {
                new { Value = 1, Text = "1 hour" },
                new { Value = 2, Text = "2 hours" },
                new { Value = 5, Text = "5 hours" }
            };

            // Bind to ComboBox
            comboboxDuration.DataSource = durations;
            comboboxDuration.DisplayMember = "Text";   // What user sees
            comboboxDuration.ValueMember = "Value";    // Actual data you use in code
        }
    }
}
