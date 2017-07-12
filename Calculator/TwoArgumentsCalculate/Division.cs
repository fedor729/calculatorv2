namespace Calculator
{
    public class Division : ITwoArgumentsCalculate
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}
