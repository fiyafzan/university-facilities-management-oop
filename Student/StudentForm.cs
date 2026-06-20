using iOOP_Receptionist;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioopassignment
{
    public partial class StudentForm : Form
    {

        private int userID;

        public StudentForm(string n)
        {
            InitializeComponent();                   
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void AvaibilityBtn_Click(object sender, EventArgs e)
        {
            using (var form = new FacilityAvail())
            {
                FacilityAvail bookingForm = new FacilityAvail();
                bookingForm.Show();  // opens new window
                this.Hide();
            }
        }

        private void FacBookBtn_Click(object sender, EventArgs e)
        {
            FacilityBooking bookingForm = new FacilityBooking(userID);
            bookingForm.Show();  // opens new window
            this.Hide();
        }

        private void RateBtn_Click(object sender, EventArgs e)
        {
            FacilityReview ratingForm = new FacilityReview(userID);
            ratingForm.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            EditProfile menu = new EditProfile(userID);
            menu.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ARFMSLogin aRFMSLogin = new ARFMSLogin();
            aRFMSLogin.Show();
            this.Hide();
        }
    }
}
