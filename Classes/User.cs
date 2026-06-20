using iOOP_Receptionist;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioopassignment.Classes
{
    internal class User
    {
        // private field
        private string username;
        private string password;
        private string role;

        // conection string to connect to sql database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        string connString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

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
            get { return role; }
            set { role = value; }
        }

        //compiled all under one constructor
        public User(string name, string password, string role)
        {
            username = name;
            this.password = password;
            this.role = role;
        }

        public User(string name, string password)
        {
            username = name;
            this.password = password;
        }

        // member method called addUser 
        public string addUser()
        {
            string status;
            //string MyQuery1

            con.Open();

            //cmd is to insert a record into users table
            SqlCommand cmd =
            new SqlCommand("Insert into Users(username, password, role) values(@name,@password,@role)", con);
            cmd.Parameters.AddWithValue("@name", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", role);

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

            con.Close();
            return status;
        }

        public string Login(Form loginForm, string un)
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from users where username=@a and password=@b", con);
            cmd.Parameters.AddWithValue("@a", username);
            cmd.Parameters.AddWithValue("@b", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)//if login success
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username =@a and password =@b", con);
                cmd2.Parameters.AddWithValue("@a", username);
                cmd2.Parameters.AddWithValue("@b", password);

                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "receptionist")
                {
                    loginForm.Hide();
                    //redirect to reception form
                    ReceptionForm a = new ReceptionForm(un);
                    a.ShowDialog();
                }
                else if (userRole == "student")
                {
                    loginForm.Hide();
                    StudentForm b = new StudentForm(0.ToString());
                    b.ShowDialog();
                }
                else if (userRole == "manager")
                {
                    loginForm.Hide();
                    managerForm c = new managerForm();
                    c.ShowDialog();
                }
                else if (userRole == "maintenance")
                {
                    loginForm.Hide();
                    MaintainanceForm d = new MaintainanceForm();
                    d.ShowDialog();
                }
            }
            else
            {
                status = "Incorrect username/password";
            }
            con.Close();

            return status;
            //status = null if login success
            //status = "Incorrect username/password" if login fail.
        }
               
                
        public static void Logout()
        {
            CurrentUser.Clear();
        }
}

    }
    
