using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace iOOP_Receptionist
{
    public partial class ARFMSReviewRating : Form
    {
        public ARFMSReviewRating()
        {
            InitializeComponent();
            //clear the text box for Search
            Searchtxt.Enter += (s, args) =>
            {
                if (Searchtxt.Text == "Search by Review ID or Facility ID")
                    Searchtxt.Text = "";
            };
            {
                if (string.IsNullOrEmpty(Searchtxt.Text))
                    Searchtxt.Text = "Search by Review ID or Facility ID";
            }
            ;
        }

        private void ARFMSReviewRating_Load(object sender, EventArgs e)
        {
            LoadReviews(""); // Load all reviews when form opens
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = Searchtxt.Text.Trim();
            LoadReviews(searchText);
        }

        private void LoadReviews(string searchText)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Base query (table names: Review, facility)
                    string query = @"
                        SELECT r.ReviewId, 
                               r.StudentId, 
                               r.FacilityId, 
                               r.Rating, 
                               r.Comment, 
                               r.DateReviewed, 
                               f.[facility category] AS [Facility Name]
                        FROM FacilityReview r
                        LEFT JOIN facilities f ON r.FacilityId = f.FacilitiesId
                        WHERE 1=1";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    if (!string.IsNullOrEmpty(searchText) && searchText != "Search by Student ID or Facility ID")
                    {
                        if (int.TryParse(searchText, out int id))
                        {
                            query += " AND (r.ReviewId = @id OR r.FacilityID = @id)";
                            cmd.Parameters.AddWithValue("@id", id);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a numeric Student ID or Facility ID.");
                            return;
                        }
                    }

                    cmd.CommandText = query;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    Reviewdgv.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No reviews found.");
                    }

                    // Auto formatting
                    Reviewdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (Reviewdgv.Columns["DateReviewed"] != null)
                        Reviewdgv.Columns["DateReviewed"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reviews: " + ex.Message);
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReceptionForm receptionForm = new ReceptionForm();
            receptionForm.ShowDialog();
        }
    }
}
