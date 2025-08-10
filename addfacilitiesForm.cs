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
    }
}
