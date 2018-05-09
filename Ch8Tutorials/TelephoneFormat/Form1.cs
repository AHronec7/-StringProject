using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the validid method accepts a string and returns it true if it contains 10 digits 
        // false otherwise


        private bool validnumber(string str)
        {
            const int length = 10;    //length of a valid string 
            bool valid = true;      // make sure the bool is returning a true, 10 digit number 


            // see the strings length

            if (str.Length == length)
            {

                foreach (char ch in str)
                {

                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }

            else
            {
                // incorrect length
                valid = false;
            }

            return valid;
        }

        // the format method is a method that accepts a string and formats into a phone number 

        private void telformat(ref string str)
        {

            // first , insert the left paren at position 0

            str = str.Insert(0, "(");

            // Next, insert the right paren at position 4

            str = str.Insert(4, ")");

            //Next, insert the hyphen at position 8

            str = str.Insert(8, "-");
        }




        private void FormatButton_Click(object sender, EventArgs e)
        {
            // get a copy of the user`s input

            string input = TelephoneTextBox.Text.Trim();

            // if the input is a valid number, format it

            if (validnumber(input))
            {
                telformat(ref input);
                MessageBox.Show(input);
            }

            else
            {
                MessageBox.Show("invalid input, sorry");
            }
        }
    }
}

