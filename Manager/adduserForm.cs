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
            // to go to the form before
            manageuserForm f1 = new manageuserForm();
            f1.Show();
            this.Hide();
        }

        private void btnConfirmAddUser_Click(object sender, EventArgs e)
        {
            // define adduser as Username, Password, and Role from User class
            User adduser = new User(txtAddUsername.Text, txtAddPassword.Text, cboRole.SelectedItem.ToString());

            // show message box for adduser from addUser(User constructor)
            MessageBox.Show(adduser.addUser());

            //convert to string from text
            txtAddUsername.Text = String.Empty;
            txtAddPassword.Text = String.Empty;
        }

        private void adduserForm_Load(object sender, EventArgs e)
        {
            if (cboRole != null) // ensure it's not null
            {
                cboRole.Items.Clear();
                cboRole.Items.Add("manager");
                cboRole.Items.Add("receptionist");
                cboRole.Items.Add("maintenance");
                cboRole.SelectedIndex = 0; // set default selection
            }
        }

        private void txtAddRole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
