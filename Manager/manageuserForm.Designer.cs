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
            dataUserDetails = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            btnSeeUser = new Button();
            grpUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUserDetails).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(255, 224, 192);
            btnAddUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAddUser.Location = new Point(130, 354);
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
            btnDeleteUser.Location = new Point(315, 354);
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
            btnExitManageUser.Location = new Point(505, 354);
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
            grpUserDetails.Controls.Add(dataUserDetails);
            grpUserDetails.Location = new Point(97, 63);
            grpUserDetails.Name = "grpUserDetails";
            grpUserDetails.Size = new Size(590, 285);
            grpUserDetails.TabIndex = 4;
            grpUserDetails.TabStop = false;
            grpUserDetails.Text = "User Details";
            grpUserDetails.Enter += grpUserDetails_Enter;
            // 
            // dataUserDetails
            // 
            dataUserDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUserDetails.Location = new Point(16, 36);
            dataUserDetails.Name = "dataUserDetails";
            dataUserDetails.RowHeadersWidth = 51;
            dataUserDetails.Size = new Size(560, 230);
            dataUserDetails.TabIndex = 0;
            dataUserDetails.CellContentClick += dataUserDetails_CellContentClick_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(577, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 32);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(203, 20);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Manage User Form";
            // 
            // btnSeeUser
            // 
            btnSeeUser.BackColor = Color.FromArgb(255, 224, 192);
            btnSeeUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSeeUser.Location = new Point(482, 16);
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
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeeUser);
            Controls.Add(panel1);
            Controls.Add(grpUserDetails);
            Controls.Add(btnExitManageUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            DoubleBuffered = true;
            Name = "manageuserForm";
            Text = "manageuserForm";
            Load += manageuserForm_Load;
            grpUserDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataUserDetails).EndInit();
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
        private DataGridView dataUserDetails;
    }
}