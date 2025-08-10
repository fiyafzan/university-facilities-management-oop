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
    public partial class deleteuserForm : Form
    {
        public deleteuserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitDeleteUser_Click(object sender, EventArgs e)
        {
            manageuserForm f1 = new manageuserForm();
            f1.Show();
            this.Hide();
        }
    }
}
