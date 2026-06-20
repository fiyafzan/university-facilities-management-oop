namespace ioopassignment
{
    partial class MaintainanceUpdateStatus
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
            cmbTask = new ComboBox();
            btnUpdateStatus = new Button();
            btnMBackUpdateStatus = new Button();
            dgvTasks = new DataGridView();
            cmbNewStatus = new ComboBox();
            dtpCompletionDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 72);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Select Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 118);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "New Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 163);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Completion Date";
            // 
            // cmbTask
            // 
            cmbTask.FormattingEnabled = true;
            cmbTask.Location = new Point(162, 69);
            cmbTask.Name = "cmbTask";
            cmbTask.Size = new Size(151, 28);
            cmbTask.TabIndex = 6;
            cmbTask.SelectedIndexChanged += cmbTask_SelectedIndexChanged;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(487, 154);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(94, 29);
            btnUpdateStatus.TabIndex = 7;
            btnUpdateStatus.Text = "Update";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnMBackUpdateStatus
            // 
            btnMBackUpdateStatus.Location = new Point(655, 415);
            btnMBackUpdateStatus.Name = "btnMBackUpdateStatus";
            btnMBackUpdateStatus.Size = new Size(75, 23);
            btnMBackUpdateStatus.TabIndex = 13;
            btnMBackUpdateStatus.Text = "Back";
            btnMBackUpdateStatus.Click += btnMaintUpdateMenu_Click_1;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(48, 215);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(682, 173);
            dgvTasks.TabIndex = 9;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            // 
            // cmbNewStatus
            // 
            cmbNewStatus.FormattingEnabled = true;
            cmbNewStatus.Location = new Point(162, 115);
            cmbNewStatus.Name = "cmbNewStatus";
            cmbNewStatus.Size = new Size(151, 28);
            cmbNewStatus.TabIndex = 11;
            // 
            // dtpCompletionDate
            // 
            dtpCompletionDate.Location = new Point(177, 158);
            dtpCompletionDate.Name = "dtpCompletionDate";
            dtpCompletionDate.Size = new Size(250, 27);
            dtpCompletionDate.TabIndex = 12;
            // 
            // MaintainanceUpdateStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maintenance_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpCompletionDate);
            Controls.Add(cmbNewStatus);
            Controls.Add(dgvTasks);
            Controls.Add(btnMBackUpdateStatus);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbTask);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "MaintainanceUpdateStatus";
            Text = "MaintainanceUpdateStatus";
            Load += MaintainanceUpdateStatus_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbTask;
        private Button btnUpdateStatus;
        private Button btnMBackUpdateStatus;
        private DataGridView dgvTasks;
        private ComboBox cmbNewStatus;
        private DateTimePicker dtpCompletionDate;
    }
}