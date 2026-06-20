namespace ioopassignment
{
    partial class addfacilitiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addfacilitiesForm));
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            cboUniversity = new ComboBox();
            txtAddAvailability = new TextBox();
            label5 = new Label();
            txtAddFacilityCapacity = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtAddFacilityRate = new TextBox();
            label3 = new Label();
            txtAddFacilityCategory = new TextBox();
            btnExitAddFacility = new Button();
            btnConfirmAddFacility = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(573, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 28);
            panel1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(-2, 0);
            label4.Name = "label4";
            label4.Size = new Size(211, 20);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Add Facilities Form";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(cboUniversity);
            panel2.Controls.Add(txtAddAvailability);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtAddFacilityCapacity);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtAddFacilityRate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtAddFacilityCategory);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(203, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 246);
            panel2.TabIndex = 17;
            // 
            // cboUniversity
            // 
            cboUniversity.FormattingEnabled = true;
            cboUniversity.Location = new Point(242, 22);
            cboUniversity.Name = "cboUniversity";
            cboUniversity.Size = new Size(125, 28);
            cboUniversity.TabIndex = 18;
            // 
            // txtAddAvailability
            // 
            txtAddAvailability.Font = new Font("Roboto", 9F);
            txtAddAvailability.Location = new Point(242, 205);
            txtAddAvailability.Name = "txtAddAvailability";
            txtAddAvailability.Size = new Size(125, 26);
            txtAddAvailability.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 200);
            label5.Name = "label5";
            label5.Size = new Size(234, 31);
            label5.TabIndex = 16;
            label5.Text = "Availability (y/n) :";
            label5.Click += label5_Click_1;
            // 
            // txtAddFacilityCapacity
            // 
            txtAddFacilityCapacity.Font = new Font("Roboto", 9F);
            txtAddFacilityCapacity.Location = new Point(242, 161);
            txtAddFacilityCapacity.Name = "txtAddFacilityCapacity";
            txtAddFacilityCapacity.Size = new Size(125, 26);
            txtAddFacilityCapacity.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(106, 156);
            label6.Name = "label6";
            label6.Size = new Size(130, 31);
            label6.TabIndex = 14;
            label6.Text = "Capacity :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 19);
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
            label2.Location = new Point(11, 60);
            label2.Name = "label2";
            label2.Size = new Size(225, 31);
            label2.TabIndex = 7;
            label2.Text = "Facility Category :";
            // 
            // txtAddFacilityRate
            // 
            txtAddFacilityRate.Font = new Font("Roboto", 9F);
            txtAddFacilityRate.Location = new Point(242, 115);
            txtAddFacilityRate.Name = "txtAddFacilityRate";
            txtAddFacilityRate.Size = new Size(125, 26);
            txtAddFacilityRate.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 110);
            label3.Name = "label3";
            label3.Size = new Size(233, 31);
            label3.TabIndex = 8;
            label3.Text = "Facility Rate (/hr) :";
            // 
            // txtAddFacilityCategory
            // 
            txtAddFacilityCategory.Font = new Font("Roboto", 9F);
            txtAddFacilityCategory.Location = new Point(242, 65);
            txtAddFacilityCategory.Name = "txtAddFacilityCategory";
            txtAddFacilityCategory.Size = new Size(125, 26);
            txtAddFacilityCategory.TabIndex = 10;
            txtAddFacilityCategory.TextChanged += txtAddFacilityCategory_TextChanged;
            // 
            // btnExitAddFacility
            // 
            btnExitAddFacility.BackColor = Color.FromArgb(255, 224, 192);
            btnExitAddFacility.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitAddFacility.Location = new Point(404, 323);
            btnExitAddFacility.Name = "btnExitAddFacility";
            btnExitAddFacility.Size = new Size(153, 41);
            btnExitAddFacility.TabIndex = 16;
            btnExitAddFacility.Text = "Exit";
            btnExitAddFacility.UseVisualStyleBackColor = false;
            btnExitAddFacility.Click += btnExitAddFacility_Click;
            // 
            // btnConfirmAddFacility
            // 
            btnConfirmAddFacility.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmAddFacility.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmAddFacility.Location = new Point(236, 323);
            btnConfirmAddFacility.Name = "btnConfirmAddFacility";
            btnConfirmAddFacility.Size = new Size(153, 41);
            btnConfirmAddFacility.TabIndex = 15;
            btnConfirmAddFacility.Text = "Confirm Add";
            btnConfirmAddFacility.UseVisualStyleBackColor = false;
            btnConfirmAddFacility.Click += btnConfirmAddFacility_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(607, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // addfacilitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(btnExitAddFacility);
            Controls.Add(btnConfirmAddFacility);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "addfacilitiesForm";
            Text = "addfacilitiesForm";
            Load += addfacilitiesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtAddFacilityRate;
        private Label label3;
        private TextBox txtAddFacilityCategory;
        private Button btnExitAddFacility;
        private Button btnConfirmAddFacility;
        private TextBox txtAddFacilityCapacity;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox txtAddAvailability;
        private ComboBox cboUniversity;
    }
}