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
    public partial class manageuserForm : Form
    {
        public manageuserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adduserForm f2 = new adduserForm();
            f2.Show();
            this.Hide();
        }

        private void grpUserDetails_Enter(object sender, EventArgs e)
        {
            grpUserDetails.Visible = false;
        }

        private void btnSeeUser_Click(object sender, EventArgs e)
        {
            grpUserDetails.Visible = true;
        }

        private void manageuserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExitManageUser_Click(object sender, EventArgs e)
        {
            managerForm f1 = new managerForm();
            f1.Show();
            this.Hide();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            deleteuserForm f3 = new deleteuserForm();
            f3.Show();
            this.Hide();
        }
    }
}
