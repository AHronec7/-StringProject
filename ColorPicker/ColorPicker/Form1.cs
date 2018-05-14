using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    // create the enum
    enum colors
    {
        Red, Orange, Yellow, Green, Blue, Indigo, Purple
    }


    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

            // display the ouput of the color in the textbox

            private void Displaycolor(colors color) 
        {
            ColorTextBox.Text = color.ToString();
        }

        private void RedLabel_Click(object sender, EventArgs e)
        {
            Displaycolor(colors.Red);
        }

        private void OrangeLabel_Click(object sender, EventArgs e)
        {
            Displaycolor(colors.Orange);
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            Displaycolor(colors.Yellow);
        }

        private void GreenLabel_Click(object sender, EventArgs e)
        {
            Displaycolor(colors.Green);
        }

        private void BlueLabel_Click(object sender, EventArgs e)
        {
            Displaycolor(colors.Blue);
        }

        private void IndigoLabel_Click(object sender, EventArgs e)
        {
            Displaycolor(colors.Indigo);
        }

        private void PurpleLabel_Click(object sender, EventArgs e)
        {
            Displaycolor(colors.Purple);
        }
    }
}
