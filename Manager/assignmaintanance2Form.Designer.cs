namespace ioopassignment
{
    partial class assignmaintanance2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assignmaintanance2Form));
            panel2 = new Panel();
            cboTechnician = new ComboBox();
            cboDuration = new ComboBox();
            cboFacilityType = new ComboBox();
            cboUniversity = new ComboBox();
            txtDateMaintenance = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            btnExitAddMaintanance = new Button();
            btnConfirmAddMaintanance = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(cboTechnician);
            panel2.Controls.Add(cboDuration);
            panel2.Controls.Add(cboFacilityType);
            panel2.Controls.Add(cboUniversity);
            panel2.Controls.Add(txtDateMaintenance);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(197, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 231);
            panel2.TabIndex = 20;
            // 
            // cboTechnician
            // 
            cboTechnician.FormattingEnabled = true;
            cboTechnician.Location = new Point(239, 193);
            cboTechnician.Name = "cboTechnician";
            cboTechnician.Size = new Size(151, 28);
            cboTechnician.TabIndex = 25;
            // 
            // cboDuration
            // 
            cboDuration.FormattingEnabled = true;
            cboDuration.Location = new Point(239, 104);
            cboDuration.Name = "cboDuration";
            cboDuration.Size = new Size(151, 28);
            cboDuration.TabIndex = 24;
            // 
            // cboFacilityType
            // 
            cboFacilityType.FormattingEnabled = true;
            cboFacilityType.Location = new Point(239, 59);
            cboFacilityType.Name = "cboFacilityType";
            cboFacilityType.Size = new Size(151, 28);
            cboFacilityType.TabIndex = 23;
            cboFacilityType.SelectedIndexChanged += comboboxFacilityType_SelectedIndexChanged;
            // 
            // cboUniversity
            // 
            cboUniversity.FormattingEnabled = true;
            cboUniversity.Location = new Point(239, 13);
            cboUniversity.Name = "cboUniversity";
            cboUniversity.Size = new Size(151, 28);
            cboUniversity.TabIndex = 22;
            cboUniversity.SelectedIndexChanged += comboboxUniversity_SelectedIndexChanged_1;
            // 
            // txtDateMaintenance
            // 
            txtDateMaintenance.Location = new Point(239, 148);
            txtDateMaintenance.Name = "txtDateMaintenance";
            txtDateMaintenance.Size = new Size(151, 27);
            txtDateMaintenance.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 190);
            label5.Name = "label5";
            label5.Size = new Size(147, 31);
            label5.TabIndex = 12;
            label5.Text = "Technician :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(154, 144);
            label6.Name = "label6";
            label6.Size = new Size(79, 31);
            label6.TabIndex = 14;
            label6.Text = "Date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(215, 31);
            label1.TabIndex = 6;
            label1.Text = "University Name :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 56);
            label2.Name = "label2";
            label2.Size = new Size(174, 31);
            label2.TabIndex = 7;
            label2.Text = "Facility Type :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 101);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 8;
            label3.Text = "Duration :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(488, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 35);
            panel1.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(290, 20);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Add Assign Maintenance Form";
            label4.Click += label4_Click;
            // 
            // btnExitAddMaintanance
            // 
            btnExitAddMaintanance.BackColor = Color.FromArgb(255, 224, 192);
            btnExitAddMaintanance.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitAddMaintanance.Location = new Point(420, 342);
            btnExitAddMaintanance.Name = "btnExitAddMaintanance";
            btnExitAddMaintanance.Size = new Size(153, 41);
            btnExitAddMaintanance.TabIndex = 22;
            btnExitAddMaintanance.Text = "Exit";
            btnExitAddMaintanance.UseVisualStyleBackColor = false;
            btnExitAddMaintanance.Click += btnExitAddMaintanance_Click;
            // 
            // btnConfirmAddMaintanance
            // 
            btnConfirmAddMaintanance.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmAddMaintanance.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmAddMaintanance.Location = new Point(243, 342);
            btnConfirmAddMaintanance.Name = "btnConfirmAddMaintanance";
            btnConfirmAddMaintanance.Size = new Size(153, 41);
            btnConfirmAddMaintanance.TabIndex = 21;
            btnConfirmAddMaintanance.Text = "Confirm Assign";
            btnConfirmAddMaintanance.UseVisualStyleBackColor = false;
            btnConfirmAddMaintanance.Click += btnConfirmAddMaintanance_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(605, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // assignmaintanance2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExitAddMaintanance);
            Controls.Add(panel1);
            Controls.Add(btnConfirmAddMaintanance);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "assignmaintanance2Form";
            Text = "assignmaintanance2Form";
            Load += assignmaintanance2Form_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private TextBox txtDateMaintenance;
        private Button btnExitAddMaintanance;
        private Button btnConfirmAddMaintanance;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox cboUniversity;
        private ComboBox cboDuration;
        private ComboBox cboFacilityType;
        private ComboBox cboTechnician;
    }
}