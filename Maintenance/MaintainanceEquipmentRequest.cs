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
    public partial class MaintainanceEquipmentRequest : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        private void LoadSupplies()
        {

        }

        public MaintainanceEquipmentRequest()
        {
            InitializeComponent();
        }

        private void MaintainanceEquipmentRequest_Load(object sender, EventArgs e)
        {
            // Fill Equipment Name combo
            cmbEquipmentName.Items.AddRange(new string[] { "Wrench", "Hammer", "Drill", "Safety Helmet" });
            cmbEquipmentName.SelectedIndex = 0;

            // Fill Request Type combo
            cmbRequestType.Items.AddRange(new string[] { "Borrow", "Purchase", "Repair" });
            cmbRequestType.SelectedIndex = 0;

            // Set default date
            dtpRequestDate.Value = DateTime.Now;

            LoadRequests();
        }

        private void LoadRequests()
        {
            List<EquipmentRequestClass> requests = new List<EquipmentRequestClass>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT RequestID, EquipmentName, Quantity, RequestType, RequestDate FROM EquipmentRequests";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    requests.Add(new EquipmentRequestClass
                    {
                        RequestID = reader.GetInt32(0),
                        EquipmentName = reader.GetString(1),
                        Quantity = reader.GetInt32(2),
                        RequestType = reader.GetString(3),
                        RequestDate = reader.GetDateTime(4)
                    });
                }
            }

            dgvSupplies.DataSource = requests;
        }

        private bool ValidateRequest()
        {
            if (cmbEquipmentName.SelectedItem == null || nmbQuantity.Value <= 0)
            {
                MessageBox.Show("Please select equipment and enter a valid quantity.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void dgvSupplies_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!ValidateRequest()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO EquipmentRequests (EquipmentName, Quantity, RequestType, RequestDate) 
                         VALUES (@name, @qty, @type, @rdate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", cmbEquipmentName.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@qty", (int)nmbQuantity.Value);
                cmd.Parameters.AddWithValue("@type", cmbRequestType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@rdate", dtpRequestDate.Value.Date);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Request submitted successfully!");
            
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {



        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBackEqReq_Click(object sender, EventArgs e)
        {
            MaintainanceForm menu = new MaintainanceForm();
            menu.Show();
            this.Hide();
        }

        private void cmbRequestType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
