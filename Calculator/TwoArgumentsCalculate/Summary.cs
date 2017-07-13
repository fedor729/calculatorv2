namespace Calculator.TwoArgumentsCalculate
{
    /// <summary>
    /// Class for Summary function
    /// </summary>
    public class Summary : ITwoArgumentsCalculate
    {
        /// <summary>
        ///  Method for Summary calculation
        /// </summary>
        /// <param name="first">Input value1</param>
        /// <param name="second">Input value2</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
