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
            label1 = new Label();
            label2 = new Label();
            txtAddFacilityRate = new TextBox();
            label3 = new Label();
            txtAddFacilityType = new TextBox();
            txtAddUniversity = new TextBox();
            btnExitAddFacility = new Button();
            btnConfirmAddFacility = new Button();
            label5 = new Label();
            txtAddFacilityLocation = new TextBox();
            label6 = new Label();
            txtAddFacilityCapacity = new TextBox();
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 45);
            panel1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(329, 31);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Add Facilities Form";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtAddFacilityCapacity);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtAddFacilityLocation);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtAddFacilityRate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtAddFacilityType);
            panel2.Controls.Add(txtAddUniversity);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(211, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 231);
            panel2.TabIndex = 17;
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
            label2.Location = new Point(59, 51);
            label2.Name = "label2";
            label2.Size = new Size(174, 31);
            label2.TabIndex = 7;
            label2.Text = "Facility Type :";
            // 
            // txtAddFacilityRate
            // 
            txtAddFacilityRate.Font = new Font("Roboto", 9F);
            txtAddFacilityRate.Location = new Point(239, 106);
            txtAddFacilityRate.Name = "txtAddFacilityRate";
            txtAddFacilityRate.Size = new Size(125, 26);
            txtAddFacilityRate.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 101);
            label3.Name = "label3";
            label3.Size = new Size(233, 31);
            label3.TabIndex = 8;
            label3.Text = "Facility Rate (/hr) :";
            // 
            // txtAddFacilityType
            // 
            txtAddFacilityType.Font = new Font("Roboto", 9F);
            txtAddFacilityType.Location = new Point(239, 56);
            txtAddFacilityType.Name = "txtAddFacilityType";
            txtAddFacilityType.Size = new Size(125, 26);
            txtAddFacilityType.TabIndex = 10;
            // 
            // txtAddUniversity
            // 
            txtAddUniversity.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddUniversity.Location = new Point(239, 10);
            txtAddUniversity.Name = "txtAddUniversity";
            txtAddUniversity.Size = new Size(125, 26);
            txtAddUniversity.TabIndex = 9;
            // 
            // btnExitAddFacility
            // 
            btnExitAddFacility.BackColor = Color.FromArgb(255, 224, 192);
            btnExitAddFacility.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitAddFacility.Location = new Point(409, 350);
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
            btnConfirmAddFacility.Location = new Point(241, 350);
            btnConfirmAddFacility.Name = "btnConfirmAddFacility";
            btnConfirmAddFacility.Size = new Size(153, 41);
            btnConfirmAddFacility.TabIndex = 15;
            btnConfirmAddFacility.Text = "Confirm Add";
            btnConfirmAddFacility.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 147);
            label5.Name = "label5";
            label5.Size = new Size(122, 31);
            label5.TabIndex = 12;
            label5.Text = "Location :";
            label5.Click += label5_Click;
            // 
            // txtAddFacilityLocation
            // 
            txtAddFacilityLocation.Font = new Font("Roboto", 9F);
            txtAddFacilityLocation.Location = new Point(239, 152);
            txtAddFacilityLocation.Name = "txtAddFacilityLocation";
            txtAddFacilityLocation.Size = new Size(125, 26);
            txtAddFacilityLocation.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(103, 187);
            label6.Name = "label6";
            label6.Size = new Size(130, 31);
            label6.TabIndex = 14;
            label6.Text = "Capacity :";
            // 
            // txtAddFacilityCapacity
            // 
            txtAddFacilityCapacity.Font = new Font("Roboto", 9F);
            txtAddFacilityCapacity.Location = new Point(239, 195);
            txtAddFacilityCapacity.Name = "txtAddFacilityCapacity";
            txtAddFacilityCapacity.Size = new Size(125, 26);
            txtAddFacilityCapacity.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(605, 135);
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
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(btnExitAddFacility);
            Controls.Add(btnConfirmAddFacility);
            Controls.Add(panel1);
            Name = "addfacilitiesForm";
            Text = "addfacilitiesForm";
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
        private TextBox txtAddFacilityType;
        private TextBox txtAddUniversity;
        private Button btnExitAddFacility;
        private Button btnConfirmAddFacility;
        private Label label5;
        private TextBox txtAddFacilityCapacity;
        private Label label6;
        private TextBox txtAddFacilityLocation;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}