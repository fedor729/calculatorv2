namespace Calculator
{
    public class Summary : ITwoArgumentsCalculate
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
