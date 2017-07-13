using System;

namespace Calculator.OneArgumentCalculate
{
    public class Logarithm10 : IOneArgumentCalculate
    {

        public double Calculate(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Выражение не должно быть меньше 0");
            }
            return Math.Log(first, 10);
        }

    }
}