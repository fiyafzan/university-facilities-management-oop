namespace ioopassignment
{
    partial class FacilityBooking
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
            FacilityLbl = new Label();
            DateLbl = new Label();
            TimeLbl = new Label();
            btnAddBooking = new Button();
            btnEditBooking = new Button();
            btnDeleteBooking = new Button();
            MyBookingLbl = new Label();
            btnBack = new Button();
            dgvBookings = new DataGridView();
            cmbFacility = new ComboBox();
            dtpDate = new DateTimePicker();
            cmbTime = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // FacilityLbl
            // 
            FacilityLbl.AutoSize = true;
            FacilityLbl.Location = new Point(51, 72);
            FacilityLbl.Name = "FacilityLbl";
            FacilityLbl.Size = new Size(57, 20);
            FacilityLbl.TabIndex = 0;
            FacilityLbl.Text = "Facility:";
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Location = new Point(51, 122);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(44, 20);
            DateLbl.TabIndex = 1;
            DateLbl.Text = "Date:";
            // 
            // TimeLbl
            // 
            TimeLbl.AutoSize = true;
            TimeLbl.Location = new Point(51, 176);
            TimeLbl.Name = "TimeLbl";
            TimeLbl.Size = new Size(45, 20);
            TimeLbl.TabIndex = 2;
            TimeLbl.Text = "Time:";
            // 
            // btnAddBooking
            // 
            btnAddBooking.Location = new Point(51, 227);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(165, 29);
            btnAddBooking.TabIndex = 3;
            btnAddBooking.Text = "Add Booking";
            btnAddBooking.UseVisualStyleBackColor = true;
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // btnEditBooking
            // 
            btnEditBooking.Location = new Point(323, 227);
            btnEditBooking.Name = "btnEditBooking";
            btnEditBooking.Size = new Size(146, 29);
            btnEditBooking.TabIndex = 4;
            btnEditBooking.Text = "Edit Booking";
            btnEditBooking.UseVisualStyleBackColor = true;
            btnEditBooking.Click += btnEditBooking_Click;
            // 
            // btnDeleteBooking
            // 
            btnDeleteBooking.Location = new Point(566, 227);
            btnDeleteBooking.Name = "btnDeleteBooking";
            btnDeleteBooking.Size = new Size(137, 29);
            btnDeleteBooking.TabIndex = 5;
            btnDeleteBooking.Text = "Delete Booking";
            btnDeleteBooking.UseVisualStyleBackColor = true;
            btnDeleteBooking.Click += btnDeleteBooking_Click;
            // 
            // MyBookingLbl
            // 
            MyBookingLbl.AutoSize = true;
            MyBookingLbl.Location = new Point(51, 279);
            MyBookingLbl.Name = "MyBookingLbl";
            MyBookingLbl.Size = new Size(91, 20);
            MyBookingLbl.TabIndex = 6;
            MyBookingLbl.Text = "My Booking:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(626, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(181, 279);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.Size = new Size(456, 117);
            dgvBookings.TabIndex = 8;
            dgvBookings.CellClick += dgvBookings_CellClick;
            // 
            // cmbFacility
            // 
            cmbFacility.FormattingEnabled = true;
            cmbFacility.Location = new Point(140, 69);
            cmbFacility.Name = "cmbFacility";
            cmbFacility.Size = new Size(151, 28);
            cmbFacility.TabIndex = 9;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(140, 122);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 10;
            // 
            // cmbTime
            // 
            cmbTime.FormattingEnabled = true;
            cmbTime.Location = new Point(140, 173);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(151, 28);
            cmbTime.TabIndex = 11;
            // 
            // FacilityBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gray_Peach_Purple_Green_Modern_Product_Launch_Plan_Presentation;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbTime);
            Controls.Add(dtpDate);
            Controls.Add(cmbFacility);
            Controls.Add(dgvBookings);
            Controls.Add(btnBack);
            Controls.Add(MyBookingLbl);
            Controls.Add(btnDeleteBooking);
            Controls.Add(btnEditBooking);
            Controls.Add(btnAddBooking);
            Controls.Add(TimeLbl);
            Controls.Add(DateLbl);
            Controls.Add(FacilityLbl);
            DoubleBuffered = true;
            Name = "FacilityBooking";
            Text = "FacilityBooking";
            Load += FacilityBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FacilityLbl;
        private Label DateLbl;
        private Label TimeLbl;
        private Button btnAddBooking;
        private Button btnEditBooking;
        private Button btnDeleteBooking;
        private Label MyBookingLbl;
        private Button btnBack;
        private DataGridView dgvBookings;
        private ComboBox cmbFacility;
        private DateTimePicker dtpDate;
        private ComboBox cmbTime;
    }
}