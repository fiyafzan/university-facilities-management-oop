using ioopassignment.Manager;
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
    public partial class managerForm : Form
    {
        public managerForm()
        {
            InitializeComponent();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            manageuserForm f2 = new manageuserForm();
            f2.Show();
            this.Hide();
        }

        private void btnManageFacilities_Click(object sender, EventArgs e)
        {
            managefacilitiesForm f3 = new managefacilitiesForm();
            f3.Show();
            this.Hide();
        }

        private void btnAssignMaintanance_Click(object sender, EventArgs e)
        {
            assignmaintananceForm f4 = new assignmaintananceForm();
            f4.Show();
            this.Hide();
        }

        private void btnHandleRequest_Click(object sender, EventArgs e)
        {
            handlemaintanancerequestForm f5 = new handlemaintanancerequestForm();
            f5.Show();
            this.Hide();
        }

        private void managerForm_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnManageUniversities_Click(object sender, EventArgs e)
        {
            manageuniversitiesForm f1 = new manageuniversitiesForm();
            f1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
