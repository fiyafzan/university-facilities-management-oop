namespace ioopassignment
{
    partial class FacilityReview
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
            FacilityReviewLbl = new Label();
            RatingLbl = new Label();
            ReviewLbl = new Label();
            btnSubmitReview = new Button();
            btnBack = new Button();
            cmbFacilities = new ComboBox();
            numRating = new NumericUpDown();
            txtReview = new TextBox();
            dgvReview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReview).BeginInit();
            SuspendLayout();
            // 
            // FacilityReviewLbl
            // 
            FacilityReviewLbl.AutoSize = true;
            FacilityReviewLbl.Location = new Point(45, 70);
            FacilityReviewLbl.Name = "FacilityReviewLbl";
            FacilityReviewLbl.Size = new Size(57, 20);
            FacilityReviewLbl.TabIndex = 0;
            FacilityReviewLbl.Text = "Facility:";
            // 
            // RatingLbl
            // 
            RatingLbl.AutoSize = true;
            RatingLbl.Location = new Point(45, 147);
            RatingLbl.Name = "RatingLbl";
            RatingLbl.Size = new Size(91, 20);
            RatingLbl.TabIndex = 1;
            RatingLbl.Text = "Rating (1-5):";
            // 
            // ReviewLbl
            // 
            ReviewLbl.AutoSize = true;
            ReviewLbl.Location = new Point(45, 237);
            ReviewLbl.Name = "ReviewLbl";
            ReviewLbl.Size = new Size(59, 20);
            ReviewLbl.TabIndex = 2;
            ReviewLbl.Text = "Review:";
            // 
            // btnSubmitReview
            // 
            btnSubmitReview.Location = new Point(45, 330);
            btnSubmitReview.Name = "btnSubmitReview";
            btnSubmitReview.Size = new Size(94, 29);
            btnSubmitReview.TabIndex = 3;
            btnSubmitReview.Text = "Submit";
            btnSubmitReview.UseVisualStyleBackColor = true;
            btnSubmitReview.Click += btnSubmitReview_Click_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(657, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbFacilities
            // 
            cmbFacilities.FormattingEnabled = true;
            cmbFacilities.Location = new Point(45, 103);
            cmbFacilities.Name = "cmbFacilities";
            cmbFacilities.Size = new Size(174, 28);
            cmbFacilities.TabIndex = 5;
            // 
            // numRating
            // 
            numRating.Location = new Point(45, 187);
            numRating.Name = "numRating";
            numRating.Size = new Size(173, 27);
            numRating.TabIndex = 6;
            numRating.ValueChanged += numRating_ValueChanged;
            // 
            // txtReview
            // 
            txtReview.Location = new Point(45, 273);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(173, 27);
            txtReview.TabIndex = 7;
            // 
            // dgvReview
            // 
            dgvReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReview.Location = new Point(282, 70);
            dgvReview.Name = "dgvReview";
            dgvReview.RowHeadersWidth = 51;
            dgvReview.Size = new Size(469, 289);
            dgvReview.TabIndex = 8;
            dgvReview.CellClick += dgvReview_CellClick;
            dgvReview.CellContentClick += dgvReview_CellContentClick;
            // 
            // FacilityReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gray_Peach_Purple_Green_Modern_Product_Launch_Plan_Presentation;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReview);
            Controls.Add(txtReview);
            Controls.Add(numRating);
            Controls.Add(cmbFacilities);
            Controls.Add(btnBack);
            Controls.Add(btnSubmitReview);
            Controls.Add(ReviewLbl);
            Controls.Add(RatingLbl);
            Controls.Add(FacilityReviewLbl);
            DoubleBuffered = true;
            Name = "FacilityReview";
            Text = "FacilityReview";
            Load += FacilityReview_Load;
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FacilityReviewLbl;
        private Label RatingLbl;
        private Label ReviewLbl;
        private Button btnSubmitReview;
        private Button btnBack;
        private ComboBox cmbFacilities;
        private NumericUpDown numRating;
        private TextBox txtReview;
        private DataGridView dgvReview;
    }
}