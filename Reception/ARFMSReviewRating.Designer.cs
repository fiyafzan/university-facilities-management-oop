namespace iOOP_Receptionist
{
    partial class ARFMSReviewRating
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
            Reviewdgv = new DataGridView();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Reviewdgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(563, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 0;
            label1.Text = "Review Ratings";
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(487, 78);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 29);
            SearchBtn.TabIndex = 4;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Searchtxt
            // 
            Searchtxt.Location = new Point(222, 78);
            Searchtxt.Margin = new Padding(3, 4, 3, 4);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.Size = new Size(210, 27);
            Searchtxt.TabIndex = 5;
            Searchtxt.Text = "Search by Review ID or Facility ID";
            // 
            // Reviewdgv
            // 
            Reviewdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Reviewdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Reviewdgv.Location = new Point(12, 115);
            Reviewdgv.Margin = new Padding(3, 4, 3, 4);
            Reviewdgv.Name = "Reviewdgv";
            Reviewdgv.ReadOnly = true;
            Reviewdgv.RowHeadersWidth = 51;
            Reviewdgv.RowTemplate.Height = 24;
            Reviewdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Reviewdgv.Size = new Size(776, 267);
            Reviewdgv.TabIndex = 6;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(41, 49);
            backbtn.Margin = new Padding(3, 4, 3, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(149, 29);
            backbtn.TabIndex = 13;
            backbtn.Text = "Back to Home";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // ARFMSReviewRating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ioopassignment.Properties.Resources.reception_background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 448);
            Controls.Add(backbtn);
            Controls.Add(Reviewdgv);
            Controls.Add(Searchtxt);
            Controls.Add(SearchBtn);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ARFMSReviewRating";
            Text = "ARFMS Review Rating";
            Load += ARFMSReviewRating_Load;
            ((System.ComponentModel.ISupportInitialize)Reviewdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.DataGridView Reviewdgv;
        private System.Windows.Forms.Button backbtn;
    }
}