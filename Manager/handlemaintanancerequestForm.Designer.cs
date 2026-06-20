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
            btnExitHandleRequest = new Button();
            btnDeclineRequest = new Button();
            btnApproveRequest = new Button();
            btnSeeRequest = new Button();
            dataMaintananceReqDetails = new DataGridView();
            grpHandleRequest = new GroupBox();
            dataMaintananceReqDetails2 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMaintananceReqDetails).BeginInit();
            grpHandleRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMaintananceReqDetails2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(476, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 32);
            panel1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(306, 20);
            label4.TabIndex = 0;
            label4.Text = "ARFMS Handle Equipment Request Form";
            label4.Click += label4_Click;
            // 
            // btnExitHandleRequest
            // 
            btnExitHandleRequest.BackColor = Color.FromArgb(255, 224, 192);
            btnExitHandleRequest.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnExitHandleRequest.Location = new Point(492, 348);
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
            btnDeclineRequest.Location = new Point(303, 348);
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
            btnApproveRequest.Location = new Point(108, 348);
            btnApproveRequest.Name = "btnApproveRequest";
            btnApproveRequest.Size = new Size(153, 41);
            btnApproveRequest.TabIndex = 26;
            btnApproveRequest.Text = "Approve";
            btnApproveRequest.UseVisualStyleBackColor = false;
            btnApproveRequest.Click += btnApproveRequest_Click;
            // 
            // btnSeeRequest
            // 
            btnSeeRequest.BackColor = Color.FromArgb(255, 224, 192);
            btnSeeRequest.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSeeRequest.Location = new Point(367, 18);
            btnSeeRequest.Name = "btnSeeRequest";
            btnSeeRequest.Size = new Size(89, 35);
            btnSeeRequest.TabIndex = 29;
            btnSeeRequest.Text = "See";
            btnSeeRequest.UseVisualStyleBackColor = false;
            btnSeeRequest.Click += btnSeeMaintananceReq_Click;
            // 
            // dataMaintananceReqDetails
            // 
            dataMaintananceReqDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMaintananceReqDetails.Location = new Point(16, 26);
            dataMaintananceReqDetails.Name = "dataMaintananceReqDetails";
            dataMaintananceReqDetails.RowHeadersWidth = 51;
            dataMaintananceReqDetails.Size = new Size(499, 118);
            dataMaintananceReqDetails.TabIndex = 1;
            dataMaintananceReqDetails.CellContentClick += dataMaintananceReqDetails_CellContentClick;
            // 
            // grpHandleRequest
            // 
            grpHandleRequest.BackColor = Color.White;
            grpHandleRequest.Controls.Add(dataMaintananceReqDetails2);
            grpHandleRequest.Controls.Add(dataMaintananceReqDetails);
            grpHandleRequest.Location = new Point(112, 59);
            grpHandleRequest.Name = "grpHandleRequest";
            grpHandleRequest.Size = new Size(533, 269);
            grpHandleRequest.TabIndex = 25;
            grpHandleRequest.TabStop = false;
            grpHandleRequest.Text = "Equipment Request";
            grpHandleRequest.Enter += grpHandleRequest_Enter;
            // 
            // dataMaintananceReqDetails2
            // 
            dataMaintananceReqDetails2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMaintananceReqDetails2.Location = new Point(16, 145);
            dataMaintananceReqDetails2.Name = "dataMaintananceReqDetails2";
            dataMaintananceReqDetails2.RowHeadersWidth = 51;
            dataMaintananceReqDetails2.Size = new Size(499, 118);
            dataMaintananceReqDetails2.TabIndex = 2;
            // 
            // handlemaintanancerequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_08_12_093429;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeeRequest);
            Controls.Add(btnExitHandleRequest);
            Controls.Add(btnDeclineRequest);
            Controls.Add(btnApproveRequest);
            Controls.Add(grpHandleRequest);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "handlemaintanancerequestForm";
            Text = "handlemaintanancerequestForm";
            Load += handlemaintanancerequestForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataMaintananceReqDetails).EndInit();
            grpHandleRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataMaintananceReqDetails2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button btnExitHandleRequest;
        private Button btnDeclineRequest;
        private Button btnApproveRequest;
        private Button btnSeeRequest;
        private DataGridView dataMaintananceReqDetails;
        private GroupBox grpHandleRequest;
        private DataGridView dataMaintananceReqDetails2;
    }
}