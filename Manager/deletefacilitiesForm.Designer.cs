namespace ioopassignment
{
    partial class deletefacilitiesForm
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
            panel1 = new Panel();
            label1 = new Label();
            grpFacilitiesDetails2 = new GroupBox();
            dataFacilityDetails2 = new DataGridView();
            btnExitDeleteFacilities = new Button();
            btnConfirmDeleteFacilities = new Button();
            panel1.SuspendLayout();
            grpFacilitiesDetails2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFacilityDetails2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(542, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 23);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, -2);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Delete Facilities Form";
            label1.Click += label1_Click;
            // 
            // grpFacilitiesDetails2
            // 
            grpFacilitiesDetails2.BackColor = Color.White;
            grpFacilitiesDetails2.Controls.Add(dataFacilityDetails2);
            grpFacilitiesDetails2.Location = new Point(123, 72);
            grpFacilitiesDetails2.Name = "grpFacilitiesDetails2";
            grpFacilitiesDetails2.Size = new Size(545, 250);
            grpFacilitiesDetails2.TabIndex = 15;
            grpFacilitiesDetails2.TabStop = false;
            grpFacilitiesDetails2.Text = "Facilities Details";
            // 
            // dataFacilityDetails2
            // 
            dataFacilityDetails2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFacilityDetails2.Location = new Point(15, 26);
            dataFacilityDetails2.Name = "dataFacilityDetails2";
            dataFacilityDetails2.RowHeadersWidth = 51;
            dataFacilityDetails2.Size = new Size(510, 209);
            dataFacilityDetails2.TabIndex = 0;
            dataFacilityDetails2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnExitDeleteFacilities
            // 
            btnExitDeleteFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnExitDeleteFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitDeleteFacilities.Location = new Point(411, 342);
            btnExitDeleteFacilities.Name = "btnExitDeleteFacilities";
            btnExitDeleteFacilities.Size = new Size(153, 41);
            btnExitDeleteFacilities.TabIndex = 18;
            btnExitDeleteFacilities.Text = "Exit";
            btnExitDeleteFacilities.UseVisualStyleBackColor = false;
            btnExitDeleteFacilities.Click += btnExitDeleteFacilities_Click;
            // 
            // btnConfirmDeleteFacilities
            // 
            btnConfirmDeleteFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmDeleteFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmDeleteFacilities.Location = new Point(221, 342);
            btnConfirmDeleteFacilities.Name = "btnConfirmDeleteFacilities";
            btnConfirmDeleteFacilities.Size = new Size(153, 41);
            btnConfirmDeleteFacilities.TabIndex = 17;
            btnConfirmDeleteFacilities.Text = "Confirm Delete";
            btnConfirmDeleteFacilities.UseVisualStyleBackColor = false;
            btnConfirmDeleteFacilities.Click += btnConfirmDeleteFacilities_Click;
            // 
            // deletefacilitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitDeleteFacilities);
            Controls.Add(btnConfirmDeleteFacilities);
            Controls.Add(grpFacilitiesDetails2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "deletefacilitiesForm";
            Text = "deletefacilitiesForm";
            Load += deletefacilitiesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpFacilitiesDetails2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataFacilityDetails2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox grpFacilitiesDetails2;
        private Button btnExitDeleteFacilities;
        private Button btnConfirmDeleteFacilities;
        private DataGridView dataFacilityDetails2;
    }
}