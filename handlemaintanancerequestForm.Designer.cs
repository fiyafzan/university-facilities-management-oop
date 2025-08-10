namespace ioopassignment
{
    partial class handlemaintanancerequestForm
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
            grpHandleRequest = new GroupBox();
            btnExitHandleRequest = new Button();
            btnDeclineRequest = new Button();
            btnApproveRequest = new Button();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(513, 45);
            panel1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(503, 31);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Handle Maintanance Request Form";
            label4.Click += label4_Click;
            // 
            // grpHandleRequest
            // 
            grpHandleRequest.BackColor = Color.White;
            grpHandleRequest.Location = new Point(120, 101);
            grpHandleRequest.Name = "grpHandleRequest";
            grpHandleRequest.Size = new Size(508, 241);
            grpHandleRequest.TabIndex = 25;
            grpHandleRequest.TabStop = false;
            grpHandleRequest.Text = "Maintanance Request";
            // 
            // btnExitHandleRequest
            // 
            btnExitHandleRequest.BackColor = Color.FromArgb(255, 224, 192);
            btnExitHandleRequest.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitHandleRequest.Location = new Point(488, 376);
            btnExitHandleRequest.Name = "btnExitHandleRequest";
            btnExitHandleRequest.Size = new Size(153, 41);
            btnExitHandleRequest.TabIndex = 28;
            btnExitHandleRequest.Text = "Exit";
            btnExitHandleRequest.UseVisualStyleBackColor = false;
            btnExitHandleRequest.Click += btnExitHandleRequest_Click;
            // 
            // btnDeclineRequest
            // 
            btnDeclineRequest.BackColor = Color.FromArgb(255, 224, 192);
            btnDeclineRequest.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnDeclineRequest.Location = new Point(299, 376);
            btnDeclineRequest.Name = "btnDeclineRequest";
            btnDeclineRequest.Size = new Size(153, 41);
            btnDeclineRequest.TabIndex = 27;
            btnDeclineRequest.Text = "Decline";
            btnDeclineRequest.UseVisualStyleBackColor = false;
            btnDeclineRequest.Click += btnDeclineRequest_Click;
            // 
            // btnApproveRequest
            // 
            btnApproveRequest.BackColor = Color.FromArgb(255, 224, 192);
            btnApproveRequest.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnApproveRequest.Location = new Point(104, 376);
            btnApproveRequest.Name = "btnApproveRequest";
            btnApproveRequest.Size = new Size(153, 41);
            btnApproveRequest.TabIndex = 26;
            btnApproveRequest.Text = "Approve";
            btnApproveRequest.UseVisualStyleBackColor = false;
            // 
            // handlemaintanancerequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitHandleRequest);
            Controls.Add(btnDeclineRequest);
            Controls.Add(btnApproveRequest);
            Controls.Add(grpHandleRequest);
            Controls.Add(panel1);
            Name = "handlemaintanancerequestForm";
            Text = "handlemaintanancerequestForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private GroupBox grpHandleRequest;
        private Button btnExitHandleRequest;
        private Button btnDeclineRequest;
        private Button btnApproveRequest;
    }
}