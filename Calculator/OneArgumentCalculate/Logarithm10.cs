using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// 
    /// </summary>
    public class Logarithm10 : IOneArgumentCalculate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
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