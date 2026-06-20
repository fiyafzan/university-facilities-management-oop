namespace ioopassignment
{
    partial class MaintainanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainanceForm));
            btnViewSchedule = new Button();
            btnUpdateStatus = new Button();
            btnEquipmentRequest = new Button();
            btnReplacementRequest = new Button();
            btnMaintainanceProfile = new Button();
            pictureBox1 = new PictureBox();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnViewSchedule
            // 
            btnViewSchedule.Location = new Point(62, 167);
            btnViewSchedule.Name = "btnViewSchedule";
            btnViewSchedule.Size = new Size(158, 29);
            btnViewSchedule.TabIndex = 0;
            btnViewSchedule.Text = "View Schedule";
            btnViewSchedule.UseVisualStyleBackColor = true;
            btnViewSchedule.Click += btnViewSchedule_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(62, 266);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(158, 29);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnEquipmentRequest
            // 
            btnEquipmentRequest.Location = new Point(577, 167);
            btnEquipmentRequest.Name = "btnEquipmentRequest";
            btnEquipmentRequest.Size = new Size(163, 29);
            btnEquipmentRequest.TabIndex = 2;
            btnEquipmentRequest.Text = "Equipment Request";
            btnEquipmentRequest.UseVisualStyleBackColor = true;
            btnEquipmentRequest.Click += btnEquipmentRequest_Click;
            // 
            // btnReplacementRequest
            // 
            btnReplacementRequest.Location = new Point(577, 266);
            btnReplacementRequest.Name = "btnReplacementRequest";
            btnReplacementRequest.Size = new Size(163, 29);
            btnReplacementRequest.TabIndex = 3;
            btnReplacementRequest.Text = "Replacement Request";
            btnReplacementRequest.UseVisualStyleBackColor = true;
            btnReplacementRequest.Click += button4_Click;
            // 
            // btnMaintainanceProfile
            // 
            btnMaintainanceProfile.Location = new Point(341, 345);
            btnMaintainanceProfile.Name = "btnMaintainanceProfile";
            btnMaintainanceProfile.Size = new Size(94, 29);
            btnMaintainanceProfile.TabIndex = 4;
            btnMaintainanceProfile.Text = "Edit Profile";
            btnMaintainanceProfile.UseVisualStyleBackColor = true;
            btnMaintainanceProfile.Click += btnMaintainanceProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.Location = new Point(627, 414);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 24;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // MaintainanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maintenance_dashboard_form;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(pictureBox1);
            Controls.Add(btnMaintainanceProfile);
            Controls.Add(btnReplacementRequest);
            Controls.Add(btnEquipmentRequest);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnViewSchedule);
            DoubleBuffered = true;
            Name = "MaintainanceForm";
            Text = "MaintainanceForm";
            Load += MaintainanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewSchedule;
        private Button btnUpdateStatus;
        private Button btnEquipmentRequest;
        private Button btnReplacementRequest;
        private Button btnMaintainanceProfile;
        private PictureBox pictureBox1;
        private Button Exit;
    }
}