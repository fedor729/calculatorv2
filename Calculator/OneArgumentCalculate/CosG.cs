using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for CosG function
    /// </summary>
    public class CosG : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for CosG calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Cos(first * Math.PI / 180);
        }
    }
}