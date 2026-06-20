namespace ioopassignment
{
    partial class MaintainanceReplacementRequest
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
            btnSubmitRequest = new Button();
            btnCancelRequest = new Button();
            btnBackReplacementRequest = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpRequestDate = new DateTimePicker();
            dgvRequests = new DataGridView();
            cmbRepairType = new ComboBox();
            txtProblemDesc = new TextBox();
            txtEquipName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Location = new Point(111, 328);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(126, 29);
            btnSubmitRequest.TabIndex = 0;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // btnCancelRequest
            // 
            btnCancelRequest.Location = new Point(331, 328);
            btnCancelRequest.Name = "btnCancelRequest";
            btnCancelRequest.Size = new Size(126, 29);
            btnCancelRequest.TabIndex = 1;
            btnCancelRequest.Text = "Cancel Request";
            btnCancelRequest.UseVisualStyleBackColor = true;
            btnCancelRequest.Click += btnCancelRequest_Click;
            // 
            // btnBackReplacementRequest
            // 
            btnBackReplacementRequest.Location = new Point(641, 409);
            btnBackReplacementRequest.Name = "btnBackReplacementRequest";
            btnBackReplacementRequest.Size = new Size(94, 29);
            btnBackReplacementRequest.TabIndex = 2;
            btnBackReplacementRequest.Text = "Back";
            btnBackReplacementRequest.UseVisualStyleBackColor = true;
            btnBackReplacementRequest.Click += btnBackReplacementRequest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 80);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 3;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 144);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 4;
            label2.Text = "Request Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 281);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 5;
            label3.Text = "Problem Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 211);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 6;
            label4.Text = "Request Date";
            // 
            // dtpRequestDate
            // 
            dtpRequestDate.Location = new Point(207, 206);
            dtpRequestDate.Name = "dtpRequestDate";
            dtpRequestDate.Size = new Size(250, 27);
            dtpRequestDate.TabIndex = 10;
            // 
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(456, 73);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.Size = new Size(300, 188);
            dgvRequests.TabIndex = 11;
            dgvRequests.CellContentClick += dgvRequests_CellContentClick;
            // 
            // cmbRepairType
            // 
            cmbRepairType.FormattingEnabled = true;
            cmbRepairType.Items.AddRange(new object[] { "Repair", "Replace", "Upgrade" });
            cmbRepairType.Location = new Point(212, 144);
            cmbRepairType.Name = "cmbRepairType";
            cmbRepairType.Size = new Size(151, 28);
            cmbRepairType.TabIndex = 13;
            cmbRepairType.SelectedIndexChanged += cmbRepairType_SelectedIndexChanged;
            // 
            // txtProblemDesc
            // 
            txtProblemDesc.Location = new Point(212, 278);
            txtProblemDesc.Name = "txtProblemDesc";
            txtProblemDesc.Size = new Size(125, 27);
            txtProblemDesc.TabIndex = 14;
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(212, 80);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(125, 27);
            txtEquipName.TabIndex = 15;
            // 
            // MaintainanceReplacementRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maintenance_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEquipName);
            Controls.Add(txtProblemDesc);
            Controls.Add(cmbRepairType);
            Controls.Add(dgvRequests);
            Controls.Add(dtpRequestDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBackReplacementRequest);
            Controls.Add(btnCancelRequest);
            Controls.Add(btnSubmitRequest);
            DoubleBuffered = true;
            Name = "MaintainanceReplacementRequest";
            Text = "MaintainanceReplacementRequest";
            Load += MaintainanceReplacementRequest_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmitRequest;
        private Button btnCancelRequest;
        private Button btnBackReplacementRequest;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
       
        private DateTimePicker dtpRequestDate;
        private DataGridView dgvRequests;
        
        private ComboBox cmbRepairType;
        private TextBox txtProblemDesc;
        private TextBox txtEquipName;
    }
}