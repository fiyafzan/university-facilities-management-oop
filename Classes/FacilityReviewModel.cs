using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment.Classes
{
    internal class FacilityReviewModel
    {
        public int ReviewID { get; set; }       // Primary key of review table
        public int FacilityID { get; set; }
        public int StudentID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DateReviewed { get; set; }

        // Navigation property (to show Facility info together)
        public string FacilityCategory { get; set; }

        // Constructor
        public FacilityReviewModel(int reviewId, int facilityId, int studentId, int rating, string comment, DateTime dateReviewed, string facilitycategory)
        {
            ReviewID = reviewId;
            FacilityID = facilityId;
            StudentID = studentId;
            Rating = rating;
            Comment = comment;
            DateReviewed = dateReviewed;
            FacilityCategory = facilitycategory;
        }

        // Empty constructor for data binding
        public FacilityReviewModel() { }
    }

}
