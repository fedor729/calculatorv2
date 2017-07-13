using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for Exhibitor function
    /// </summary>
    public class Exhibitor : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for Exhibitor calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
