using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment
{
    internal class User
    {
        // private field
        private string username;
        private string password;
        private string role;

        // conection string to connect to sql database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        //properties with getter and setter which are username and password
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get{ return role; }
            set { role = value; }
        }

        //compiled all constructor under one constructor called User
        public User(string name, string password, string role)
        {
            this.username = name;
            this.password = password;
            this.role = role;
        }

        //add user
        public string addUser()
        {
            string status;
            //string MyQuery1

            con.Open();

            //cmd is to insert a record into users table
            SqlCommand cmd = new SqlCommand("Insert into Users(username, password, role) values(@name,@password,@role)", con);
            cmd.Parameters.AddWithValue("@name", this.username);
            cmd.Parameters.AddWithValue("@password", this.password);
            cmd.Parameters.AddWithValue("@role", this.role);
            
            // run the command
            int i = cmd.ExecuteNonQuery();

            // message if registration is successful or not
            if (i != 0)
            {
                status = "Registration Successsful";
            }
            else
            {
                status = "Unable to Register";
            }           
            return status;

            con.Close();
        }
    }
}
