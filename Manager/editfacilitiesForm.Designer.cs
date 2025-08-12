namespace ioopassignment.Manager
{
    partial class editfacilitiesForm
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
            panel1 = new Panel();
            grpFacilitiesDetails3 = new GroupBox();
            dataFacilityDetails3 = new DataGridView();
            btnExitEditFacilities = new Button();
            btnConfirmEditFacilities = new Button();
            panel1.SuspendLayout();
            grpFacilitiesDetails3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFacilityDetails3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, -2);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Edit Facilities Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(574, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 23);
            panel1.TabIndex = 15;
            // 
            // grpFacilitiesDetails3
            // 
            grpFacilitiesDetails3.BackColor = Color.White;
            grpFacilitiesDetails3.Controls.Add(dataFacilityDetails3);
            grpFacilitiesDetails3.Location = new Point(125, 69);
            grpFacilitiesDetails3.Name = "grpFacilitiesDetails3";
            grpFacilitiesDetails3.Size = new Size(545, 250);
            grpFacilitiesDetails3.TabIndex = 16;
            grpFacilitiesDetails3.TabStop = false;
            grpFacilitiesDetails3.Text = "Facilities Details";
            // 
            // dataFacilityDetails3
            // 
            dataFacilityDetails3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFacilityDetails3.Location = new Point(15, 26);
            dataFacilityDetails3.Name = "dataFacilityDetails3";
            dataFacilityDetails3.RowHeadersWidth = 51;
            dataFacilityDetails3.Size = new Size(510, 209);
            dataFacilityDetails3.TabIndex = 0;
            dataFacilityDetails3.CellContentClick += dataFacilityDetails2_CellContentClick;
            // 
            // btnExitEditFacilities
            // 
            btnExitEditFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnExitEditFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitEditFacilities.Location = new Point(409, 337);
            btnExitEditFacilities.Name = "btnExitEditFacilities";
            btnExitEditFacilities.Size = new Size(153, 41);
            btnExitEditFacilities.TabIndex = 20;
            btnExitEditFacilities.Text = "Exit";
            btnExitEditFacilities.UseVisualStyleBackColor = false;
            btnExitEditFacilities.Click += btnExitEditFacilities_Click;
            // 
            // btnConfirmEditFacilities
            // 
            btnConfirmEditFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmEditFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmEditFacilities.Location = new Point(219, 337);
            btnConfirmEditFacilities.Name = "btnConfirmEditFacilities";
            btnConfirmEditFacilities.Size = new Size(153, 41);
            btnConfirmEditFacilities.TabIndex = 19;
            btnConfirmEditFacilities.Text = "Confirm Edit";
            btnConfirmEditFacilities.UseVisualStyleBackColor = false;
            btnConfirmEditFacilities.Click += btnConfirmEditFacilities_Click;
            // 
            // editfacilitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitEditFacilities);
            Controls.Add(grpFacilitiesDetails3);
            Controls.Add(btnConfirmEditFacilities);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "editfacilitiesForm";
            Text = "editfacilitiesForm";
            Load += editfacilitiesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpFacilitiesDetails3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataFacilityDetails3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox grpFacilitiesDetails3;
        private DataGridView dataFacilityDetails3;
        private Button btnExitEditFacilities;
        private Button btnConfirmEditFacilities;
    }
}