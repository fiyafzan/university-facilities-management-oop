namespace ioopassignment.Manager
{
    partial class manageuniversitiesForm
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
            btnSeeUniversity = new Button();
            panel1 = new Panel();
            label1 = new Label();
            grpUserDetails = new GroupBox();
            dataUniversityDetails = new DataGridView();
            btnExitManageUser = new Button();
            btnDeleteUniversity = new Button();
            btnAddUniversity = new Button();
            panel1.SuspendLayout();
            grpUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUniversityDetails).BeginInit();
            SuspendLayout();
            // 
            // btnSeeUniversity
            // 
            btnSeeUniversity.BackColor = Color.FromArgb(255, 224, 192);
            btnSeeUniversity.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSeeUniversity.Location = new Point(433, 19);
            btnSeeUniversity.Name = "btnSeeUniversity";
            btnSeeUniversity.Size = new Size(89, 35);
            btnSeeUniversity.TabIndex = 19;
            btnSeeUniversity.Text = "See";
            btnSeeUniversity.UseVisualStyleBackColor = false;
            btnSeeUniversity.Click += btnSeeUser_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(528, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 32);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Manage University Form";
            // 
            // grpUserDetails
            // 
            grpUserDetails.BackColor = Color.White;
            grpUserDetails.Controls.Add(dataUniversityDetails);
            grpUserDetails.Location = new Point(98, 63);
            grpUserDetails.Name = "grpUserDetails";
            grpUserDetails.Size = new Size(590, 285);
            grpUserDetails.TabIndex = 17;
            grpUserDetails.TabStop = false;
            grpUserDetails.Text = "University Details";
            // 
            // dataUniversityDetails
            // 
            dataUniversityDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUniversityDetails.Location = new Point(16, 36);
            dataUniversityDetails.Name = "dataUniversityDetails";
            dataUniversityDetails.RowHeadersWidth = 51;
            dataUniversityDetails.Size = new Size(560, 230);
            dataUniversityDetails.TabIndex = 0;
            dataUniversityDetails.CellContentClick += dataUniversityDetails_CellContentClick;
            // 
            // btnExitManageUser
            // 
            btnExitManageUser.BackColor = Color.FromArgb(255, 224, 192);
            btnExitManageUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitManageUser.Location = new Point(506, 354);
            btnExitManageUser.Name = "btnExitManageUser";
            btnExitManageUser.Size = new Size(153, 41);
            btnExitManageUser.TabIndex = 16;
            btnExitManageUser.Text = "Exit";
            btnExitManageUser.UseVisualStyleBackColor = false;
            btnExitManageUser.Click += btnExitManageUser_Click;
            // 
            // btnDeleteUniversity
            // 
            btnDeleteUniversity.BackColor = Color.FromArgb(255, 224, 192);
            btnDeleteUniversity.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnDeleteUniversity.Location = new Point(316, 354);
            btnDeleteUniversity.Name = "btnDeleteUniversity";
            btnDeleteUniversity.Size = new Size(153, 41);
            btnDeleteUniversity.TabIndex = 15;
            btnDeleteUniversity.Text = "Delete";
            btnDeleteUniversity.UseVisualStyleBackColor = false;
            btnDeleteUniversity.Click += btnDeleteUser_Click;
            // 
            // btnAddUniversity
            // 
            btnAddUniversity.BackColor = Color.FromArgb(255, 224, 192);
            btnAddUniversity.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAddUniversity.Location = new Point(131, 354);
            btnAddUniversity.Name = "btnAddUniversity";
            btnAddUniversity.Size = new Size(153, 41);
            btnAddUniversity.TabIndex = 14;
            btnAddUniversity.Text = "Add";
            btnAddUniversity.UseVisualStyleBackColor = false;
            btnAddUniversity.Click += btnAddUser_Click;
            // 
            // manageuniversitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeeUniversity);
            Controls.Add(panel1);
            Controls.Add(grpUserDetails);
            Controls.Add(btnExitManageUser);
            Controls.Add(btnDeleteUniversity);
            Controls.Add(btnAddUniversity);
            DoubleBuffered = true;
            Name = "manageuniversitiesForm";
            Text = "manageuniversitiesForm";
            Load += manageuniversitiesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpUserDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataUniversityDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSeeUniversity;
        private Panel panel1;
        private Label label1;
        private GroupBox grpUserDetails;
        private DataGridView dataUniversityDetails;
        private Button btnExitManageUser;
        private Button btnDeleteUniversity;
        private Button btnAddUniversity;
    }
}