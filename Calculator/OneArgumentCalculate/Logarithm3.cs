using System;

namespace Calculator
{
    public class Logarithm2 : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Log(first, 3);
        }
    }
}
