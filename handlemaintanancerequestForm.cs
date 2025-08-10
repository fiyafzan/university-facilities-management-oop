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
    public partial class handlemaintanancerequestForm : Form
    {
        public handlemaintanancerequestForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDeclineRequest_Click(object sender, EventArgs e)
        {
            declinereasonForm f2 = new declinereasonForm();
            f2.Show();
            this.Hide();
        }

        private void btnExitHandleRequest_Click(object sender, EventArgs e)
        {
            managerForm f1 = new managerForm();
            f1.Show();
            this.Hide();
        }
    }
}
