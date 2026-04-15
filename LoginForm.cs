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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            // This code validates the input of the user during the login form
            // it makes sure there is no empty space left
            stringValidation SV = new stringValidation();
            bool valid = SV.testempty(UsernametextBox);
            DatabaseClass DC = new DatabaseClass();
            DataTable DT = DC.getData(UsernametextBox.Text);
            // If something is input by the user, this program will check if any information matches along with the parameters in the data table
            if (valid == true)
            {
                if (DT.Rows.Count > 0)
                {
                    // decrypts the ciphered password so it can be compared with the user's input
                    Encryption en = new Encryption();
                    string decryptedPass = en.Decrypt(DT.Rows[0][2].ToString());
                    if(decryptedPass == PasswordtextBox.Text)
                    {
                        // if the inputs match with any parameters, set Usr variable to the username
                        UsrClass Usr = new UsrClass();
                        Usr.UserName = UsernametextBox.Text;
                        // sends the user to the menu form once logged in
                        MenuForm f = new MenuForm(Usr);
                        f.Show();
                        this.Visible = false;
                    }
                    
                }
                else
                {
                    // if not all data matches,display the message below
                    MessageBox.Show("No username found or passwords do not match");
                }
            }
            else
            {
                // if all data do not match, display no data message box
                MessageBox.Show("No data");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // creates the button that is linked to the sign up form
            SignUpForm f = new SignUpForm();
            f.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
