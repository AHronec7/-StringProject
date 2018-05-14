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

namespace MemberConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
                
        }
        // field variable
        string file = "";

        

        private void LoadFormButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            openfile.Filter = "CSV Files|*.csv|Text Files (*.txt)|*.txt|All files(*.*)|*.*";
            openfile.Title = "please select a file";
            
            // openfile.InitialDirectory = 

            openfile.CheckFileExists = true;
            openfile.CheckFileExists = true;

            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OutputLabel.Text = openfile.FileName;
                file = openfile.FileName;
                
            }





        }

        private void LoadFormButton_Click_1(object sender, EventArgs e)
        {
            try
            {

                //counting the number of columns that will be displayed on the grid 
                DataGridViewRow grid = new DataGridViewRow();
                grid.CreateCells(MemberConversionGrid);

                MemberConversionGrid.ColumnCount = 6;

                MemberConversionGrid.Columns[0].Name = "Firstname";

                MemberConversionGrid.Columns[1].Name = "Lastname";

                MemberConversionGrid.Columns[2].Name = "Birthday";

                MemberConversionGrid.Columns[3].Name = "City";

                MemberConversionGrid.Columns[4].Name = "State";

                MemberConversionGrid.Columns[5].Name = "Joindate";




                //pulling from the streamreader class to input the file on the C# form

                StreamReader strreader;
                string line;
                int counter = 0;

                // creating an array to hold multiple values 
                char[] delimarray = new char[6];

                
                



            }





           catch
            {

            }

        }
    }
}
