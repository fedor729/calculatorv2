using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for abs function
    /// </summary>
    public class Absolute : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for abs calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
