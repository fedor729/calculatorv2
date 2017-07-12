using System;

namespace Calculator
{
    public class Exhibitor : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
