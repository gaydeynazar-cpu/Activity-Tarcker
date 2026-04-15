using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace login_tutorial
{
    internal class DatabaseClass
    {
        public void DeleteUser(string un)
        {
            // this code is for deleting the user and all his personal information from the data table
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectDatabase;Integrated Security=True;Encrypt=False";
            string SQLCommand = "delete from Users where username = @un";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = SQLCommand;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@un", un);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable getJourneyHistory(string un)
        {
            // this function fetches all the necessary data from the Journey table that would be displayed on journey history
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataadpeter = new SqlDataAdapter();
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectDatabase;Integrated Security=True;Encrypt=False";
            string SQLCommand = "select Distance_Travelled, Total_Time, Date from journey where @user = userid";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = SQLCommand;
            dataadpeter.SelectCommand = command;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user", un);
            command.ExecuteNonQuery();
            dataadpeter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
        public void addNewJourney(string un, float dist, string time, DateTime date)
        {
            // this subroutine registers the last journey that the user has taken into the journey table
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectDatabase;Integrated Security=True;Encrypt=False";
            string SQLCommand = "insert into journey (userid, Distance_Travelled, Total_Time, Date) values (@un, @dist, @time, @date)";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = SQLCommand;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@un", un);
            command.Parameters.AddWithValue("@dist", dist);
            command.Parameters.AddWithValue("@time", time);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable getdist()
        {
            // This function fetches distance from all users and orders them in the descending order to create the leader board display.
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataadpeter = new SqlDataAdapter();
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectDatabase;Integrated Security=True;Encrypt=False";
            string SQLCommand = "select username, Total_Distance from Users Order By Total_Distance desc";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = SQLCommand;
            dataadpeter.SelectCommand = command;
            command.ExecuteNonQuery();
            dataadpeter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public DataTable getWeeklydist()
        {
            //this function fetches distance travelled from the Users table and the Journey table to be able to add the total distance travelled 7 days ago from now
            DateTime dateNow = DateTime.Now;
            DateTime weekago = dateNow.AddDays(-7);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataadpeter = new SqlDataAdapter();
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectDatabase;Integrated Security=True;Encrypt=False";
            string SQLCommand = "select username, Total_Distance from Users, journey where journey.userid = Users.username AND journey.Date between @past and @now Order By Total_Distance desc";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = SQLCommand;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@past", weekago);
            command.Parameters.AddWithValue("@now", dateNow);
            dataadpeter.SelectCommand = command;
            command.ExecuteNonQuery();
            dataadpeter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
        public void addJourneyTime(string un, float total)
        {
            // this function adds the distance of the rescent journey to the total distance that is asigned in the leader board
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectDatabase;Integrated Security=True;Encrypt=False";
            string SQLCommand = "update Users set Total_Distance = Total_Distance + @total where username = @un";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = SQLCommand;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@un", un);
            command.Parameters.AddWithValue("@total", total);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void addUser(string un, string pass)
        {
            // this code would save the new registered user's username and password into the Users data table
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectDatabase;Integrated Security=True;Encrypt=False";
            string SQLCommand = "insert into Users (username, password) values (@un, @pass)";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = SQLCommand;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@un", un);
            command.Parameters.AddWithValue("@pass", pass);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable getData(string un)
        {
            // this code is used for the login feature to fetch the username and a password that would be used for the comparison with the user's input
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataadpeter = new SqlDataAdapter();
            string connection = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectDatabase;Integrated Security=True;Encrypt=False";
            string SQLCommand = "select * from Users where username = @user";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = SQLCommand;
            dataadpeter.SelectCommand = command;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@user", un);
            command.ExecuteNonQuery();
            dataadpeter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
    }
}
