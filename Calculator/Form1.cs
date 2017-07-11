using System;
using System.Windows.Forms;


namespace Calculator
{

    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double lastValue = Convert.ToDouble(textBox2.Text);
            var calc = TwoArguments.CreateCalculator(((Button) sender).Name);
            double resultValue = calc.Calculate(firstValue, lastValue);
            textBox3.Text = resultValue.ToString();
        }


        
    }
}
