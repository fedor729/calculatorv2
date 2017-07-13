namespace Calculator.TwoArgumentsCalculate
{
    /// <summary>
    /// Class for Multiplication function
    /// </summary>
    public class Multiplication : ITwoArgumentsCalculate
    {
        /// <summary>
        ///  Method for Multiplication calculation
        /// </summary>
        /// <param name="first">Input value1</param>
        /// <param name="second">Input value2</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}

