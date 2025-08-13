using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ioopassignment
{
    internal class Facility
    {
        // private field
        private string university;
        private string facility_category;
        private string facility_rate;
        private string facility_capacity;
        private string facility_availability;

        //properties with getter and setter which are username and password
        public string University
        {
            get { return university; }
            set { university = value; }
        }

        public string Facility_category
        {
            get { return facility_category; }
            set { facility_category = value; }
        }

        public string Facility_rate
        {
            get { return facility_rate; }
            set { facility_rate = value; }
        }
        public string Facility_capacity
        {
            get { return facility_capacity; }
            set { facility_capacity = value; }
        }

        public string Facility_availability
        {
            get { return facility_availability; }
            set { facility_availability = value; }
        }

        //compiled all constructor under one constructor called User
        public Facility(string university, string facilitycategory, string facilityrate, string capacity, string availability)
        {
            this.university = university;
            this.facility_category = facilitycategory;
            this.facility_rate = facilityrate;
            this.facility_capacity = capacity;
            this.facility_availability = availability;
        }


        // conection string to connect to sql database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //add facility
        public string addFacility()
        {

            string status;
            //string MyQuery1

            con.Open();

            //cmd is to insert a record into users table
            SqlCommand cmd = new SqlCommand("Insert into facilities(university, [facility category], [facility rate (/hr)], capacity, [availability (y/n)]) values(@university,@facilitycategory,@facilityrate,@capacity,@availability)", con);
            cmd.Parameters.AddWithValue("@university", this.university);
            cmd.Parameters.AddWithValue("@facilitycategory", this.facility_category);
            cmd.Parameters.AddWithValue("@facilityrate", this.facility_rate);
            cmd.Parameters.AddWithValue("@capacity", this.facility_capacity);
            cmd.Parameters.AddWithValue("@availability", this.facility_availability);

            // run the command
            int i = cmd.ExecuteNonQuery();

            // message if registration is successful or not
            if (i != 0)
            {
                status = "Added Facility Successsful";
            }
            else
            {
                status = "Unable to Add";
            }
            return status;
            con.Close();
        }
    }
}
