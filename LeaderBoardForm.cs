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
    public partial class LeaderBoardForm : Form
    {
        UsrClass Usr;
        public LeaderBoardForm(UsrClass Usr)
        {
            InitializeComponent();
            this.Usr = Usr;
        }

        private void LeaderBoardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDatabaseDataSet.Users' table. You can move, or remove it, as needed.
            DatabaseClass DC = new DatabaseClass();
            DataTable DT = DC.getdist();
            dataGridView1.DataSource = DT;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(Usr);
            f.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this code uses a function from a data base class to display all relevant information for the leader board
            dataGridView1.DataSource = null;
            DatabaseClass DC = new DatabaseClass();
            DataTable DT = DC.getdist();
            dataGridView1.DataSource = DT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this code makes the feature for the users of the progress done a week ago before today
            dataGridView1.DataSource = null;
            DatabaseClass DC = new DatabaseClass();
            DataTable DT = DC.getWeeklydist();
            dataGridView1.DataSource = DT;
        }
    }
}
