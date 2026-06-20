namespace ioopassignment
{
    partial class MaintainanceViewSchedule
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
            label2 = new Label();
            label3 = new Label();
            dtpSearchDate = new DateTimePicker();
            txtFacilitySearch = new TextBox();
            cmbStatusFilter = new ComboBox();
            btnSearchSchdule = new Button();
            dgvSchedule = new DataGridView();
            btnScheduleBack = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 75);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Search by Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 164);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 1;
            label2.Text = "Search by Facility:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 257);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Status Filter:";
            // 
            // dtpSearchDate
            // 
            dtpSearchDate.Location = new Point(42, 109);
            dtpSearchDate.Name = "dtpSearchDate";
            dtpSearchDate.Size = new Size(250, 27);
            dtpSearchDate.TabIndex = 3;
            // 
            // txtFacilitySearch
            // 
            txtFacilitySearch.Location = new Point(42, 202);
            txtFacilitySearch.Name = "txtFacilitySearch";
            txtFacilitySearch.Size = new Size(250, 27);
            txtFacilitySearch.TabIndex = 4;
            txtFacilitySearch.TextChanged += txtFacilitySearch_TextChanged;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Location = new Point(42, 293);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(250, 28);
            cmbStatusFilter.TabIndex = 5;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // btnSearchSchdule
            // 
            btnSearchSchdule.Location = new Point(42, 354);
            btnSearchSchdule.Name = "btnSearchSchdule";
            btnSearchSchdule.Size = new Size(94, 29);
            btnSearchSchdule.TabIndex = 6;
            btnSearchSchdule.Text = "Search";
            btnSearchSchdule.UseVisualStyleBackColor = true;
            btnSearchSchdule.Click += btnSearchSchdule_Click;
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(413, 109);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.Size = new Size(300, 212);
            dgvSchedule.TabIndex = 7;
            dgvSchedule.CellContentClick += dgvSchedule_CellContentClick;
            // 
            // btnScheduleBack
            // 
            btnScheduleBack.Location = new Point(638, 409);
            btnScheduleBack.Name = "btnScheduleBack";
            btnScheduleBack.Size = new Size(94, 29);
            btnScheduleBack.TabIndex = 8;
            btnScheduleBack.Text = "Back";
            btnScheduleBack.UseVisualStyleBackColor = true;
            btnScheduleBack.Click += btnScheduleBack_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(198, 354);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // MaintainanceViewSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maintenance_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnScheduleBack);
            Controls.Add(dgvSchedule);
            Controls.Add(btnSearchSchdule);
            Controls.Add(cmbStatusFilter);
            Controls.Add(txtFacilitySearch);
            Controls.Add(dtpSearchDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "MaintainanceViewSchedule";
            Text = "View Schedule";
            Load += MaintainanceViewSchedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpSearchDate;
        private TextBox txtFacilitySearch;
        private ComboBox cmbStatusFilter;
        private Button btnSearchSchdule;
        private DataGridView dgvSchedule;
        private Button btnScheduleBack;
        private Button btnReset;
    }
}