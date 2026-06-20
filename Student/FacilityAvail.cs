using ioopassignment;
using ioopassignment.Classes;
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
    public partial class FacilityAvail : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        private int selectedFacilityId = -1;
        private int id;

        public FacilityAvail()
        {
            InitializeComponent();

            // If your Designer already wires these events, you can remove these lines.
            this.Load += FacilityAvail_Load;
            FacSearchBtn.Click += FacSearchBtn_Click;
            dgvFacilities.CellContentClick += dgvFacilities_CellContentClick;

            // Optional: make the grid nicer/safer
            dgvFacilities.ReadOnly = true;
            dgvFacilities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacilities.MultiSelect = false;
            dgvFacilities.AutoGenerateColumns = true; // grid will use Facility properties as columns
        }

        private List<Facility> GetFacilities(string facilityFilter = null)
        {
            var facilities = new List<Facility>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var sql = new StringBuilder();
                sql.Append("SELECT FacilitiesID, UniID, [Facility Category], [Facility Rate (/hr)], Capacity, [availability (y/n)] ");
                sql.Append("FROM facilities ");
                sql.Append("WHERE [availability (y/n)] = 'Y'"); // only show available

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    if (!string.IsNullOrWhiteSpace(facilityFilter))
                    {
                        sql.Append(" AND [facility category] LIKE @facility");
                        cmd.Parameters.AddWithValue("@facility", "%" + facilityFilter.Trim() + "%");
                    }

                    cmd.CommandText = sql.ToString();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            facilities.Add(MapFacility(reader)); // ✅ cleaner call
                        }
                    }
                }
            }

            return facilities;
        }


        private void LoadFacilities(string? facilityFilter = null, string? locationFilter = null)
        {
            var facilities = GetFacilities(facilityFilter);
            dgvFacilities.DataSource = facilities; // auto-binds to Facility properties
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FacilityAvail_Load(object sender, EventArgs e)
        {
            LoadFacilities(); // initial load
        }

        private void FacSearchBtn_Click(object sender, EventArgs e)
        {
            LoadFacilities(txtFacilitySearch.Text);
        }

        private void dgvFacilities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBackFacAvail_Click(object sender, EventArgs e)
        {
            StudentForm menu = new StudentForm(id.ToString());
            menu.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvFacilities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selected = dgvFacilities.Rows[e.RowIndex].DataBoundItem as Facility;
            if (selected == null) return;

            DisplayFacilityDetails(selected);
        }

        private void DisplayFacilityDetails(Facility facility)
        {
            txtFacilityCategory.Text = facility.Facility_category;
            txtFacilityRate.Text = facility.Facility_rate.ToString();
            txtFacilityCapacity.Text = facility.Facility_capacity.ToString();
            txtFacilityAvailability.Text = facility.Facility_availability;

            selectedFacilityId = facility.facilityid;
        }

        private Facility MapFacility(SqlDataReader reader)
        {
            return new Facility
            {                
                facilityid = Convert.ToInt32(reader["FacilitiesId"]),
                uniid = reader["UniId"].ToString(),
                Facility_category = reader["facility category"].ToString(),
                Facility_rate = reader["facility rate (/hr)"].ToString(),
                Facility_capacity = reader["capacity"].ToString(),
                Facility_availability = reader["availability (y/n)"].ToString()
            };
        }

    }

}
