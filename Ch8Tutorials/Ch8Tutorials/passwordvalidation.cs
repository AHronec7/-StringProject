using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8Tutorials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Numuppercase(string str)
        {
            int uppercase = 0;    // number of uppercase letters

            // count the number of uppercase letters

            foreach (char ch in str)
            {

                if (char.IsUpper(ch))
                {
                    uppercase++;
                }
            }

            // return the number of uppercase letters

            return uppercase;
        }

        // now use the lowercase method to find the lowercase numbers in password

        private int numlowercase(string str)
        {

            int lowercase = 0;      // number of lowercase numbers

            // count each lowercase letter in password

            foreach (char ch in str)
            {

                if (char.IsLower(ch))
                {
                    lowercase++;
                }
            }

            // return the value of lowercase letters

            return lowercase;
        }

        // number of digits in password method 

        private int numdigit(string str)
        {

            int digit = 0;       // number of digits in password 

            // count the number of digits in the password 

            foreach (char ch in str)
            {

                if (char.IsDigit(ch))
                {
                    digit++;
                }

            }

            return digit;
           }




        private void CheckPasswordButton_Click(object sender, EventArgs e)
        {
            // a const int that would be the max specified length for the password 

            const int minlength = 8;

            // get the password from the text box

            string password = PasswordTextBox.Text;


            // validate the password 

            if (password.Length >= minlength && Numuppercase(password) >= 1
                && numlowercase(password) >= 1 && numdigit(password) >= 1)
            {
                MessageBox.Show("You have entered a valid password");
            }

            else
            {
                MessageBox.Show("oops, please enter a VALID source, thanks");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
