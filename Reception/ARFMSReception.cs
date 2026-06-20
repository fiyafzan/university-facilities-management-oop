using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iOOP_Receptionist
{
    public partial class ReceptionForm : Form
    {
        public static string name;
        
        public ReceptionForm(string n)
        {
            InitializeComponent();
            name = n;
        }

        public ReceptionForm()
        {
            InitializeComponent();
        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
        }

        private void ManageStudentBtn_Click(object sender, EventArgs e)
        {
            ARFMSManageStudent manageStudentForm= new ARFMSManageStudent();
            manageStudentForm.Show();
            this.Hide();
        }

        private void SearchBookingBtn_Click(object sender, EventArgs e)
        {
            ARFMSExistingBookings existingBookingsForm= new ARFMSExistingBookings();
            existingBookingsForm.Show();
            this.Hide();
        }

        private void AcceptBookingBtn_Click(object sender, EventArgs e)
        {
            ARFMSAcceptBooking acceptBookingForm= new ARFMSAcceptBooking();
            acceptBookingForm.Show();
            this.Hide();
        }

        private void ViewRatingBtn_Click(object sender, EventArgs e)
        {
            ARFMSReviewRating ratingForm= new ARFMSReviewRating();
            ratingForm.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ARFMSLogin loginForm= new ARFMSLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
