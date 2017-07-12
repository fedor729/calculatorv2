using System;

namespace Calculator
{
    public class Sinus : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}