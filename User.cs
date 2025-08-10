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

        //
        public User(string name, string password)
        {
            this.username = name;
            this.password = password;
        }

        public string addUser()
        {
            string status;
            //

            con.Open();

        }
    }
}
