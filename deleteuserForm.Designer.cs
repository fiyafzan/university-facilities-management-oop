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
            grpUserDetails = new GroupBox();
            btnExitDeleteUser = new Button();
            btnConfirmDelete = new Button();
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
            // grpUserDetails
            // 
            grpUserDetails.BackColor = Color.White;
            grpUserDetails.Location = new Point(90, 70);
            grpUserDetails.Name = "grpUserDetails";
            grpUserDetails.Size = new Size(590, 285);
            grpUserDetails.TabIndex = 14;
            grpUserDetails.TabStop = false;
            grpUserDetails.Text = "User Details";
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
            // btnConfirmDelete
            // 
            btnConfirmDelete.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmDelete.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmDelete.Location = new Point(220, 361);
            btnConfirmDelete.Name = "btnConfirmDelete";
            btnConfirmDelete.Size = new Size(153, 41);
            btnConfirmDelete.TabIndex = 15;
            btnConfirmDelete.Text = "Confirm Delete";
            btnConfirmDelete.UseVisualStyleBackColor = false;
            // 
            // deleteuserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 425);
            Controls.Add(btnExitDeleteUser);
            Controls.Add(btnConfirmDelete);
            Controls.Add(grpUserDetails);
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
        private GroupBox grpUserDetails;
        private Button btnExitDeleteUser;
        private Button btnConfirmDelete;
    }
}