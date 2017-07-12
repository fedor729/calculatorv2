using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{
    public class SinG : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sin(first * Math.PI / 180);
        }
    }
}
