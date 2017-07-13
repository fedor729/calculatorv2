using System;

namespace Calculator.TwoArgumentsCalculate
{
    public class Division : ITwoArgumentsCalculate
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Делитель не должен быть равен 0");
            }
            return first / second;
        }
    }
}
