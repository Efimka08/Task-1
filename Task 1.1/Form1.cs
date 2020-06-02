using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            double x, R;
            R = Convert.ToDouble(textBox1.Text);
            x = Convert.ToDouble(textBox2.Text);
            if ((x >= -10) && (x <= 0))
                textBox3.Text = Convert.ToString(Math.Round(-0.5 * x - 3, 2));
            else if ((x > 0) && (x < 3))
                textBox3.Text = Convert.ToString(Math.Round(-(Math.Sqrt(R * R - x * x)), 2));
            else if ((x >= 3) && (x <= 6))
                textBox3.Text = Convert.ToString(Math.Round(Math.Sqrt(R * R - (x - 6) * (x - 6)), 2));
            else if ((x < -10) || (x > 6))
                textBox3.Text = "NO";
        }
    }
}
