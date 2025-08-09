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

        }

        private void btnSeeFacilities_Click(object sender, EventArgs e)
        {
            grpFacilitiesDetails.Visible = true;
        }

        private void grpFacilitiesDetails_Enter(object sender, EventArgs e)
        {
            grpFacilitiesDetails.Visible = false;
        }
    }
}
