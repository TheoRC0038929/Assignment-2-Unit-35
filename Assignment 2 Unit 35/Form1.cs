using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Unit_35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double PR1, PR2, PR3;
            // shows when each text box is being used in each set of code//

            try
            {
                PR1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show(" not correct value");
                PR1 = 0.0;
                //if answer is not a whole number it will not be seen and will be an error//
            }
            try
            {
                PR2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show(" not correct value");
                PR2 = 0.0;
                //if answer is not a whole number it will not be seen and will be an error//
            }
            try
            {
                PR3 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show(" not correct value");
                PR3 = 0.0;
                //if answer is not a whole number it will not be seem and will be an error//
            }


        }
    }
}
