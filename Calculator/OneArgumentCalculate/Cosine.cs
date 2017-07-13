using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for Cosine function
    /// </summary>
    public class Cosine : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for Cosine calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}