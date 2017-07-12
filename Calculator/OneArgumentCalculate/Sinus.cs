using System;

namespace Calculator.OneArgumentCalculate
{
    public class Sinus : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}