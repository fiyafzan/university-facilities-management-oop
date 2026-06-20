namespace ioopassignment
{
    partial class EditProfile
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
            btnback = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtCourseID = new TextBox();
            label6 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtUniID = new TextBox();
            btnUpdatePrf = new Button();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Location = new Point(380, 354);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 7;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += EditProfileBackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 67);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 117);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 164);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 10;
            label3.Text = "Course ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 213);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 11;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 261);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 12;
            label5.Text = "Password:";
            // 
            // txtName
            // 
            txtName.Location = new Point(224, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(224, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(224, 164);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(250, 27);
            txtCourseID.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 304);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 18;
            label6.Text = "Uni ID:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(224, 213);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 19;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(224, 258);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 20;
            // 
            // txtUniID
            // 
            txtUniID.Location = new Point(224, 304);
            txtUniID.Name = "txtUniID";
            txtUniID.Size = new Size(250, 27);
            txtUniID.TabIndex = 21;
            // 
            // btnUpdatePrf
            // 
            btnUpdatePrf.Location = new Point(224, 354);
            btnUpdatePrf.Name = "btnUpdatePrf";
            btnUpdatePrf.Size = new Size(94, 29);
            btnUpdatePrf.TabIndex = 22;
            btnUpdatePrf.Text = "Update";
            btnUpdatePrf.UseVisualStyleBackColor = true;
            btnUpdatePrf.Click += btnUpdatePrf_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gray_Peach_Purple_Green_Modern_Product_Launch_Plan_Presentation;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdatePrf);
            Controls.Add(txtUniID);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(txtCourseID);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnback);
            DoubleBuffered = true;
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnback;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtCourseID;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtUniID;
        private Button btnUpdatePrf;
    }
}