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
    public partial class managefacilitiesForm : Form
    {
        public managefacilitiesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitManageUser_Click(object sender, EventArgs e)
        {
            managerForm f0 = new managerForm();
            f0.Show();
            this.Hide();
        }

        private void btnSeeFacilities_Click(object sender, EventArgs e)
        {
            grpFacilitiesDetails.Visible = true;
        }

        private void grpFacilitiesDetails_Enter(object sender, EventArgs e)
        {
            grpFacilitiesDetails.Visible = false;
        }

        private void btnAddFacilities_Click(object sender, EventArgs e)
        {
            addfacilitiesForm f1 = new addfacilitiesForm();
            f1.Show();
            this.Hide();
        }

        private void btnDeleteFacilities_Click(object sender, EventArgs e)
        {
            deletefacilitiesForm f2 = new deletefacilitiesForm();
            f2.Show();
            this.Hide();
        }

        private void btnEditFacilities_Click(object sender, EventArgs e)
        {
            
        }
    }
}
