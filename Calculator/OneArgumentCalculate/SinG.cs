using System;

namespace Calculator.OneArgumentCalculate
{
    public class SinG : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sin(first * Math.PI / 180);
        }
    }
}
