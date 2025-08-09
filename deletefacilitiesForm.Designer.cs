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
            btnExitDeleteFacilities = new Button();
            btnConfirmDeleteFacilities = new Button();
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
            panel1.Size = new Size(364, 45);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(355, 31);
            label1.TabIndex = 0;
            label1.Text = "ARFMS Delete Facilities Form";
            // 
            // grpFacilitiesDetails2
            // 
            grpFacilitiesDetails2.BackColor = Color.White;
            grpFacilitiesDetails2.Location = new Point(105, 83);
            grpFacilitiesDetails2.Name = "grpFacilitiesDetails2";
            grpFacilitiesDetails2.Size = new Size(590, 285);
            grpFacilitiesDetails2.TabIndex = 15;
            grpFacilitiesDetails2.TabStop = false;
            grpFacilitiesDetails2.Text = "Facilities Details";
            // 
            // btnExitDeleteFacilities
            // 
            btnExitDeleteFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnExitDeleteFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitDeleteFacilities.Location = new Point(412, 384);
            btnExitDeleteFacilities.Name = "btnExitDeleteFacilities";
            btnExitDeleteFacilities.Size = new Size(153, 41);
            btnExitDeleteFacilities.TabIndex = 18;
            btnExitDeleteFacilities.Text = "Exit";
            btnExitDeleteFacilities.UseVisualStyleBackColor = false;
            // 
            // btnConfirmDeleteFacilities
            // 
            btnConfirmDeleteFacilities.BackColor = Color.FromArgb(255, 224, 192);
            btnConfirmDeleteFacilities.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnConfirmDeleteFacilities.Location = new Point(222, 384);
            btnConfirmDeleteFacilities.Name = "btnConfirmDeleteFacilities";
            btnConfirmDeleteFacilities.Size = new Size(153, 41);
            btnConfirmDeleteFacilities.TabIndex = 17;
            btnConfirmDeleteFacilities.Text = "Confirm Delete";
            btnConfirmDeleteFacilities.UseVisualStyleBackColor = false;
            // 
            // deletefacilitiesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitDeleteFacilities);
            Controls.Add(btnConfirmDeleteFacilities);
            Controls.Add(grpFacilitiesDetails2);
            Controls.Add(panel1);
            Name = "deletefacilitiesForm";
            Text = "deletefacilitiesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox grpFacilitiesDetails2;
        private Button btnExitDeleteFacilities;
        private Button btnConfirmDeleteFacilities;
    }
}