using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_tutorial
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
    class stringValidation
    {
        public bool testempty(TextBox t)
        {
            // this code checks if a user has made an input and not left everything blank
            if (t.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }

}
