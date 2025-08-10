namespace ioopassignment
{
    partial class declinereasonForm
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
            txtDeclineReason = new TextBox();
            btnExitDeclineReason = new Button();
            btnContinueDecline = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 57);
            label1.Name = "label1";
            label1.Size = new Size(252, 24);
            label1.TabIndex = 0;
            label1.Text = "State Reason of Decline:";
            // 
            // txtDeclineReason
            // 
            txtDeclineReason.Location = new Point(46, 100);
            txtDeclineReason.Name = "txtDeclineReason";
            txtDeclineReason.Size = new Size(458, 27);
            txtDeclineReason.TabIndex = 1;
            // 
            // btnExitDeclineReason
            // 
            btnExitDeclineReason.BackColor = Color.FromArgb(255, 224, 192);
            btnExitDeclineReason.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitDeclineReason.Location = new Point(283, 147);
            btnExitDeclineReason.Name = "btnExitDeclineReason";
            btnExitDeclineReason.Size = new Size(153, 41);
            btnExitDeclineReason.TabIndex = 30;
            btnExitDeclineReason.Text = "Exit";
            btnExitDeclineReason.UseVisualStyleBackColor = false;
            btnExitDeclineReason.Click += btnExitDeclineReason_Click;
            // 
            // btnContinueDecline
            // 
            btnContinueDecline.BackColor = Color.FromArgb(255, 224, 192);
            btnContinueDecline.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnContinueDecline.Location = new Point(97, 147);
            btnContinueDecline.Name = "btnContinueDecline";
            btnContinueDecline.Size = new Size(153, 41);
            btnContinueDecline.TabIndex = 29;
            btnContinueDecline.Text = "Continue";
            btnContinueDecline.UseVisualStyleBackColor = false;
            // 
            // declinereasonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 250);
            Controls.Add(btnExitDeclineReason);
            Controls.Add(btnContinueDecline);
            Controls.Add(txtDeclineReason);
            Controls.Add(label1);
            Name = "declinereasonForm";
            Text = "declinereasonForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDeclineReason;
        private Button btnExitDeclineReason;
        private Button btnContinueDecline;
    }
}