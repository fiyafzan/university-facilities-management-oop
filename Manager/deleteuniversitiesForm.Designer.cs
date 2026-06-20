namespace ioopassignment.Manager
{
    partial class deleteuniversitiesForm
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
            btnExitDeleteUniversity = new Button();
            btnConfirmDeleteUniversity = new Button();
            grpUserDetails2 = new GroupBox();
            dataUniversityDetails2 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            grpUserDetails2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUniversityDetails2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExitDeleteUniversity
            // 
            btnExitDeleteUniversity.BackColor = Color.FromArgb(255, 224, 192);
            btnExitDeleteUniversity.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitDeleteUniversity.Location = new Point(412, 336);
            btnExitDeleteUniversity.Name = "btnExitDeleteUniversity";
            btnExitDeleteUniversity.Size = new Size(153, 41);
            btnExitDeleteUniversity.TabIndex = 20;
            btnExitDeleteUniversity.Text = "Exit";
            btnExitDeleteUniversity.UseVisualStyleBackColor = false;
            btnExitDeleteUniversity.Click += btnExitDeleteUniversity_Click;
            // 
            // btnConfirmDeleteUniversity
            // 
            btnConfirmDeleteUniversity.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmDeleteUniversity.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmDeleteUniversity.Location = new Point(222, 336);
            btnConfirmDeleteUniversity.Name = "btnConfirmDeleteUniversity";
            btnConfirmDeleteUniversity.Size = new Size(153, 41);
            btnConfirmDeleteUniversity.TabIndex = 19;
            btnConfirmDeleteUniversity.Text = "Confirm Delete";
            btnConfirmDeleteUniversity.UseVisualStyleBackColor = false;
            btnConfirmDeleteUniversity.Click += btnConfirmDeleteUniversity_Click;
            // 
            // grpUserDetails2
            // 
            grpUserDetails2.BackColor = Color.White;
            grpUserDetails2.Controls.Add(dataUniversityDetails2);
            grpUserDetails2.Location = new Point(124, 74);
            grpUserDetails2.Name = "grpUserDetails2";
            grpUserDetails2.Size = new Size(534, 256);
            grpUserDetails2.TabIndex = 18;
            grpUserDetails2.TabStop = false;
            grpUserDetails2.Text = "University Details";
            // 
            // dataUniversityDetails2
            // 
            dataUniversityDetails2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUniversityDetails2.Location = new Point(16, 26);
            dataUniversityDetails2.Name = "dataUniversityDetails2";
            dataUniversityDetails2.RowHeadersWidth = 51;
            dataUniversityDetails2.Size = new Size(501, 210);
            dataUniversityDetails2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(546, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 34);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(236, 20);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Delete University Form";
            // 
            // deleteuniversitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitDeleteUniversity);
            Controls.Add(btnConfirmDeleteUniversity);
            Controls.Add(grpUserDetails2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "deleteuniversitiesForm";
            Text = "deleteuniversitiesForm";
            Load += deleteuniversitiesForm_Load;
            grpUserDetails2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataUniversityDetails2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExitDeleteUniversity;
        private Button btnConfirmDeleteUniversity;
        private GroupBox grpUserDetails2;
        private DataGridView dataUniversityDetails2;
        private Panel panel1;
        private Label label1;
    }
}