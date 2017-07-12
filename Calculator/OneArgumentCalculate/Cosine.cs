using System;

namespace Calculator.OneArgumentCalculate
{
    public class Cosine : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}