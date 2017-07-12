using System;

namespace Calculator.OneArgumentCalculate
{
    public class Logarithm2 : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Log(first, 3);
        }
    }
}
