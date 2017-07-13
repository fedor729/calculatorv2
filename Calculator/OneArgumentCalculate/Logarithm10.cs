using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// Class for Logarithm10 function
    /// </summary>
    public class Logarithm10 : IOneArgumentCalculate
    {
        /// <summary>
        /// Method for Logarithm10 calculation
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Выражение не должно быть меньше 0");
            }
            return Math.Log(first, 10);
        }

    }
}