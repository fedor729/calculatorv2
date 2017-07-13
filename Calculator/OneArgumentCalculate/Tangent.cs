using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for Tangent function
    /// </summary>
    public class Tangent : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for Tangent calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}