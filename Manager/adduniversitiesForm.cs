using ioopassignment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioopassignment.Manager
{
    public partial class adduniversitiesForm : Form
    {
        public adduniversitiesForm()
        {
            InitializeComponent();
        }

        private void btnConfirmAddUniversity_Click(object sender, EventArgs e)
        {
            // define adduser as Username, Password, and Role from User class
            University adduniversity = new University(txtAddUniversity.Text);

            // show message box for adduser from addUser(User constructor)
            MessageBox.Show(adduniversity.addUniversity());

            //convert to string from text
            txtAddUniversity.Text = String.Empty;
        }

        private void btnExitAddUniversity_Click(object sender, EventArgs e)
        {
            manageuniversitiesForm f1 = new manageuniversitiesForm();
            f1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void adduniversitiesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
