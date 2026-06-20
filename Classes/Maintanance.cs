using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment.Classes
{
    public class Maintanance
    {
        // field
        public string MaintenanceId;
        public string UniId;
        public string FacilitiesId;
        public string facility_category;
        public string maintanance_duration;
        public string maintanance_date;
        public string maintanance_technician;
        public string Status;

        // conection string to connect to sql database
        static SqlConnection con =
        new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // getter and setter accessors
        public string maintenanceid
        {
            get { return MaintenanceId; }
            set { MaintenanceId = value; }
        }
        public string uniId
        {
            get { return UniId; }
            set { UniId = value; }
        }

        public string facilitiesid
        {
            get { return FacilitiesId; }
            set { FacilitiesId = value; }
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

        public string status
        {
            get { return Status; }
            set { Status = value; }
        }

        //constructor 
        public Maintanance(string university, string facilitiesid, string duration, string date, string technician, string status)
        {
            UniId = university;
            FacilitiesId = facilitiesid;
            maintanance_duration = duration;
            maintanance_date = date;
            maintanance_technician = technician;
            Status = status;
        }

        //empty constructor
        public Maintanance() { }

        //add maintanance
        public string addMaintanance()
        {

            string message;
            //string MyQuery1

            con.Open();

            //cmd is to insert a record into users table
            SqlCommand cmd = new SqlCommand("Insert into maintanances(UniId, " +
                "facilitiesId, duration, date, technician) " +
                "values(@university,@facilityid,@duration," +
                "@date,@technician)", con);
            cmd.Parameters.AddWithValue("@university", UniId);
            cmd.Parameters.AddWithValue("@facilityid", facilitiesid);
            cmd.Parameters.AddWithValue("@duration", maintanance_duration);
            cmd.Parameters.AddWithValue("@date", maintanance_date);
            cmd.Parameters.AddWithValue("@technician", maintanance_technician);            

            // run the command
            int i = cmd.ExecuteNonQuery();

            // message if registration is successful or not
            if (i != 0)
            {
                message = "Added Maintanance Successsful";
            }
            else
            {
                message = "Unable to Add";
            }

            con.Close();
            return status;
        }

    }     
}
