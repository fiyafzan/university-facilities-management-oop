using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment
{
    internal class Maintanance
    {
        // private field
        private string UniId;
        private string facility_category;
        private string maintanance_duration;
        private string maintanance_date;
        private string maintanance_technician;

        // conection string to connect to sql database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // constructor getter setter
        public string uniId
        { 
            get { return UniId; }
            set { UniId = value; }
        }

        public string Facility_category
        { 
            get { return facility_category; }
            set { facility_category = value; }
        }

        public string Maintanance_duration
        {
            get { return maintanance_duration; }
            set { maintanance_duration = value; }
        }

        public string Maintanance_date
        {
            get { return maintanance_date; }
            set { maintanance_date = value; }
        }

        public string Maintanance_technician
        {
            get { return maintanance_technician; }
            set { maintanance_technician = value; }
        }

        public Maintanance(string  university, string facilitycategory, string duration, string date, string technician)
        {
            this.UniId = university;
            this.facility_category = facilitycategory;
            this.maintanance_duration = duration;
            this.maintanance_date = date;
            this.maintanance_technician = technician;
        }

        //add maintanance
        public string addMaintanance()
        {

            string status;
            //string MyQuery1

            con.Open();

            //cmd is to insert a record into users table
            SqlCommand cmd = new SqlCommand("Insert into maintanances(UniId, [facility category], duration, date, technician) values(@university,@facilitycategory,@duration,@date,@technician)", con);
            cmd.Parameters.AddWithValue("@university", this.UniId);
            cmd.Parameters.AddWithValue("@facilitycategory", this.facility_category);
            cmd.Parameters.AddWithValue("@duration", this.maintanance_duration);
            cmd.Parameters.AddWithValue("@date", this.maintanance_date);
            cmd.Parameters.AddWithValue("@technician", this.maintanance_technician);

            // run the command
            int i = cmd.ExecuteNonQuery();

            // message if registration is successful or not
            if (i != 0)
            {
                status = "Added Maintanance Successsful";
            }
            else
            {
                status = "Unable to Add";
            }

            con.Close();
            return status;            
        }
    }
}
