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

namespace iOOP_Receptionist
{
    public partial class ARFMSExistingBookings : Form
    {
        public ARFMSExistingBookings()
        {
            InitializeComponent();
            //clear the text box for Search
            Searchtxt.Enter += (s, args) =>
            {
                if (Searchtxt.Text == "Search by Booking ID or Student ID")
                    Searchtxt.Text = "";
            };
            {
                if (string.IsNullOrEmpty(Searchtxt.Text))
                    Searchtxt.Text = "Search by Booking ID or Student ID";
            };
        }

        private void LoadBookings(string searchText = "")
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT b.BookingId, b.studentId, s.Name as StudentName, f.[facility category] as Facility, 
                           b.BookingDate as BookingDate, b.BookingTime as BookingTime, b.Status as Status
                           FROM Booking b
                           JOIN students s ON b.studentId = s.studentId
                           JOIN facilities f ON b.facilityId = f.facilitiesId";
                    if (!string.IsNullOrEmpty(searchText) && searchText != "Search by Booking ID or Student ID")
                    {
                        query += " WHERE CAST(b.BookingId AS NVARCHAR(10)) LIKE @search OR CAST(b.studentId AS NVARCHAR(10)) LIKE @search";
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        if (!string.IsNullOrEmpty(searchText) && searchText != "Search by Booking ID or Student ID")
                        {
                            da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText.ToUpper() + "%");
                        }
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Bookingdgv.DataSource = dt;
                        if (dt.Rows.Count == 0 && !string.IsNullOrEmpty(searchText) && searchText != "Search by Booking ID or Student ID")
                        {
                            MessageBox.Show($"No bookings found for search: '{searchText}'. Please check the input and try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading bookings: " + ex.Message);
                }
            }
        }

        private void ARFMSExistingBookings_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReceptionForm receptionForm = new ReceptionForm();
            receptionForm.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = Searchtxt.Text.Trim() ;
            LoadBookings(searchText );
        }


    }
}
