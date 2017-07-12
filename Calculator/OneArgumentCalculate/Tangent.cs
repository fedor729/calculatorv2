using System;

namespace Calculator
{
    public class Tangent : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}