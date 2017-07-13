using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for Exponentiation10 function
    /// </summary>
    public class Exponentiation10 : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for Exponentiation10 calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}