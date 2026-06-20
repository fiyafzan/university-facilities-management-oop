namespace ioopassignment.Manager
{
    partial class adduniversitiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adduniversitiesForm));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            txtAddUniversity = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            btnExitAddUniversity = new Button();
            btnConfirmAddUniversity = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(602, 128);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtAddUniversity);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(211, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 93);
            panel2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 31);
            label1.Name = "label1";
            label1.Size = new Size(143, 31);
            label1.TabIndex = 6;
            label1.Text = "University :";
            // 
            // txtAddUniversity
            // 
            txtAddUniversity.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddUniversity.Location = new Point(190, 36);
            txtAddUniversity.Name = "txtAddUniversity";
            txtAddUniversity.Size = new Size(125, 26);
            txtAddUniversity.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(561, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 33);
            panel1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(219, 20);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Add University Form";
            // 
            // btnExitAddUniversity
            // 
            btnExitAddUniversity.BackColor = Color.FromArgb(255, 224, 192);
            btnExitAddUniversity.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitAddUniversity.Location = new Point(403, 270);
            btnExitAddUniversity.Name = "btnExitAddUniversity";
            btnExitAddUniversity.Size = new Size(153, 41);
            btnExitAddUniversity.TabIndex = 19;
            btnExitAddUniversity.Text = "Exit";
            btnExitAddUniversity.UseVisualStyleBackColor = false;
            btnExitAddUniversity.Click += btnExitAddUniversity_Click;
            // 
            // btnConfirmAddUniversity
            // 
            btnConfirmAddUniversity.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmAddUniversity.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmAddUniversity.Location = new Point(244, 270);
            btnConfirmAddUniversity.Name = "btnConfirmAddUniversity";
            btnConfirmAddUniversity.Size = new Size(153, 41);
            btnConfirmAddUniversity.TabIndex = 18;
            btnConfirmAddUniversity.Text = "Confirm Add";
            btnConfirmAddUniversity.UseVisualStyleBackColor = false;
            btnConfirmAddUniversity.Click += btnConfirmAddUniversity_Click;
            // 
            // adduniversitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExitAddUniversity);
            Controls.Add(btnConfirmAddUniversity);
            DoubleBuffered = true;
            Name = "adduniversitiesForm";
            Text = "adduniversitiesForm";
            Load += adduniversitiesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private TextBox txtAddUniversity;
        private Panel panel1;
        private Label label4;
        private Button btnExitAddUniversity;
        private Button btnConfirmAddUniversity;
    }
}