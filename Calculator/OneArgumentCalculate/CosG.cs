using System;

namespace Calculator.OneArgumentCalculate
{
    public class CosG : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Cos(first * Math.PI / 180);
        }
    }
}