using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgumentCalculate
{
    public class Negative : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return 1 / first;
        }
    }
}
