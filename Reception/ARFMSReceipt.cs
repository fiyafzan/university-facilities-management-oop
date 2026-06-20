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
    public partial class ARFMSReceipt : Form
    {
        public ARFMSReceipt()
        {
            InitializeComponent();
        }

        // Public method to set receipt details using the Receipt class
        public void SetReceiptDetails(Receipt receipt)
        {
            studentidlbl.Text = receipt.StudentID;
            namelbl.Text = receipt.Name;
            facilitylbl.Text = receipt.Facility;
            datelbl.Text = receipt.Date;
            timelbl.Text = receipt.Time;
            availabilitylbl.Text = receipt.Availability;
            pricelbl.Text = receipt.Price;
            paymentstatuslbl.Text = receipt.Status;
        }

        private void facilitylbl_Click(object sender, EventArgs e)
        {
            // Empty handler - remove if not needed
        }

        private void paymentstatuslbl_Click(object sender, EventArgs e)
        {
            // Empty handler - remove if not needed
        }

        private void studentidlbl_Click(object sender, EventArgs e)
        {
            // Empty handler - remove if not needed
        }

        private void pricelbl_Click(object sender, EventArgs e)
        {
            // Empty handler - remove if not needed
        }

        private void namelbl_Click(object sender, EventArgs e)
        {
            // Empty handler - remove if not needed
        }

        private void availabilitylbl_Click(object sender, EventArgs e)
        {
            // Empty handler - remove if not needed
        }

        private void datelbl_Click(object sender, EventArgs e)
        {
            // Empty handler - remove if not needed
        }

        private void timelbl_Click(object sender, EventArgs e)
        {
            // Empty handler - remove if not needed
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ARFMSAcceptBooking acceptBooking = new ARFMSAcceptBooking();
            this.Hide();
            acceptBooking.ShowDialog();

        }

        private void ARFMSReceipt_Load(object sender, EventArgs e)
        {

        }
    }
}