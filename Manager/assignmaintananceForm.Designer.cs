namespace ioopassignment
{
    partial class assignmaintananceForm
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
            label4 = new Label();
            grpAssignMaintanance = new GroupBox();
            dataMaintanance1 = new DataGridView();
            btnSeeAssignMaintanance = new Button();
            btnExitAssignMaintanace = new Button();
            btnAssignMaintanance = new Button();
            panel1.SuspendLayout();
            grpAssignMaintanance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMaintanance1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(529, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 26);
            panel1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(-2, 3);
            label4.Name = "label4";
            label4.Size = new Size(256, 20);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Assign Maintanance Form";
            // 
            // grpAssignMaintanance
            // 
            grpAssignMaintanance.BackColor = Color.White;
            grpAssignMaintanance.Controls.Add(dataMaintanance1);
            grpAssignMaintanance.Location = new Point(90, 75);
            grpAssignMaintanance.Name = "grpAssignMaintanance";
            grpAssignMaintanance.Size = new Size(605, 264);
            grpAssignMaintanance.TabIndex = 15;
            grpAssignMaintanance.TabStop = false;
            grpAssignMaintanance.Text = "Maintanance Schedule";
            // 
            // dataMaintanance1
            // 
            dataMaintanance1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMaintanance1.Location = new Point(21, 26);
            dataMaintanance1.Name = "dataMaintanance1";
            dataMaintanance1.RowHeadersWidth = 51;
            dataMaintanance1.Size = new Size(567, 223);
            dataMaintanance1.TabIndex = 0;
            dataMaintanance1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSeeAssignMaintanance
            // 
            btnSeeAssignMaintanance.BackColor = Color.FromArgb(255, 224, 192);
            btnSeeAssignMaintanance.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSeeAssignMaintanance.Location = new Point(434, 12);
            btnSeeAssignMaintanance.Name = "btnSeeAssignMaintanance";
            btnSeeAssignMaintanance.Size = new Size(89, 35);
            btnSeeAssignMaintanance.TabIndex = 16;
            btnSeeAssignMaintanance.Text = "See";
            btnSeeAssignMaintanance.UseVisualStyleBackColor = false;
            btnSeeAssignMaintanance.Click += btnSeeAssignMaintanance_Click;
            // 
            // btnExitAssignMaintanace
            // 
            btnExitAssignMaintanace.BackColor = Color.FromArgb(255, 224, 192);
            btnExitAssignMaintanace.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitAssignMaintanace.Location = new Point(437, 345);
            btnExitAssignMaintanace.Name = "btnExitAssignMaintanace";
            btnExitAssignMaintanace.Size = new Size(153, 41);
            btnExitAssignMaintanace.TabIndex = 20;
            btnExitAssignMaintanace.Text = "Exit";
            btnExitAssignMaintanace.UseVisualStyleBackColor = false;
            btnExitAssignMaintanace.Click += btnExitAssignMaintanace_Click;
            // 
            // btnAssignMaintanance
            // 
            btnAssignMaintanance.BackColor = Color.FromArgb(255, 224, 192);
            btnAssignMaintanance.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAssignMaintanance.Location = new Point(186, 345);
            btnAssignMaintanance.Name = "btnAssignMaintanance";
            btnAssignMaintanance.Size = new Size(197, 41);
            btnAssignMaintanance.TabIndex = 19;
            btnAssignMaintanance.Text = "Assign Maintanance";
            btnAssignMaintanance.UseVisualStyleBackColor = false;
            btnAssignMaintanance.Click += btnAssignMaintanance_Click;
            // 
            // assignmaintananceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitAssignMaintanace);
            Controls.Add(btnAssignMaintanance);
            Controls.Add(btnSeeAssignMaintanance);
            Controls.Add(grpAssignMaintanance);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "assignmaintananceForm";
            Text = "assignmaintananceForm";
            Load += assignmaintananceForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpAssignMaintanance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataMaintanance1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private GroupBox grpAssignMaintanance;
        private Button btnSeeAssignMaintanance;
        private Button btnExitAssignMaintanace;
        private Button btnAssignMaintanance;
        private DataGridView dataMaintanance1;
    }
}