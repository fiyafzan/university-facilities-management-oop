namespace ioopassignment
{
    partial class managerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerForm));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnHandleRequest = new Button();
            btnAssignMaintanance = new Button();
            btnManageFacilities = new Button();
            btnManageUser = new Button();
            btnManageUniversities = new Button();
            btnExitManager = new Button();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(540, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(248, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnHandleRequest
            // 
            btnHandleRequest.BackColor = Color.FromArgb(255, 224, 192);
            btnHandleRequest.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnHandleRequest.Location = new Point(251, 324);
            btnHandleRequest.Name = "btnHandleRequest";
            btnHandleRequest.Size = new Size(253, 36);
            btnHandleRequest.TabIndex = 14;
            btnHandleRequest.Text = "Handle Equipment Request";
            btnHandleRequest.UseVisualStyleBackColor = false;
            btnHandleRequest.Click += btnHandleRequest_Click;
            // 
            // btnAssignMaintanance
            // 
            btnAssignMaintanance.BackColor = Color.FromArgb(255, 224, 192);
            btnAssignMaintanance.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAssignMaintanance.Location = new Point(251, 261);
            btnAssignMaintanance.Name = "btnAssignMaintanance";
            btnAssignMaintanance.Size = new Size(253, 36);
            btnAssignMaintanance.TabIndex = 13;
            btnAssignMaintanance.Text = "Assign Maintenance";
            btnAssignMaintanance.UseVisualStyleBackColor = false;
            btnAssignMaintanance.Click += btnAssignMaintanance_Click;
            // 
            // btnManageFacilities
            // 
            btnManageFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnManageFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnManageFacilities.Location = new Point(251, 200);
            btnManageFacilities.Name = "btnManageFacilities";
            btnManageFacilities.Size = new Size(253, 36);
            btnManageFacilities.TabIndex = 12;
            btnManageFacilities.Text = "Manage facilities";
            btnManageFacilities.UseVisualStyleBackColor = false;
            btnManageFacilities.Click += btnManageFacilities_Click;
            // 
            // btnManageUser
            // 
            btnManageUser.BackColor = Color.FromArgb(255, 224, 192);
            btnManageUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnManageUser.Location = new Point(251, 140);
            btnManageUser.Name = "btnManageUser";
            btnManageUser.Size = new Size(253, 36);
            btnManageUser.TabIndex = 10;
            btnManageUser.Text = "Manage user account";
            btnManageUser.UseVisualStyleBackColor = false;
            btnManageUser.Click += btnManageUser_Click;
            // 
            // btnManageUniversities
            // 
            btnManageUniversities.BackColor = Color.FromArgb(255, 224, 192);
            btnManageUniversities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnManageUniversities.Location = new Point(251, 80);
            btnManageUniversities.Name = "btnManageUniversities";
            btnManageUniversities.Size = new Size(253, 36);
            btnManageUniversities.TabIndex = 17;
            btnManageUniversities.Text = "Manage universities";
            btnManageUniversities.UseVisualStyleBackColor = false;
            btnManageUniversities.Click += btnManageUniversities_Click;
            // 
            // btnExitManager
            // 
            btnExitManager.BackColor = Color.FromArgb(255, 224, 192);
            btnExitManager.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitManager.Location = new Point(592, 336);
            btnExitManager.Name = "btnExitManager";
            btnExitManager.Size = new Size(153, 41);
            btnExitManager.TabIndex = 18;
            btnExitManager.Text = "Exit";
            btnExitManager.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(-2, 3);
            label4.Name = "label4";
            label4.Size = new Size(254, 20);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Manager Dashboard Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(529, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 26);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // managerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnExitManager);
            Controls.Add(btnManageUniversities);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnHandleRequest);
            Controls.Add(btnAssignMaintanance);
            Controls.Add(btnManageFacilities);
            Controls.Add(btnManageUser);
            DoubleBuffered = true;
            Name = "managerForm";
            Text = "managerForm";
            Load += managerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnHandleRequest;
        private Button btnAssignMaintanance;
        private Button btnManageFacilities;
        private Button btnManageUser;
        private Button btnManageUniversities;
        private Button btnExitManager;
        private Label label4;
        private Panel panel1;
    }
}