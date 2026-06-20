namespace iOOP_Receptionist
{
    partial class ARFMSManageStudent
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
            AddBtn = new Button();
            DeleteBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            unibox = new ComboBox();
            label7 = new Label();
            usernametxt = new TextBox();
            label6 = new Label();
            Emailtxt = new TextBox();
            CourseBox = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            Nametxt = new TextBox();
            label4 = new Label();
            StudentIDtxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Searchtxt = new TextBox();
            SearchBtn = new Button();
            groupBox3 = new GroupBox();
            studentsdgv = new DataGridView();
            backbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsdgv).BeginInit();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(11, 29);
            AddBtn.Margin = new Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(144, 29);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(11, 69);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(144, 29);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddBtn);
            groupBox1.Controls.Add(DeleteBtn);
            groupBox1.Location = new Point(265, 228);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(165, 120);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(unibox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(usernametxt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(Emailtxt);
            groupBox2.Controls.Add(CourseBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Nametxt);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(StudentIDtxt);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(22, 102);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(231, 246);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Details";
            // 
            // unibox
            // 
            unibox.FormattingEnabled = true;
            unibox.Location = new Point(96, 196);
            unibox.Margin = new Padding(3, 4, 3, 4);
            unibox.Name = "unibox";
            unibox.Size = new Size(121, 28);
            unibox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 202);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 11;
            label7.Text = "University";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(96, 58);
            usernametxt.Margin = new Padding(3, 4, 3, 4);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(121, 27);
            usernametxt.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 64);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 10;
            label6.Text = "Username:";
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(96, 161);
            Emailtxt.Margin = new Padding(3, 4, 3, 4);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(121, 27);
            Emailtxt.TabIndex = 7;
            Emailtxt.TextChanged += Emailtxt_TextChanged;
            // 
            // CourseBox
            // 
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(96, 125);
            CourseBox.Margin = new Padding(3, 4, 3, 4);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(121, 28);
            CourseBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 166);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 8;
            label5.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 96);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(96, 91);
            Nametxt.Margin = new Padding(3, 4, 3, 4);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(121, 27);
            Nametxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 131);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Course:";
            // 
            // StudentIDtxt
            // 
            StudentIDtxt.Location = new Point(96, 26);
            StudentIDtxt.Margin = new Padding(3, 4, 3, 4);
            StudentIDtxt.Name = "StudentIDtxt";
            StudentIDtxt.Size = new Size(121, 27);
            StudentIDtxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 30);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 5;
            label2.Text = "Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 25);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 4;
            label1.Text = "Manage Students";
            // 
            // Searchtxt
            // 
            Searchtxt.Location = new Point(6, 35);
            Searchtxt.Margin = new Padding(3, 4, 3, 4);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.Size = new Size(149, 27);
            Searchtxt.TabIndex = 6;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(6, 70);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(153, 29);
            SearchBtn.TabIndex = 7;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            SearchBtn.Enter += SearchBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Searchtxt);
            groupBox3.Controls.Add(SearchBtn);
            groupBox3.Location = new Point(265, 102);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(165, 107);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // studentsdgv
            // 
            studentsdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsdgv.Location = new Point(457, 13);
            studentsdgv.Margin = new Padding(3, 4, 3, 4);
            studentsdgv.Name = "studentsdgv";
            studentsdgv.ReadOnly = true;
            studentsdgv.RowHeadersWidth = 51;
            studentsdgv.RowTemplate.Height = 24;
            studentsdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsdgv.Size = new Size(331, 373);
            studentsdgv.TabIndex = 9;
            studentsdgv.CellContentClick += studentsdgv_CellContentClick;
            studentsdgv.SelectionChanged += studentsdgv_SelectionChanged;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(22, 46);
            backbtn.Margin = new Padding(3, 4, 3, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(149, 29);
            backbtn.TabIndex = 10;
            backbtn.Text = "Back to Home";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // ARFMSManageStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ioopassignment.Properties.Resources.reception_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 449);
            Controls.Add(backbtn);
            Controls.Add(studentsdgv);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ARFMSManageStudent";
            Text = "ARFMS Manage Student";
            Load += ARFMSManageStudent_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.ComboBox CourseBox;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox StudentIDtxt;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView studentsdgv;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox unibox;
        private System.Windows.Forms.Label label7;
    }
}