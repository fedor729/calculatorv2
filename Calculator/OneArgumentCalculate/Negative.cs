using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// 
    /// </summary>
    public class Negative : IOneArgumentCalculate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first == 0)
            {
                throw new Exception("Выражение не дожно быть равно 0");
            }
            return 1 / first;
        }
    }
}
