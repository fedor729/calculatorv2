using System;

namespace Calculator.TwoArgumentsCalculate
{
    /// <summary>
    /// Class for Division function
    /// </summary>
    public class Division : ITwoArgumentsCalculate
    {
        /// <summary>
        ///  Method for Division calculation
        /// </summary>
        /// <param name="first">Input value1</param>
        /// <param name="second">Input value2</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Делитель не должен быть равен 0");
            }
            return first / second;
        }
    }
}
