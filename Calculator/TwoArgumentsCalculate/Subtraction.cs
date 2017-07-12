namespace Calculator
{
    public class Subtraction : ITwoArgumentsCalculate
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}

