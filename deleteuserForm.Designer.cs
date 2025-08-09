namespace ioopassignment
{
    partial class deleteuserForm
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
            panel1 = new Panel();
            label1 = new Label();
            btnExitDeleteUser = new Button();
            btnConfirmDeleteUser = new Button();
            grpUserDetails2 = new GroupBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 45);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(303, 31);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Delete User Form";
            label1.Click += label1_Click;
            // 
            // btnExitDeleteUser
            // 
            btnExitDeleteUser.BackColor = Color.FromArgb(255, 224, 192);
            btnExitDeleteUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitDeleteUser.Location = new Point(410, 361);
            btnExitDeleteUser.Name = "btnExitDeleteUser";
            btnExitDeleteUser.Size = new Size(153, 41);
            btnExitDeleteUser.TabIndex = 16;
            btnExitDeleteUser.Text = "Exit";
            btnExitDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnConfirmDeleteUser
            // 
            btnConfirmDeleteUser.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmDeleteUser.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmDeleteUser.Location = new Point(220, 361);
            btnConfirmDeleteUser.Name = "btnConfirmDeleteUser";
            btnConfirmDeleteUser.Size = new Size(153, 41);
            btnConfirmDeleteUser.TabIndex = 15;
            btnConfirmDeleteUser.Text = "Confirm Delete";
            btnConfirmDeleteUser.UseVisualStyleBackColor = false;
            // 
            // grpUserDetails2
            // 
            grpUserDetails2.BackColor = Color.White;
            grpUserDetails2.Location = new Point(90, 70);
            grpUserDetails2.Name = "grpUserDetails2";
            grpUserDetails2.Size = new Size(590, 285);
            grpUserDetails2.TabIndex = 14;
            grpUserDetails2.TabStop = false;
            grpUserDetails2.Text = "User Details";
            // 
            // deleteuserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 425);
            Controls.Add(btnExitDeleteUser);
            Controls.Add(btnConfirmDeleteUser);
            Controls.Add(grpUserDetails2);
            Controls.Add(panel1);
            Name = "deleteuserForm";
            Text = "deleteuserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnExitDeleteUser;
        private Button btnConfirmDeleteUser;
        private GroupBox grpUserDetails2;
    }
}