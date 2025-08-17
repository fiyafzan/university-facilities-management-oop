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
        // get connection string from app.config (mycs is the name we create)
        string connString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
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
            // Load University names
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UniId, uniName FROM universities", con);                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                
                SqlCommand query = new SqlCommand("SELECT username FROM users WHERE role = 'maintenance'", con);
                SqlDataAdapter db = new SqlDataAdapter(query);
                DataTable du = new DataTable();
                
                da.Fill(dt);
                db.Fill(du);

                comboboxUniversity.DataSource = dt;
                comboboxUniversity.DisplayMember = "uniName"; // what the user sees
                comboboxUniversity.ValueMember = "UniId";      // actual value (int)
                                                               // 
                comboboxTechnician.DataSource = du;
                comboboxTechnician.DisplayMember = "username";
                comboboxTechnician.ValueMember = "username";

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

        private void btnConfirmAddMaintanance_Click(object sender, EventArgs e)
        {
            // define adduser as Username, Password, and Role from User class
            Maintanance addmaintanance = new Maintanance(comboboxUniversity.SelectedValue.ToString(), comboboxFacilityType.SelectedValue.ToString(), comboboxDuration.SelectedValue.ToString(), txtDateAssignMaintanance.Text, comboboxTechnician.SelectedValue.ToString());

            // show message box for adduser from addUser(User constructor)
            MessageBox.Show(addmaintanance.addMaintanance());

            //convert to string from text

            txtDateAssignMaintanance.Text = String.Empty;            
        }

        private void comboboxUniversity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboboxUniversity.SelectedValue == null || comboboxUniversity.SelectedValue is DataRowView)
                return;
            {
                int selectedUniID = Convert.ToInt32(comboboxUniversity.SelectedValue);

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT FacilitiesId, [facility category] FROM facilities WHERE UniId = @uniID", con);
                    cmd.Parameters.AddWithValue("@uniID", selectedUniID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboboxFacilityType.DataSource = dt;
                    comboboxFacilityType.DisplayMember = "facility category";
                    comboboxFacilityType.ValueMember = "FacilitiesId";
                }
            }
        }

        private void comboboxFacilityType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }        
    }
}
