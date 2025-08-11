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
    public partial class addfacilitiesForm : Form
    {
        public addfacilitiesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExitAddFacility_Click(object sender, EventArgs e)
        {
            managefacilitiesForm f1 = new managefacilitiesForm();
            f1.Show();
            this.Hide();
        }

        private void btnConfirmAddFacility_Click(object sender, EventArgs e)
        {
            // define adduser as Username, Password, and Role from User class
            Facility addfacility = new Facility(txtAddUniversity.Text, txtAddFacilityCategory.Text, txtAddFacilityRate.Text, txtAddFacilityCapacity.Text);

            // show message box for adduser from addUser(User constructor)
            MessageBox.Show(addfacility.addFacility());

            //convert to string from text
            txtAddUniversity.Text = String.Empty;
            txtAddFacilityCategory.Text = String.Empty;
            txtAddFacilityRate.Text = String.Empty;
            txtAddFacilityCapacity.Text = String.Empty;
        }

        private void txtAddFacilityCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
