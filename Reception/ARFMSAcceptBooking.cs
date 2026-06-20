using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace iOOP_Receptionist
{
    public partial class ARFMSAcceptBooking : Form
    {
        public ARFMSAcceptBooking()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string bookingId = Searchtxt.Text.Trim();
            if (string.IsNullOrEmpty(bookingId))
            {
                MessageBox.Show("Please enter a Booking ID.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["myARFMS"].ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT b.StudentId, s.Name, f.FacilityCategory, b.BookingDate, 
                            b.BookingTime, f.Availability, f.FacilityRate, b.Status
                            FROM booking b
                            JOIN student s ON b.StudentId = s.StudentId
                            JOIN facility f ON b.FacilityId = f.FacilityId
                            WHERE b.bookingId = @bookingId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                studentidlbl.Text = dr["StudentId"].ToString();
                                namelbl.Text = dr["Name"].ToString();
                                facilitylbl.Text = dr["FacilityCategory"].ToString();
                                datelbl.Text = dr["BookingDate"].ToString();
                                timelbl.Text = dr["BookingTime"].ToString();
                                availabilitylbl.Text = dr["Availability"].ToString();
                                pricelbl.Text = dr["FacilityRate"].ToString();
                                paymentstatuslbl.Text = dr["Status"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No booking found with ID " + bookingId);
                                // Clear labels if no booking is found
                                studentidlbl.Text = "";
                                namelbl.Text = "";
                                facilitylbl.Text = "";
                                datelbl.Text = "";
                                timelbl.Text = "";
                                availabilitylbl.Text = "";
                                pricelbl.Text = "";
                                paymentstatuslbl.Text = "";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading booking details: " + ex.Message);
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionForm receptionForm = new ReceptionForm();
            receptionForm.ShowDialog();
        }

        private void approvebtn_Click(object sender, EventArgs e)
        {
            string bookingId = Searchtxt.Text.Trim();
            if (string.IsNullOrEmpty(bookingId))
            {
                MessageBox.Show("Please search for a booking first.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["myARFMS"].ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE booking SET Status = @status WHERE bookingId = @bookingId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@status", "Approved");
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booking approved successfully.");
                            paymentstatuslbl.Text = "Approved"; // Update UI to reflect new status

                            // Create Receipt object with current booking details
                            Receipt receipt = new Receipt
                            {
                                ReceiptNumber = bookingId,
                                StudentID = studentidlbl.Text,
                                Name = namelbl.Text,
                                Facility = facilitylbl.Text,
                                Date = datelbl.Text,
                                Time = timelbl.Text,
                                Availability = availabilitylbl.Text,
                                Price = pricelbl.Text,
                                Status = "Approved"
                            };

                            // Instantiate and pass receipt to ARFMSReceipt
                            ARFMSReceipt receiptForm = new ARFMSReceipt();
                            this.Hide();
                            receiptForm.SetReceiptDetails(receipt);
                            receiptForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Failed to approve booking. Booking ID not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error approving booking: " + ex.Message);
                }
            }
        }
        private void rejectbtn_Click(object sender, EventArgs e)
        {
            string bookingId = Searchtxt.Text.Trim();
            if (string.IsNullOrEmpty(bookingId))
            {
                MessageBox.Show("Please search for a booking first.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["myARFMS"].ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE booking SET Status = @status WHERE bookingId = @bookingId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@status", "Rejected");
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Booking rejected successfully.");
                            paymentstatuslbl.Text = "Rejected"; // Update UI to reflect new status
                        }
                        else
                        {
                            MessageBox.Show("Failed to reject booking. Booking ID not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error rejecting booking: " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
