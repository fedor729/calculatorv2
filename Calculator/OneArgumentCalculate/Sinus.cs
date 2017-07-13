using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// 
    /// </summary>
    public class Sinus : IOneArgumentCalculate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}