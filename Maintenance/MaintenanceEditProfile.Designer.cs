namespace iOOP_Receptionist
{
    partial class MaintenanceEditProfile
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
            label1 = new Label();
            label6 = new Label();
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            updatebtn = new Button();
            backbtn = new Button();
            label2 = new Label();
            useridlbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 186);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 220);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Password:";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(307, 181);
            usernametxt.Margin = new Padding(3, 4, 3, 4);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(205, 27);
            usernametxt.TabIndex = 6;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(307, 216);
            passwordtxt.Margin = new Padding(3, 4, 3, 4);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(205, 27);
            passwordtxt.TabIndex = 12;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(265, 268);
            updatebtn.Margin = new Padding(3, 4, 3, 4);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(75, 29);
            updatebtn.TabIndex = 13;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(378, 268);
            backbtn.Margin = new Padding(3, 4, 3, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(75, 29);
            backbtn.TabIndex = 14;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 157);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 15;
            label2.Text = "User ID:";
            label2.Click += label2_Click;
            // 
            // useridlbl
            // 
            useridlbl.AutoSize = true;
            useridlbl.Location = new Point(304, 157);
            useridlbl.Name = "useridlbl";
            useridlbl.Size = new Size(66, 20);
            useridlbl.TabIndex = 16;
            useridlbl.Text = "useridlbl";
            // 
            // MaintenanceEditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ioopassignment.Properties.Resources.maintenance_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 448);
            Controls.Add(useridlbl);
            Controls.Add(label2);
            Controls.Add(backbtn);
            Controls.Add(updatebtn);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(label6);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MaintenanceEditProfile";
            Text = "MaintenanceEditProfile";
            Load += MaintenanceEditProfile_Load_1;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label useridlbl;
    }
}