using System;

namespace Calculator
{
    public class Exponentiation10 : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}