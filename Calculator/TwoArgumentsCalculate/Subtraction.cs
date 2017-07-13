namespace Calculator.TwoArgumentsCalculate
{
    /// <summary>
    /// Class for Subtraction function
    /// </summary>
    public class Subtraction : ITwoArgumentsCalculate
    {
        /// <summary>
        ///  Method for Subtraction calculation
        /// </summary>
        /// <param name="first">Input value1</param>
        /// <param name="second">Input value2</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}

