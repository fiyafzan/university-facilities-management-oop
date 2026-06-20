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

namespace iOOP_Receptionist
{
    public partial class ARFMSLogin : Form
    {
        public ARFMSLogin()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string stat;
            User obj1 = new User(usernametxt.Text, passwordtxt.Text);
            stat = obj1.Login(this, usernametxt.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            usernametxt.Text=string.Empty;
            passwordtxt.Text=string.Empty;
        }

        private void ARFMSLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
