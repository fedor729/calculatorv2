using System;

namespace Calculator
{
    public class Absolute : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
