namespace ioopassignment
{
    partial class FacilityAvail
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
            FacSearchBtn = new Button();
            btnBackFacAvail = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvFacilities = new DataGridView();
            txtFacilitySearch = new TextBox();
            txtFacilityCapacity = new TextBox();
            txtFacilityCategory = new TextBox();
            txtFacilityRate = new TextBox();
            txtFacilityAvailability = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFacilities).BeginInit();
            SuspendLayout();
            // 
            // FacSearchBtn
            // 
            FacSearchBtn.Location = new Point(293, 79);
            FacSearchBtn.Name = "FacSearchBtn";
            FacSearchBtn.Size = new Size(87, 29);
            FacSearchBtn.TabIndex = 0;
            FacSearchBtn.Text = "Search";
            FacSearchBtn.UseVisualStyleBackColor = true;
            FacSearchBtn.Click += FacSearchBtn_Click;
            // 
            // btnBackFacAvail
            // 
            btnBackFacAvail.BackgroundImageLayout = ImageLayout.Zoom;
            btnBackFacAvail.Location = new Point(635, 409);
            btnBackFacAvail.Name = "btnBackFacAvail";
            btnBackFacAvail.Size = new Size(94, 29);
            btnBackFacAvail.TabIndex = 1;
            btnBackFacAvail.Text = "Back";
            btnBackFacAvail.UseVisualStyleBackColor = true;
            btnBackFacAvail.Click += btnBackFacAvail_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 82);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Facility:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 97);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Category:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 185);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Rate:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 268);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 6;
            label5.Text = "Capacity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(482, 346);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 7;
            label6.Text = "Availability:";
            // 
            // dgvFacilities
            // 
            dgvFacilities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacilities.Location = new Point(46, 135);
            dgvFacilities.Name = "dgvFacilities";
            dgvFacilities.ReadOnly = true;
            dgvFacilities.RowHeadersWidth = 51;
            dgvFacilities.Size = new Size(397, 245);
            dgvFacilities.TabIndex = 8;
            dgvFacilities.CellClick += dgvFacilities_CellClick;
            dgvFacilities.CellContentClick += dgvFacilities_CellContentClick;
            // 
            // txtFacilitySearch
            // 
            txtFacilitySearch.Location = new Point(143, 79);
            txtFacilitySearch.Name = "txtFacilitySearch";
            txtFacilitySearch.Size = new Size(126, 27);
            txtFacilitySearch.TabIndex = 9;
            // 
            // txtFacilityCapacity
            // 
            txtFacilityCapacity.Location = new Point(581, 261);
            txtFacilityCapacity.Name = "txtFacilityCapacity";
            txtFacilityCapacity.Size = new Size(125, 27);
            txtFacilityCapacity.TabIndex = 12;
            // 
            // txtFacilityCategory
            // 
            txtFacilityCategory.Location = new Point(581, 90);
            txtFacilityCategory.Name = "txtFacilityCategory";
            txtFacilityCategory.Size = new Size(125, 27);
            txtFacilityCategory.TabIndex = 13;
            // 
            // txtFacilityRate
            // 
            txtFacilityRate.Location = new Point(581, 178);
            txtFacilityRate.Name = "txtFacilityRate";
            txtFacilityRate.Size = new Size(125, 27);
            txtFacilityRate.TabIndex = 14;
            // 
            // txtFacilityAvailability
            // 
            txtFacilityAvailability.Location = new Point(581, 339);
            txtFacilityAvailability.Name = "txtFacilityAvailability";
            txtFacilityAvailability.Size = new Size(125, 27);
            txtFacilityAvailability.TabIndex = 15;
            // 
            // FacilityAvail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gray_Peach_Purple_Green_Modern_Product_Launch_Plan_Presentation;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFacilityAvailability);
            Controls.Add(txtFacilityRate);
            Controls.Add(txtFacilityCategory);
            Controls.Add(txtFacilityCapacity);
            Controls.Add(txtFacilitySearch);
            Controls.Add(dgvFacilities);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnBackFacAvail);
            Controls.Add(FacSearchBtn);
            DoubleBuffered = true;
            Name = "FacilityAvail";
            Text = "FacilityAvail";
            Load += FacilityAvail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFacilities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FacSearchBtn;
        private Button btnBackFacAvail;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvFacilities;
        private TextBox txtFacilitySearch;
        private TextBox txtFacilityCapacity;
        private TextBox txtFacilityCategory;
        private TextBox txtFacilityRate;
        private TextBox txtFacilityAvailability;
    }
}