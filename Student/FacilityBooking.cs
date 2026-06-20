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
    public partial class FacilityBooking : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
        private int selectedBookingId = -1;
        private int currentStudentId;

        public FacilityBooking(int userID)
        {
            InitializeComponent();   
            currentStudentId = userID;
        }

        private void FacilityBooking_Load(object sender, EventArgs e)
        {
            LoadFacilities();
            LoadMyBookings();

            // Example: every hour from 8:00 AM to 10:00 PM
            for (int hour = 8; hour <= 22; hour++)
            {
                cmbTime.Items.Add($"{hour:00}:00");
                cmbTime.Items.Add($"{hour:00}:30"); // adds half hours too
            }

        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {

            if (cmbFacility.SelectedValue == null) return;

            int facilityId = Convert.ToInt32(cmbFacility.SelectedValue);
            DateTime bookingDate = dtpDate.Value.Date;
            TimeSpan bookingTime = TimeSpan.Parse(cmbTime.Text);

            AddBooking(facilityId, currentStudentId, bookingDate, bookingTime); // ✅ neat call

            LoadMyBookings();
            MessageBox.Show("Booking added!");
        }

        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selected = dgvBookings.Rows[e.RowIndex].DataBoundItem as Booking;
            if (selected == null) return;

            DisplayBookingDetails(selected); // ✅ much cleaner
        
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (selectedBookingId <= 0)
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            DeleteBooking(selectedBookingId, currentStudentId); // ✅ cleaner call
            LoadMyBookings();
            MessageBox.Show("Booking deleted!");

        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (selectedBookingId <= 0)
            {
                MessageBox.Show("Please select a booking to edit.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbTime.Text))
            {
                MessageBox.Show("Please select a time.");
                return;
            }

            if (!TimeSpan.TryParse(cmbTime.Text, out TimeSpan bookingTime))
            {
                MessageBox.Show("Invalid time format.");
                return;
            }

            int facilityId = Convert.ToInt32(cmbFacility.SelectedValue);
            DateTime bookingDate = dtpDate.Value.Date;

            if (UpdateBooking(selectedBookingId, currentStudentId, facilityId, bookingDate, bookingTime))
            {
                LoadMyBookings();
                MessageBox.Show("Booking updated!");
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentForm menu = new StudentForm(currentStudentId.ToString()); // replace with your menu form name
            menu.Show();
            this.Close(); // closes booking form
        }

        private void LoadFacilities()
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                "SELECT FacilitiesId, [Facility Category] + ' - ' + CAST(Uniid AS VARCHAR) AS Name " +
                "FROM facilities WHERE [Availability (y/n)] = 'Y'", conn))
            {
                var dt = new DataTable();
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                cmbFacility.DataSource = dt;
                cmbFacility.DisplayMember = "Name";
                cmbFacility.ValueMember = "FacilitiesId";
            }
        
        }

        private List<Booking> GetMyBookings()
        {
            var bookings = new List<Booking>();

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                "SELECT BookingID, FacilityID, StudentID, BookingDate, BookingTime, Status " +
                "FROM Booking WHERE StudentID=@sid", conn))
            {
                cmd.Parameters.AddWithValue("@sid", currentStudentId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(MapBooking(reader)); // ✅ much cleaner
                    }
                }
            }

            return bookings;
        }

        private Booking MapBooking(SqlDataReader reader)
        {
            return new Booking
            {
                BookingID = Convert.ToInt32(reader["BookingID"]),
                FacilityID = Convert.ToInt32(reader["FacilityID"]),
                StudentID = Convert.ToInt32(reader["StudentID"]),
                BookingDate = Convert.ToDateTime(reader["BookingDate"]),
                BookingTime = (TimeSpan)reader["BookingTime"],
                Status = reader["Status"].ToString()
            };
        }



        private void LoadMyBookings()
        {
            dgvBookings.DataSource = GetMyBookings();
        }

        private void AddBooking(int facilityId, int studentId, DateTime bookingDate, TimeSpan bookingTime)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                "INSERT INTO Booking (FacilityID, StudentID, BookingDate, BookingTime) " +
                "VALUES (@fid,@sid,@date,@time)", conn))
            {
                cmd.Parameters.AddWithValue("@fid", facilityId);
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@date", bookingDate);
                cmd.Parameters.AddWithValue("@time", bookingTime);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void DisplayBookingDetails(Booking booking)
        {
            selectedBookingId = booking.BookingID;
            cmbFacility.SelectedValue = booking.FacilityID;
            dtpDate.Value = booking.BookingDate;
            cmbTime.Text = booking.BookingTime.ToString(@"hh\:mm");
        }

        private void DeleteBooking(int bookingId, int studentId)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("DELETE FROM Booking WHERE BookingID=@bid AND StudentID=@sid", conn))
            {
                cmd.Parameters.AddWithValue("@bid", bookingId);
                cmd.Parameters.AddWithValue("@sid", studentId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private bool UpdateBooking(int bookingId, int studentId, int facilityId, DateTime bookingDate, TimeSpan bookingTime)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                "UPDATE Booking SET FacilityID=@fid, BookingDate=@date, BookingTime=@time " +
                "WHERE BookingID=@bid AND StudentID=@sid", conn))
            {
                cmd.Parameters.AddWithValue("@fid", facilityId);
                cmd.Parameters.AddWithValue("@date", bookingDate);
                cmd.Parameters.AddWithValue("@time", bookingTime);
                cmd.Parameters.AddWithValue("@bid", bookingId);
                cmd.Parameters.AddWithValue("@sid", studentId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }


}

