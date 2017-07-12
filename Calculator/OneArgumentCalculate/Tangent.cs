using System;

namespace Calculator.OneArgumentCalculate
{
    public class Tangent : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}