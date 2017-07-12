using System;

namespace Calculator.OneArgumentCalculate
{
    public class Cotangent : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return 1/Math.Tan(first);
        }
    }
}
