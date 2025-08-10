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
    public partial class deletefacilitiesForm : Form
    {
        public deletefacilitiesForm()
        {
            InitializeComponent();
        }

        private void btnExitDeleteFacilities_Click(object sender, EventArgs e)
        {
            managefacilitiesForm f1 = new managefacilitiesForm();
            f1.Show();
            this.Hide();
        }
    }
}
