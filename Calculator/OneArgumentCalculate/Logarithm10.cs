using System;

namespace Calculator
{
    public class Logarithm10 : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Log(first, 10);
        }
    }
}