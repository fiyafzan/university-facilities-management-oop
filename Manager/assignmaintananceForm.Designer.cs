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
            dataMaintanance = new DataGridView();
            btnSeeMaintenance = new Button();
            btnExitAssignMaintenace = new Button();
            btnAssignMaintanance = new Button();
            panel1.SuspendLayout();
            grpAssignMaintanance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMaintanance).BeginInit();
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
            label4.Size = new Size(255, 20);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Assign Maintenance Form";
            // 
            // grpAssignMaintanance
            // 
            grpAssignMaintanance.BackColor = Color.White;
            grpAssignMaintanance.Controls.Add(dataMaintanance);
            grpAssignMaintanance.Location = new Point(90, 75);
            grpAssignMaintanance.Name = "grpAssignMaintanance";
            grpAssignMaintanance.Size = new Size(605, 264);
            grpAssignMaintanance.TabIndex = 15;
            grpAssignMaintanance.TabStop = false;
            grpAssignMaintanance.Text = "Maintanance Schedule";
            // 
            // dataMaintanance
            // 
            dataMaintanance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMaintanance.Location = new Point(21, 26);
            dataMaintanance.Name = "dataMaintanance";
            dataMaintanance.RowHeadersWidth = 51;
            dataMaintanance.Size = new Size(567, 223);
            dataMaintanance.TabIndex = 0;
            dataMaintanance.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSeeMaintenance
            // 
            btnSeeMaintenance.BackColor = Color.FromArgb(255, 224, 192);
            btnSeeMaintenance.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSeeMaintenance.Location = new Point(434, 12);
            btnSeeMaintenance.Name = "btnSeeMaintenance";
            btnSeeMaintenance.Size = new Size(89, 35);
            btnSeeMaintenance.TabIndex = 16;
            btnSeeMaintenance.Text = "See";
            btnSeeMaintenance.UseVisualStyleBackColor = false;
            btnSeeMaintenance.Click += btnSeeAssignMaintanance_Click;
            // 
            // btnExitAssignMaintenace
            // 
            btnExitAssignMaintenace.BackColor = Color.FromArgb(255, 224, 192);
            btnExitAssignMaintenace.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitAssignMaintenace.Location = new Point(437, 345);
            btnExitAssignMaintenace.Name = "btnExitAssignMaintenace";
            btnExitAssignMaintenace.Size = new Size(153, 41);
            btnExitAssignMaintenace.TabIndex = 20;
            btnExitAssignMaintenace.Text = "Exit";
            btnExitAssignMaintenace.UseVisualStyleBackColor = false;
            btnExitAssignMaintenace.Click += btnExitAssignMaintanace_Click;
            // 
            // btnAssignMaintanance
            // 
            btnAssignMaintanance.BackColor = Color.FromArgb(255, 224, 192);
            btnAssignMaintanance.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAssignMaintanance.Location = new Point(186, 345);
            btnAssignMaintanance.Name = "btnAssignMaintanance";
            btnAssignMaintanance.Size = new Size(197, 41);
            btnAssignMaintanance.TabIndex = 19;
            btnAssignMaintanance.Text = "Assign Maintenance";
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
            Controls.Add(btnExitAssignMaintenace);
            Controls.Add(btnAssignMaintanance);
            Controls.Add(btnSeeMaintenance);
            Controls.Add(grpAssignMaintanance);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "assignmaintananceForm";
            Text = "assignmaintananceForm";
            Load += assignmaintananceForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpAssignMaintanance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataMaintanance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private GroupBox grpAssignMaintanance;
        private Button btnSeeMaintenance;
        private Button btnExitAssignMaintenace;
        private Button btnAssignMaintanance;
        private DataGridView dataMaintanance;
    }
}