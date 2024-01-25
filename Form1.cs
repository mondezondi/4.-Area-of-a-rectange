using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Area_of_a_rectange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double area, perimeter, length, height;

            if (double.TryParse(textBox1.Text, out length)) 
            if (double.TryParse(textBox2.Text, out height)) 
            {
                area = length * height;
                perimeter = 2 * length + height;

                    textBox3.Text = area.ToString();
                    textBox4.Text = perimeter.ToString();
            }
        }
    }
}
