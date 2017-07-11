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
            double result;
            switch (((Button)sender).Name)
            {
                case "Sum":
                    result = firstValue + lastValue;
                    break;
                case "Min":
                    result = firstValue - lastValue;
                    break;
                case "Mult":
                    result = firstValue * lastValue;
                    break;
                case "Div":
                    result = firstValue / lastValue;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            textBox3.Text = result.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void Mult_Click(object sender, EventArgs e)
        {

        }
    }
}
