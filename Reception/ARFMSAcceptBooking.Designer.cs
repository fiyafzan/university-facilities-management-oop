namespace iOOP_Receptionist
{
    partial class ARFMSAcceptBooking
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
            Searchtxt = new TextBox();
            SearchBtn = new Button();
            groupBox1 = new GroupBox();
            studentidlbl = new Label();
            paymentstatuslbl = new Label();
            namelbl = new Label();
            pricelbl = new Label();
            label10 = new Label();
            facilitylbl = new Label();
            availabilitylbl = new Label();
            datelbl = new Label();
            timelbl = new Label();
            rejectbtn = new Button();
            label2 = new Label();
            approvebtn = new Button();
            label3 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            backbtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(542, 19);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 0;
            label1.Text = "Booking Request";
            // 
            // Searchtxt
            // 
            Searchtxt.Location = new Point(61, 190);
            Searchtxt.Margin = new Padding(3, 4, 3, 4);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.Size = new Size(154, 27);
            Searchtxt.TabIndex = 0;
            Searchtxt.Text = "Search by Booking ID";
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(100, 225);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 29);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(studentidlbl);
            groupBox1.Controls.Add(paymentstatuslbl);
            groupBox1.Controls.Add(namelbl);
            groupBox1.Controls.Add(pricelbl);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(facilitylbl);
            groupBox1.Controls.Add(availabilitylbl);
            groupBox1.Controls.Add(datelbl);
            groupBox1.Controls.Add(timelbl);
            groupBox1.Controls.Add(rejectbtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(approvebtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(286, 48);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 335);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Booking Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // studentidlbl
            // 
            studentidlbl.AutoSize = true;
            studentidlbl.Location = new Point(104, 41);
            studentidlbl.Name = "studentidlbl";
            studentidlbl.Size = new Size(0, 20);
            studentidlbl.TabIndex = 13;
            // 
            // paymentstatuslbl
            // 
            paymentstatuslbl.AutoSize = true;
            paymentstatuslbl.Location = new Point(104, 246);
            paymentstatuslbl.Name = "paymentstatuslbl";
            paymentstatuslbl.Size = new Size(0, 20);
            paymentstatuslbl.TabIndex = 3;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Location = new Point(104, 71);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(0, 20);
            namelbl.TabIndex = 14;
            // 
            // pricelbl
            // 
            pricelbl.AutoSize = true;
            pricelbl.Location = new Point(104, 221);
            pricelbl.Name = "pricelbl";
            pricelbl.Size = new Size(0, 20);
            pricelbl.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 246);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 1;
            label10.Text = "Payment Status:";
            // 
            // facilitylbl
            // 
            facilitylbl.AutoSize = true;
            facilitylbl.Location = new Point(104, 101);
            facilitylbl.Name = "facilitylbl";
            facilitylbl.Size = new Size(0, 20);
            facilitylbl.TabIndex = 15;
            // 
            // availabilitylbl
            // 
            availabilitylbl.AutoSize = true;
            availabilitylbl.Location = new Point(104, 191);
            availabilitylbl.Name = "availabilitylbl";
            availabilitylbl.Size = new Size(0, 20);
            availabilitylbl.TabIndex = 18;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Location = new Point(104, 131);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(0, 20);
            datelbl.TabIndex = 16;
            // 
            // timelbl
            // 
            timelbl.AutoSize = true;
            timelbl.Location = new Point(104, 161);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(0, 20);
            timelbl.TabIndex = 17;
            // 
            // rejectbtn
            // 
            rejectbtn.Location = new Point(117, 285);
            rejectbtn.Margin = new Padding(3, 4, 3, 4);
            rejectbtn.Name = "rejectbtn";
            rejectbtn.Size = new Size(75, 29);
            rejectbtn.TabIndex = 12;
            rejectbtn.Text = "Reject";
            rejectbtn.UseVisualStyleBackColor = true;
            rejectbtn.Click += rejectbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Student ID:";
            // 
            // approvebtn
            // 
            approvebtn.Location = new Point(36, 285);
            approvebtn.Margin = new Padding(3, 4, 3, 4);
            approvebtn.Name = "approvebtn";
            approvebtn.Size = new Size(75, 29);
            approvebtn.TabIndex = 11;
            approvebtn.Text = "Approve";
            approvebtn.UseVisualStyleBackColor = true;
            approvebtn.Click += approvebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 71);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "Name: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 221);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 10;
            label8.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 101);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Facility:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 191);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 9;
            label7.Text = "Availability:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 131);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 7;
            label5.Text = "Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 161);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 8;
            label6.Text = "Time:";
            // 
            // backbtn
            // 
            backbtn.Location = new Point(37, 48);
            backbtn.Margin = new Padding(3, 4, 3, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(149, 29);
            backbtn.TabIndex = 12;
            backbtn.Text = "Back to Home";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // ARFMSAcceptBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ioopassignment.Properties.Resources.reception_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 451);
            Controls.Add(backbtn);
            Controls.Add(groupBox1);
            Controls.Add(SearchBtn);
            Controls.Add(Searchtxt);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ARFMSAcceptBooking";
            Text = "ARFMS Accept Booking";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label studentidlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label facilitylbl;
        private System.Windows.Forms.Label availabilitylbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Button rejectbtn;
        private System.Windows.Forms.Button approvebtn;
        private System.Windows.Forms.Label paymentstatuslbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button backbtn;
    }
}