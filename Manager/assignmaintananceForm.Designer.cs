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
            btnSeeAssignMaintanance = new Button();
            btnExitAssignMaintanace = new Button();
            btnAssignMaintanance = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            grpAssignMaintanance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(403, 45);
            panel1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(397, 31);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Assign Maintanance Form";
            // 
            // grpAssignMaintanance
            // 
            grpAssignMaintanance.BackColor = Color.White;
            grpAssignMaintanance.Controls.Add(dataGridView1);
            grpAssignMaintanance.Location = new Point(93, 92);
            grpAssignMaintanance.Name = "grpAssignMaintanance";
            grpAssignMaintanance.Size = new Size(605, 264);
            grpAssignMaintanance.TabIndex = 15;
            grpAssignMaintanance.TabStop = false;
            grpAssignMaintanance.Text = "Maintanance Schedule";
            // 
            // btnSeeAssignMaintanance
            // 
            btnSeeAssignMaintanance.BackColor = Color.FromArgb(255, 224, 192);
            btnSeeAssignMaintanance.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSeeAssignMaintanance.Location = new Point(421, 17);
            btnSeeAssignMaintanance.Name = "btnSeeAssignMaintanance";
            btnSeeAssignMaintanance.Size = new Size(89, 35);
            btnSeeAssignMaintanance.TabIndex = 16;
            btnSeeAssignMaintanance.Text = "See";
            btnSeeAssignMaintanance.UseVisualStyleBackColor = false;
            // 
            // btnExitAssignMaintanace
            // 
            btnExitAssignMaintanace.BackColor = Color.FromArgb(255, 224, 192);
            btnExitAssignMaintanace.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitAssignMaintanace.Location = new Point(447, 371);
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
            btnAssignMaintanance.Location = new Point(196, 371);
            btnAssignMaintanance.Name = "btnAssignMaintanance";
            btnAssignMaintanance.Size = new Size(197, 41);
            btnAssignMaintanance.TabIndex = 19;
            btnAssignMaintanance.Text = "Assign Maintanance";
            btnAssignMaintanance.UseVisualStyleBackColor = false;
            btnAssignMaintanance.Click += btnAssignMaintanance_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(567, 223);
            dataGridView1.TabIndex = 0;
            // 
            // assignmaintananceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitAssignMaintanace);
            Controls.Add(btnAssignMaintanance);
            Controls.Add(btnSeeAssignMaintanance);
            Controls.Add(grpAssignMaintanance);
            Controls.Add(panel1);
            Name = "assignmaintananceForm";
            Text = "assignmaintananceForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpAssignMaintanance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private GroupBox grpAssignMaintanance;
        private Button btnSeeAssignMaintanance;
        private Button btnExitAssignMaintanace;
        private Button btnAssignMaintanance;
        private DataGridView dataGridView1;
    }
}