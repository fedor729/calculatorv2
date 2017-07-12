using System;

namespace Calculator
{
    public class Cosine : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}