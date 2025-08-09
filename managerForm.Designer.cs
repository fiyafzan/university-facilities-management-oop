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
            panel1 = new Panel();
            label1 = new Label();
            btnManageUser = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(540, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(248, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 219);
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
            btnHandleRequest.Location = new Point(261, 380);
            btnHandleRequest.Name = "btnHandleRequest";
            btnHandleRequest.Size = new Size(253, 36);
            btnHandleRequest.TabIndex = 14;
            btnHandleRequest.Text = "Handle Maintanance Request";
            btnHandleRequest.UseVisualStyleBackColor = false;
            // 
            // btnAssignMaintanance
            // 
            btnAssignMaintanance.BackColor = Color.FromArgb(255, 224, 192);
            btnAssignMaintanance.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAssignMaintanance.Location = new Point(261, 317);
            btnAssignMaintanance.Name = "btnAssignMaintanance";
            btnAssignMaintanance.Size = new Size(253, 36);
            btnAssignMaintanance.TabIndex = 13;
            btnAssignMaintanance.Text = "Assign Maintanance";
            btnAssignMaintanance.UseVisualStyleBackColor = false;
            // 
            // btnManageFacilities
            // 
            btnManageFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnManageFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnManageFacilities.Location = new Point(261, 256);
            btnManageFacilities.Name = "btnManageFacilities";
            btnManageFacilities.Size = new Size(253, 36);
            btnManageFacilities.TabIndex = 12;
            btnManageFacilities.Text = "Manage facilities";
            btnManageFacilities.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(12, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 125);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 14);
            label1.Name = "label1";
            label1.Size = new Size(573, 90);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Manager";
            // 
            // btnManageUser
            // 
            btnManageUser.BackColor = Color.FromArgb(255, 224, 192);
            btnManageUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnManageUser.Location = new Point(261, 196);
            btnManageUser.Name = "btnManageUser";
            btnManageUser.Size = new Size(253, 36);
            btnManageUser.TabIndex = 10;
            btnManageUser.Text = "Manage user account";
            btnManageUser.UseVisualStyleBackColor = false;
            btnManageUser.Click += btnManageUser_Click;
            // 
            // managerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnHandleRequest);
            Controls.Add(btnAssignMaintanance);
            Controls.Add(btnManageFacilities);
            Controls.Add(panel1);
            Controls.Add(btnManageUser);
            Name = "managerForm";
            Text = "managerForm";
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
        private Panel panel1;
        private Label label1;
        private Button btnManageUser;
    }
}