using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSVReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            try
            {

                StreamReader input;           // to read the file
                string line;                  // to hold a line from the file
                int count = 0;                // student counter
                int total;                    // accumulator
                double average;                // test score average

                // create a delimiter array

                char[] delim = { ',' };
                
                // open the csv file

                input = File.OpenText("Grades.csv");

                while (!input.EndOfStream)
                {
                    count++;

                    line = input.ReadLine();

                    // get the test scores as tokens 

                    string[] tokens = line.Split(delim);

                    // set the accumulator to 0

                    total = 0;

                    // calculate the total of the test score

                    foreach (string str in tokens)
                    {
                        total += int.Parse(str);


                    }

                    // calculate the avg of the scores

                    average = (double)total / tokens.Length;

                    //display the average

                    AverageListBox.Items.Add("The Average for student " + count + " is " +
                        average.ToString("n1"));
                }


                input.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
