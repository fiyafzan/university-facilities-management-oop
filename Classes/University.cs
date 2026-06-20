using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment.Classes
{
    public class University
    {
        // private field
        private string uniName;

        // conection string to connect to sql database
        static SqlConnection con = 
        new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        // getter setter accessors
        public string UniName
        {
            get { return uniName; }
            set { uniName = value; }
        }

        public University(string uniName)
        {
            this.uniName = uniName;            
        }

        public string addUniversity()
        {
            string status;
            //string MyQuery1
            //
            con.Open();

            //cmd is to insert a record into users table
            SqlCommand cmd = 
            new SqlCommand("Insert into Universities(uniName) values(@uniName)", con);
            cmd.Parameters.AddWithValue("@uniName", uniName);           

            // run the command
            int i = cmd.ExecuteNonQuery();

            // message if registration is successful or not
            if (i != 0)
            {
                status = "Added University Successsful";
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
