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
    public partial class JourneyHistory : Form
    {
        UsrClass Usr;
        public JourneyHistory(UsrClass Usr)
        {
            // the variable Usr becomes accessible for this class
            this.Usr = Usr;
            InitializeComponent();
        }

        private void JourneyHistory_Load(object sender, EventArgs e)
        {
            // Uses a function from a data base class to display all data relevant for the journey history on the data grid
            string username = Usr.UserName;
            DatabaseClass DC = new DatabaseClass();
            DataTable DN = DC.getJourneyHistory(username);
            dataGridView2.DataSource = DN;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            // code for the back button to take the user to the previous connected form
            MenuForm f = new MenuForm(Usr);
            f.Show();
            this.Visible = false;
        }
    }
}
