using System;

namespace Calculator.OneArgumentCalculate
{
    public class Absolute : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
