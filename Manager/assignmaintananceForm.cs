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
    public partial class assignmaintananceForm : Form
    {
        public assignmaintananceForm()
        {
            InitializeComponent();
        }

        private void btnAssignMaintanance_Click(object sender, EventArgs e)
        {
            assignmaintanance2Form f2 = new assignmaintanance2Form();
            f2.Show();
            this.Hide();
        }

        private void btnExitAssignMaintanace_Click(object sender, EventArgs e)
        {
            managerForm f1 = new managerForm();
            f1.Show();
            this.Hide();
        }
    }
}
