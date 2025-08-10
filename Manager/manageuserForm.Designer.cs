namespace ioopassignment
{
    partial class manageuserForm
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
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            btnExitManageUser = new Button();
            grpUserDetails = new GroupBox();
            panel1 = new Panel();
            label1 = new Label();
            btnSeeUser = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(255, 224, 192);
            btnAddUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAddUser.Location = new Point(127, 382);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(153, 41);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += button1_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(255, 224, 192);
            btnDeleteUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnDeleteUser.Location = new Point(312, 382);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(153, 41);
            btnDeleteUser.TabIndex = 1;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnExitManageUser
            // 
            btnExitManageUser.BackColor = Color.FromArgb(255, 224, 192);
            btnExitManageUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitManageUser.Location = new Point(502, 382);
            btnExitManageUser.Name = "btnExitManageUser";
            btnExitManageUser.Size = new Size(153, 41);
            btnExitManageUser.TabIndex = 3;
            btnExitManageUser.Text = "Exit";
            btnExitManageUser.UseVisualStyleBackColor = false;
            btnExitManageUser.Click += btnExitManageUser_Click;
            // 
            // grpUserDetails
            // 
            grpUserDetails.BackColor = Color.White;
            grpUserDetails.Location = new Point(96, 71);
            grpUserDetails.Name = "grpUserDetails";
            grpUserDetails.Size = new Size(590, 285);
            grpUserDetails.TabIndex = 4;
            grpUserDetails.TabStop = false;
            grpUserDetails.Text = "User Details";
            grpUserDetails.Enter += grpUserDetails_Enter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 45);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(317, 31);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Manage User Form";
            // 
            // btnSeeUser
            // 
            btnSeeUser.BackColor = Color.FromArgb(255, 224, 192);
            btnSeeUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSeeUser.Location = new Point(354, 12);
            btnSeeUser.Name = "btnSeeUser";
            btnSeeUser.Size = new Size(89, 35);
            btnSeeUser.TabIndex = 13;
            btnSeeUser.Text = "See";
            btnSeeUser.UseVisualStyleBackColor = false;
            btnSeeUser.Click += btnSeeUser_Click;
            // 
            // manageuserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeeUser);
            Controls.Add(panel1);
            Controls.Add(grpUserDetails);
            Controls.Add(btnExitManageUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Name = "manageuserForm";
            Text = "manageuserForm";
            Load += manageuserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnDeleteUser;
        private Button btnExitManageUser;
        private GroupBox grpUserDetails;
        private Panel panel1;
        private Label label1;
        private Button btnSeeUser;
    }
}