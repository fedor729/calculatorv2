using System;

namespace Calculator.OneArgumentCalculate
{
    public class Exhibitor : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
