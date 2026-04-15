using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_tutorial

{
    public class UsrClass
    {
        // this class sets up all of the personal information into the Usr variable which would be used in the SQL query
        string username;
        string password;
        int distance_travelled;
        public UsrClass() 
        { 

        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int DistanceTravelled
        {
            get { return distance_travelled; }
            set { distance_travelled = value; }
        }
    }
}
