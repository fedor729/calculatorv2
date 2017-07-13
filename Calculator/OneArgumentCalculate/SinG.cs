using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for SinG function
    /// </summary>
    public class SinG : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for SinG calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Sin(first * Math.PI / 180);
        }
    }
}
