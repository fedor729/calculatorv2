namespace Calculator
{
    public class Multiplication : ITwoArgumentsCalculate
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}

