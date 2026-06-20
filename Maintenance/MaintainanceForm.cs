using iOOP_Receptionist;
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
    public partial class MaintainanceForm : Form
    {
        private int userId;
        public MaintainanceForm()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MaintainanceReplacementRequest repairForm = new MaintainanceReplacementRequest();
            repairForm.Show();
            this.Hide();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            MaintainanceViewSchedule scheduleForm = new MaintainanceViewSchedule();
            scheduleForm.Show();
            this.Hide();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            MaintainanceUpdateStatus statusForm = new MaintainanceUpdateStatus();
            statusForm.Show();
            this.Hide();
        }

        private void btnEquipmentRequest_Click(object sender, EventArgs e)
        {
            MaintainanceEquipmentRequest reqForm = new MaintainanceEquipmentRequest();
            reqForm.Show();
            this.Hide();
        }

        private void btnMaintainanceProfile_Click(object sender, EventArgs e)
        {
            MaintenanceEditProfile profileForm = new MaintenanceEditProfile(0);
            profileForm.Show();
            this.Hide();
        }

        private void MaintainanceForm_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ARFMSLogin aRFMSLogin = new ARFMSLogin();
            aRFMSLogin.Show();
            this.Hide();
        }
    }
}
