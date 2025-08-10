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
    public partial class adduserForm : Form
    {
        public adduserForm()
        {
            InitializeComponent();
        }

        private void txtAddPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitAddUser_Click(object sender, EventArgs e)
        {
            manageuserForm f1 = new manageuserForm();
            f1.Show();
            this.Hide();
        }

        private void btnConfirmAddUser_Click(object sender, EventArgs e)
        {
            User adduser = new User( txtAddUsername.Text, txtAddPassword.Text, txtAddRole.Text );
            MessageBox.Show(adduser.addUser());
            txtAddUsername.Text = String.Empty;
            txtAddPassword.Text = String.Empty;
            txtAddRole.Text = String.Empty;

            this.Close();
        }
    }
}
