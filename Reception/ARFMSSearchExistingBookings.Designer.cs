namespace iOOP_Receptionist
{
    partial class ARFMSExistingBookings
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
            SearchBtn = new Button();
            Searchtxt = new TextBox();
            Bookingdgv = new DataGridView();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Bookingdgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 35);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Search Bookings";
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(447, 97);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 29);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Searchtxt
            // 
            Searchtxt.Location = new Point(188, 99);
            Searchtxt.Margin = new Padding(3, 4, 3, 4);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.Size = new Size(245, 27);
            Searchtxt.TabIndex = 2;
            Searchtxt.Text = "Search by Booking ID or Student ID";
            // 
            // Bookingdgv
            // 
            Bookingdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Bookingdgv.Location = new Point(-1, 136);
            Bookingdgv.Margin = new Padding(3, 4, 3, 4);
            Bookingdgv.Name = "Bookingdgv";
            Bookingdgv.ReadOnly = true;
            Bookingdgv.RowHeadersWidth = 51;
            Bookingdgv.RowTemplate.Height = 24;
            Bookingdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Bookingdgv.Size = new Size(800, 245);
            Bookingdgv.TabIndex = 3;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(25, 51);
            backbtn.Margin = new Padding(3, 4, 3, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(149, 29);
            backbtn.TabIndex = 11;
            backbtn.Text = "Back to Home";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // ARFMSExistingBookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ioopassignment.Properties.Resources.reception_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 454);
            Controls.Add(backbtn);
            Controls.Add(Bookingdgv);
            Controls.Add(Searchtxt);
            Controls.Add(SearchBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ARFMSExistingBookings";
            Text = "ARFMS Search Existing Bookings";
            Load += ARFMSExistingBookings_Load;
            ((System.ComponentModel.ISupportInitialize)Bookingdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.DataGridView Bookingdgv;
        private System.Windows.Forms.Button backbtn;
    }
}