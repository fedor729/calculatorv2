﻿using System;
using System.Windows.Forms;
using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;


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
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text);
                double lastValue = Convert.ToDouble(textBox2.Text);
                var calc = TwoArgumentsFatory.CreateCalculator(((Button)sender).Name);
                double resultValue = calc.Calculate(firstValue, lastValue);
                textBox3.Text = resultValue.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Возникла ошибка: " + exception.Message);
            }
            
        }

        private void CalculateOne_Click(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text);
                var calc = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double resultValue = calc.Calculate(firstValue);
                textBox3.Text = resultValue.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Возникла ошибка: " + exception.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
