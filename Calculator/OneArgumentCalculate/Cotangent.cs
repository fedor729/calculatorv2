using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for Cotangent function
    /// </summary>
    public class Cotangent : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for Cotangent calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return 1/Math.Tan(first);
        }
    }
}
