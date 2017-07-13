namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for Denial function
    /// </summary>
    public class Denial : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for Denial calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return -first;
        }
    }
}