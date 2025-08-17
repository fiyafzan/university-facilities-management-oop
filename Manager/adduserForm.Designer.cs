namespace ioopassignment
{
    partial class adduserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adduserForm));
            btnExitAddUser = new Button();
            btnConfirmAddUser = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAddUsername = new TextBox();
            txtAddPassword = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            cboRole = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnExitAddUser
            // 
            btnExitAddUser.BackColor = Color.FromArgb(255, 224, 192);
            btnExitAddUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitAddUser.Location = new Point(404, 325);
            btnExitAddUser.Name = "btnExitAddUser";
            btnExitAddUser.Size = new Size(153, 41);
            btnExitAddUser.TabIndex = 5;
            btnExitAddUser.Text = "Exit";
            btnExitAddUser.UseVisualStyleBackColor = false;
            btnExitAddUser.Click += btnExitAddUser_Click;
            // 
            // btnConfirmAddUser
            // 
            btnConfirmAddUser.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmAddUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmAddUser.Location = new Point(245, 325);
            btnConfirmAddUser.Name = "btnConfirmAddUser";
            btnConfirmAddUser.Size = new Size(153, 41);
            btnConfirmAddUser.TabIndex = 4;
            btnConfirmAddUser.Text = "Confirm Add";
            btnConfirmAddUser.UseVisualStyleBackColor = false;
            btnConfirmAddUser.Click += btnConfirmAddUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 6;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 100);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 7;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 160);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 8;
            label3.Text = "Role :";
            // 
            // txtAddUsername
            // 
            txtAddUsername.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddUsername.Location = new Point(190, 50);
            txtAddUsername.Name = "txtAddUsername";
            txtAddUsername.Size = new Size(151, 26);
            txtAddUsername.TabIndex = 9;
            // 
            // txtAddPassword
            // 
            txtAddPassword.Font = new Font("Roboto", 9F);
            txtAddPassword.Location = new Point(190, 105);
            txtAddPassword.Name = "txtAddPassword";
            txtAddPassword.Size = new Size(151, 26);
            txtAddPassword.TabIndex = 10;
            txtAddPassword.TextChanged += txtAddPassword_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(605, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 33);
            panel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Add User Form";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(cboRole);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtAddPassword);
            panel2.Controls.Add(txtAddUsername);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(212, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 237);
            panel2.TabIndex = 14;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(190, 166);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(151, 28);
            cboRole.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(603, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // adduserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExitAddUser);
            Controls.Add(btnConfirmAddUser);
            DoubleBuffered = true;
            Name = "adduserForm";
            Text = "adduserForm";
            Load += adduserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExitAddUser;
        private Button btnConfirmAddUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAddUsername;
        private TextBox txtAddPassword;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cboRole;
    }
}