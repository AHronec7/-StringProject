using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneUnformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // the isvalid format method determines if it is properly formatted or not 

        private bool isvalid(string str)
        {

            const int vlength = 13;           // length of a valid string 

            bool valid;                      //  flag to indicate if it is true or not 



            // determine if str is properly formatted

            if (str.Length == vlength && str[0] == '(' && str[4] == ')' && str[8] == '-')
            {
                valid = true;
            }


            else
            {
                valid = false;
            }

            // return the value

            return valid;


        }


        // the unformat method accepts a string and unformats it
        // removes the parentheses and the hyphens

        private void uformat(ref string str)
        {

            // first, delete the left paron at positon 0

            str = str.Remove(0, 1);

            // Next, delete the right paren. 

            str = str.Remove(3, 1);

            //Next, delete the hyphen

            str = str.Remove(6, 1);
        }

        private void UnformatButton_Click(object sender, EventArgs e)
        {
            // get a copy of the users input

            string input = UnformatTextBox.Text.Trim();

            // if the input is properly formatted, unformat it and display the answer 

            if (isvalid(input))
            {
                uformat(ref input);
                MessageBox.Show(input);
                
            }
                
            else
            {
                MessageBox.Show("please enter a valid input");
            }


            
                
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
