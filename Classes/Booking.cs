using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int FacilityID { get; set; }
        public int StudentID { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan BookingTime { get; set; }
        public string Status { get; set; } 
        
        public string FacilityName { get; set; }

    }
}
