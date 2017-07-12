namespace Calculator.OneArgumentCalculate
{
    public class Denial : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return -first;
        }
    }
}