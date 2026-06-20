namespace ioopassignment
{
    partial class StudentForm
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
            components = new System.ComponentModel.Container();
            AvaibilityBtn = new Button();
            UpdateBtn = new Button();
            FacBookBtn = new Button();
            RateBtn = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AvaibilityBtn
            // 
            AvaibilityBtn.Location = new Point(82, 165);
            AvaibilityBtn.Name = "AvaibilityBtn";
            AvaibilityBtn.Size = new Size(128, 29);
            AvaibilityBtn.TabIndex = 0;
            AvaibilityBtn.Text = "Check avaibility";
            AvaibilityBtn.UseVisualStyleBackColor = true;
            AvaibilityBtn.Click += AvaibilityBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(601, 268);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(124, 29);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "Update Profile";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // FacBookBtn
            // 
            FacBookBtn.Location = new Point(82, 268);
            FacBookBtn.Name = "FacBookBtn";
            FacBookBtn.Size = new Size(124, 29);
            FacBookBtn.TabIndex = 3;
            FacBookBtn.Text = "Facility Booking";
            FacBookBtn.UseVisualStyleBackColor = true;
            FacBookBtn.Click += FacBookBtn_Click;
            // 
            // RateBtn
            // 
            RateBtn.Location = new Point(601, 165);
            RateBtn.Name = "RateBtn";
            RateBtn.Size = new Size(124, 29);
            RateBtn.TabIndex = 4;
            RateBtn.Text = "Facility Rating";
            RateBtn.UseVisualStyleBackColor = true;
            RateBtn.Click += RateBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.apu_student;
            pictureBox1.Location = new Point(292, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.Location = new Point(573, 412);
            Exit.Name = "Exit";
            Exit.Size = new Size(124, 29);
            Exit.TabIndex = 24;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gray_Peach_Purple_Green_Modern_Product_Launch_Plan_Presentation__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(pictureBox1);
            Controls.Add(RateBtn);
            Controls.Add(FacBookBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AvaibilityBtn);
            DoubleBuffered = true;
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AvaibilityBtn;
        private Button UpdateBtn;
        private Button FacBookBtn;
        private Button RateBtn;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button Exit;
    }
}