using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for Sinus function
    /// </summary>
    public class Sinus : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for Sinus calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}