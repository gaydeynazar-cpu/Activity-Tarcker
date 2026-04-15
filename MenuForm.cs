using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_tutorial
{
    public partial class MenuForm : Form
    {
        UsrClass Usr;
        
        public MenuForm(UsrClass Usr)
        {
            // makes sure that the Usr parameter is shared so it can e passed on to the other classes
            InitializeComponent();
            this.Usr = Usr;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // displays user's username by replacing the plane text that was initially written
            NameDisplay.Text = Usr.UserName;
        }

        private void UsersName_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            JourneyForm f = new JourneyForm(Usr);
            f.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeaderBoardForm f = new LeaderBoardForm(Usr);
            f.Show();
            this.Visible = false;
        }

        private void JH_button_Click(object sender, EventArgs e)
        {
            JourneyHistory f = new JourneyHistory(Usr);
            f.Show();
            this.Visible = false;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Visible = false;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            // creates a button that uses a function from the data base class to delete the User's personal information
            DatabaseClass DC = new DatabaseClass();
            DC.DeleteUser(Usr.UserName);
            LoginForm f = new LoginForm();
            f.Show();
            this.Visible = false;
        }
    }
}
