using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{
    public class CosG : IOneArgumentCalculate
    {
        public double Calculate(double first)
        {
            return Math.Cos(first * Math.PI / 180);
        }
    }
}