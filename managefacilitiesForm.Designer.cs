namespace ioopassignment
{
    partial class managefacilitiesForm
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
            btnSeeFacilities = new Button();
            grpFacilitiesDetails = new GroupBox();
            btnExitManageFacilities = new Button();
            btnDeleteFacilities = new Button();
            btnAddFacilities = new Button();
            btnEditFacilities = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 45);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(369, 31);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Manage Facilities Form";
            label1.Click += label1_Click;
            // 
            // btnSeeFacilities
            // 
            btnSeeFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnSeeFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSeeFacilities.Location = new Point(392, 17);
            btnSeeFacilities.Name = "btnSeeFacilities";
            btnSeeFacilities.Size = new Size(89, 35);
            btnSeeFacilities.TabIndex = 14;
            btnSeeFacilities.Text = "See";
            btnSeeFacilities.UseVisualStyleBackColor = false;
            btnSeeFacilities.Click += btnSeeFacilities_Click;
            // 
            // grpFacilitiesDetails
            // 
            grpFacilitiesDetails.BackColor = Color.White;
            grpFacilitiesDetails.Location = new Point(105, 83);
            grpFacilitiesDetails.Name = "grpFacilitiesDetails";
            grpFacilitiesDetails.Size = new Size(590, 285);
            grpFacilitiesDetails.TabIndex = 15;
            grpFacilitiesDetails.TabStop = false;
            grpFacilitiesDetails.Text = "Facilities Details";
            grpFacilitiesDetails.Enter += grpFacilitiesDetails_Enter;
            // 
            // btnExitManageFacilities
            // 
            btnExitManageFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnExitManageFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitManageFacilities.Location = new Point(625, 385);
            btnExitManageFacilities.Name = "btnExitManageFacilities";
            btnExitManageFacilities.Size = new Size(153, 41);
            btnExitManageFacilities.TabIndex = 18;
            btnExitManageFacilities.Text = "Exit";
            btnExitManageFacilities.UseVisualStyleBackColor = false;
            btnExitManageFacilities.Click += btnExitManageUser_Click;
            // 
            // btnDeleteFacilities
            // 
            btnDeleteFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnDeleteFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnDeleteFacilities.Location = new Point(233, 385);
            btnDeleteFacilities.Name = "btnDeleteFacilities";
            btnDeleteFacilities.Size = new Size(153, 41);
            btnDeleteFacilities.TabIndex = 17;
            btnDeleteFacilities.Text = "Delete";
            btnDeleteFacilities.UseVisualStyleBackColor = false;
            btnDeleteFacilities.Click += btnDeleteFacilities_Click;
            // 
            // btnAddFacilities
            // 
            btnAddFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnAddFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnAddFacilities.Location = new Point(29, 385);
            btnAddFacilities.Name = "btnAddFacilities";
            btnAddFacilities.Size = new Size(153, 41);
            btnAddFacilities.TabIndex = 16;
            btnAddFacilities.Text = "Add";
            btnAddFacilities.UseVisualStyleBackColor = false;
            btnAddFacilities.Click += btnAddFacilities_Click;
            // 
            // btnEditFacilities
            // 
            btnEditFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnEditFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnEditFacilities.Location = new Point(429, 385);
            btnEditFacilities.Name = "btnEditFacilities";
            btnEditFacilities.Size = new Size(153, 41);
            btnEditFacilities.TabIndex = 19;
            btnEditFacilities.Text = "Edit";
            btnEditFacilities.UseVisualStyleBackColor = false;
            btnEditFacilities.Click += btnEditFacilities_Click;
            // 
            // managefacilitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditFacilities);
            Controls.Add(btnExitManageFacilities);
            Controls.Add(btnDeleteFacilities);
            Controls.Add(btnAddFacilities);
            Controls.Add(grpFacilitiesDetails);
            Controls.Add(btnSeeFacilities);
            Controls.Add(panel1);
            Name = "managefacilitiesForm";
            Text = "managefacilitiesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSeeFacilities;
        private GroupBox grpFacilitiesDetails;
        private Button btnExitManageFacilities;
        private Button btnDeleteFacilities;
        private Button btnAddFacilities;
        private Button btnEditFacilities;
    }
}