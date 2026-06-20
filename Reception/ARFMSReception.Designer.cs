namespace iOOP_Receptionist
{
    partial class ReceptionForm
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
            ManageStudentBtn = new Button();
            SearchBookingBtn = new Button();
            AcceptBookingBtn = new Button();
            ViewRatingBtn = new Button();
            backbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 56);
            label1.Name = "label1";
            label1.Size = new Size(303, 38);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Reception";
            // 
            // ManageStudentBtn
            // 
            ManageStudentBtn.BackColor = SystemColors.Control;
            ManageStudentBtn.Location = new Point(277, 121);
            ManageStudentBtn.Margin = new Padding(3, 4, 3, 4);
            ManageStudentBtn.Name = "ManageStudentBtn";
            ManageStudentBtn.Size = new Size(212, 40);
            ManageStudentBtn.TabIndex = 1;
            ManageStudentBtn.Text = "Manage Student";
            ManageStudentBtn.UseVisualStyleBackColor = false;
            ManageStudentBtn.Click += ManageStudentBtn_Click;
            // 
            // SearchBookingBtn
            // 
            SearchBookingBtn.BackColor = SystemColors.Control;
            SearchBookingBtn.Location = new Point(277, 193);
            SearchBookingBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBookingBtn.Name = "SearchBookingBtn";
            SearchBookingBtn.Size = new Size(212, 40);
            SearchBookingBtn.TabIndex = 2;
            SearchBookingBtn.Text = "Search Existing Bookings";
            SearchBookingBtn.UseVisualStyleBackColor = false;
            SearchBookingBtn.Click += SearchBookingBtn_Click;
            // 
            // AcceptBookingBtn
            // 
            AcceptBookingBtn.BackColor = SystemColors.Control;
            AcceptBookingBtn.Location = new Point(277, 264);
            AcceptBookingBtn.Margin = new Padding(3, 4, 3, 4);
            AcceptBookingBtn.Name = "AcceptBookingBtn";
            AcceptBookingBtn.Size = new Size(212, 40);
            AcceptBookingBtn.TabIndex = 3;
            AcceptBookingBtn.Text = "Accept Bookings";
            AcceptBookingBtn.UseVisualStyleBackColor = false;
            AcceptBookingBtn.Click += AcceptBookingBtn_Click;
            // 
            // ViewRatingBtn
            // 
            ViewRatingBtn.BackColor = SystemColors.Control;
            ViewRatingBtn.Location = new Point(277, 335);
            ViewRatingBtn.Margin = new Padding(3, 4, 3, 4);
            ViewRatingBtn.Name = "ViewRatingBtn";
            ViewRatingBtn.Size = new Size(212, 40);
            ViewRatingBtn.TabIndex = 5;
            ViewRatingBtn.Text = "View Ratings";
            ViewRatingBtn.UseVisualStyleBackColor = false;
            ViewRatingBtn.Click += ViewRatingBtn_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.Control;
            backbtn.Location = new Point(549, 406);
            backbtn.Margin = new Padding(3, 4, 3, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(191, 40);
            backbtn.TabIndex = 6;
            backbtn.Text = "Back to Login";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // ReceptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ioopassignment.Properties.Resources.reception_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 452);
            Controls.Add(backbtn);
            Controls.Add(ViewRatingBtn);
            Controls.Add(AcceptBookingBtn);
            Controls.Add(SearchBookingBtn);
            Controls.Add(ManageStudentBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReceptionForm";
            Text = "ARFMS Reception";
            Load += ReceptionForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageStudentBtn;
        private System.Windows.Forms.Button SearchBookingBtn;
        private System.Windows.Forms.Button AcceptBookingBtn;
        private System.Windows.Forms.Button ViewRatingBtn;
        private System.Windows.Forms.Button backbtn;
    }
}

