using System;

namespace Calculator.OneArgumentCalculate
{
    public class Exponentiation10 : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}