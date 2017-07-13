namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// 
    /// </summary>
    public class Denial : IOneArgumentCalculate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return -first;
        }
    }
}