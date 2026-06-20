namespace ioopassignment
{
    partial class MaintainanceEquipmentRequest
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
            EquipmentName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpRequestDate = new DateTimePicker();
            btnAddItem = new Button();
            dgvSupplies = new DataGridView();
            cmbRequestType = new ComboBox();
            btnBackEqReq = new Button();
            cmbEquipmentName = new ComboBox();
            nmbQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvSupplies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmbQuantity).BeginInit();
            SuspendLayout();
            // 
            // EquipmentName
            // 
            EquipmentName.AutoSize = true;
            EquipmentName.Location = new Point(45, 89);
            EquipmentName.Name = "EquipmentName";
            EquipmentName.Size = new Size(122, 20);
            EquipmentName.TabIndex = 0;
            EquipmentName.Text = "Equipment name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 139);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 237);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Request Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 192);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Request Type";
            // 
            // dtpRequestDate
            // 
            dtpRequestDate.Location = new Point(173, 237);
            dtpRequestDate.Name = "dtpRequestDate";
            dtpRequestDate.Size = new Size(250, 27);
            dtpRequestDate.TabIndex = 6;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(314, 315);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(94, 29);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvSupplies
            // 
            dgvSupplies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplies.Location = new Point(453, 69);
            dgvSupplies.Name = "dgvSupplies";
            dgvSupplies.RowHeadersWidth = 51;
            dgvSupplies.Size = new Size(300, 275);
            dgvSupplies.TabIndex = 11;
            dgvSupplies.CellClick += dgvSupplies_CellClick;
            // 
            // cmbRequestType
            // 
            cmbRequestType.FormattingEnabled = true;
            cmbRequestType.Location = new Point(174, 189);
            cmbRequestType.Name = "cmbRequestType";
            cmbRequestType.Size = new Size(151, 28);
            cmbRequestType.TabIndex = 12;
            cmbRequestType.SelectedIndexChanged += cmbRequestType_SelectedIndexChanged;
            // 
            // btnBackEqReq
            // 
            btnBackEqReq.Location = new Point(647, 409);
            btnBackEqReq.Name = "btnBackEqReq";
            btnBackEqReq.Size = new Size(94, 29);
            btnBackEqReq.TabIndex = 13;
            btnBackEqReq.Text = "Back";
            btnBackEqReq.UseVisualStyleBackColor = true;
            btnBackEqReq.Click += btnBackEqReq_Click;
            // 
            // cmbEquipmentName
            // 
            cmbEquipmentName.FormattingEnabled = true;
            cmbEquipmentName.Location = new Point(173, 86);
            cmbEquipmentName.Name = "cmbEquipmentName";
            cmbEquipmentName.Size = new Size(151, 28);
            cmbEquipmentName.TabIndex = 14;
            // 
            // nmbQuantity
            // 
            nmbQuantity.Location = new Point(174, 139);
            nmbQuantity.Name = "nmbQuantity";
            nmbQuantity.Size = new Size(150, 27);
            nmbQuantity.TabIndex = 15;
            // 
            // MaintainanceEquipmentRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maintenance_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(nmbQuantity);
            Controls.Add(cmbEquipmentName);
            Controls.Add(btnBackEqReq);
            Controls.Add(cmbRequestType);
            Controls.Add(dgvSupplies);
            Controls.Add(btnAddItem);
            Controls.Add(dtpRequestDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(EquipmentName);
            DoubleBuffered = true;
            Name = "MaintainanceEquipmentRequest";
            Text = "Equipment Request";
            Load += MaintainanceEquipmentRequest_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplies).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmbQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EquipmentName;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpRequestDate;
        private Button btnAddItem;
        private DataGridView dgvSupplies;
        private ComboBox cmbRequestType;
        private Button btnBackEqReq;
        private ComboBox cmbEquipmentName;
        private NumericUpDown nmbQuantity;
    }
}