using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{

    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double lastValue = Convert.ToDouble(textBox2.Text);
            double result = firstValue + lastValue;
            textBox3.Text = result.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Min_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double lastValue = Convert.ToDouble(textBox2.Text);
            double result = firstValue - lastValue;
            textBox3.Text = result.ToString();
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double lastValue = Convert.ToDouble(textBox2.Text);
            double result = firstValue * lastValue;
            textBox3.Text = result.ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double lastValue = Convert.ToDouble(textBox2.Text);
            double result = firstValue / lastValue;
            textBox3.Text = result.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
