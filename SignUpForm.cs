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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            // runs a validation to make sure that the user does not have any missing data on his inputs
            stringValidation SV = new stringValidation();
            bool valid = SV.testempty(NewUsername);
            DatabaseClass DC = new DatabaseClass();
            DataTable DT = DC.getData(NewUsername.Text);
            if (valid == true)
            {
                //if the input is valid, check if the password that was input twice matches
                if (NewPassword.Text == ConfirmPassword.Text && DT.Rows.Count == 0)
                {
                    // if passwods match, encrypt the password and register the ciphered version into the Users table
                    Encryption en = new Encryption();
                    string EncryptedPass = en.Encrpt(NewPassword.Text);
                    DC.addUser(NewUsername.Text, EncryptedPass);
                    LoginForm f = new LoginForm();
                    f.Show();
                    this.Visible = false;
                }
                else if (NewPassword.Text != ConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }
                else if (DT.Rows.Count > 0)
                {
                    // if the username already exists, display the error message box.
                    MessageBox.Show("Username already in use");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creates a back button that takes the user back to the login
            LoginForm f = new LoginForm();
            f.Show();
            this.Visible = false;
        }
    }
}
