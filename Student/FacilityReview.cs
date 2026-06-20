using ioopassignment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ioopassignment
{
    public partial class FacilityReview : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();       
        private int selectedReviewId = -1; // Track which review is being edited

        private int loggedInUserId;
        public FacilityReview(int userID)
        {
            InitializeComponent();
            this.loggedInUserId = userID;
        }


        private void FacilityReview_Load(object sender, EventArgs e)
        {
            LoadFacilities();
            LoadReviews();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentForm menu = new StudentForm(loggedInUserId.ToString());
            menu.Show();
            this.Hide();
        }

        private void btnSubmitReview_Click_1(object sender, EventArgs e)
        {
            if (cmbFacilities.SelectedValue == null) return;

            int facilityId = Convert.ToInt32(cmbFacilities.SelectedValue);
            int rating = (int)numRating.Value;
            string comment = txtReview.Text;

            var reviewService = new ReviewService(connectionString);

            if (selectedReviewId == -1)
            {
                // Insert new review
                reviewService.AddReview(facilityId, loggedInUserId, rating, comment);
                MessageBox.Show(" Review added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Update existing review
                reviewService.UpdateReview(selectedReviewId, facilityId, loggedInUserId, rating, comment);
                MessageBox.Show(" Review updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadReviews();
            ClearForm();
        }


        private void dgvReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void numRating_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void LoadFacilities()
        {
            var facilities = GetFacilities();

            cmbFacilities.DataSource = facilities;
            cmbFacilities.DisplayMember = "facility category";
            cmbFacilities.ValueMember = "facilityid";
        }

        private void LoadReviews()
        {
            dgvReview.DataSource = GetReviews();
        }

        private void ClearForm()
        {
            cmbFacilities.SelectedIndex = 0;
            numRating.Value = 1;
            txtReview.Clear();
            selectedReviewId = -1;
        }

        private List<Facility> GetFacilities()
        {
            var facilities = new List<Facility>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT FacilitiesId, Uniid, [facility category], [facility rate (/hr)], capacity, [availability (y/n)] FROM facilities";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        facilities.Add(new Facility
                        {
                            facilityid = Convert.ToInt32(reader["FacilitiesId"]),
                            uniid = reader["Uniid"].ToString(),
                            Facility_category = reader["facility category"].ToString(),
                            Facility_rate = reader["facility rate (/hr)"].ToString(),   // int in DB
                            Facility_capacity = reader["capacity"].ToString(),
                            Facility_availability = reader["availability (y/n)"].ToString()
                        });
                    }
                }
            }
            return facilities;
        }

        private List<FacilityReviewModel> GetReviews()
        {
            var reviews = new List<FacilityReviewModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
            SELECT r.ReviewID, r.FacilityID, r.StudentID, r.Rating, r.Comment, r.DateReviewed,
                   f.[facility category] AS FacilityType
            FROM FacilityReview r
            LEFT JOIN facilities f ON r.FacilityID = f.FacilitiesID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reviews.Add(new FacilityReviewModel
                        {
                            ReviewID = Convert.ToInt32(reader["ReviewID"]),
                            FacilityID = Convert.ToInt32(reader["FacilityID"]),
                            StudentID = Convert.ToInt32(reader["StudentID"]),
                            Rating = Convert.ToInt32(reader["Rating"]),
                            Comment = reader["Comment"].ToString(),
                            DateReviewed = Convert.ToDateTime(reader["DateReviewed"]),
                            FacilityCategory = reader["FacilityType"].ToString()
                        });
                    }
                }
            }

            return reviews;
        }

        public class ReviewService
        {
            private readonly string connectionString;

            public ReviewService(string connString)
            {
                connectionString = connString;
            }

            public void AddReview(int facilityId, int studentId, int rating, string comment)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO FacilityReview (FacilityID, StudentID, Rating, Comment, DateReviewed)
                           VALUES (@fid, @uid, @rating, @comment, @date)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@fid", facilityId);
                        cmd.Parameters.AddWithValue("@uid", studentId);
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Parameters.AddWithValue("@comment", comment);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void UpdateReview(int reviewId, int facilityId, int studentId, int rating, string comment)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE FacilityReview
                           SET FacilityID=@fid, Rating=@rating, Comment=@comment, DateReviewed=@date
                           WHERE ReviewID=@rid AND StudentID=@uid";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@fid", facilityId);
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Parameters.AddWithValue("@comment", comment);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@rid", reviewId);
                        cmd.Parameters.AddWithValue("@uid", studentId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }


        }

    }
}
