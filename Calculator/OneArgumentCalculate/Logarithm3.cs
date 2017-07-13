using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for Logarithm3 function
    /// </summary>
    public class Logarithm2 : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for Logarithm3 calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Выражение не должно быть меньше 0");
            }
            return Math.Log(first, 3);
        }
    }
}
