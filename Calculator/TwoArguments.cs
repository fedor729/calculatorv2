using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public static class TwoArguments

    {
        public static ITwoArgumetsCalculate CreateCalculator(string calcName)
        {

            switch (calcName)
            {
                case "Sum":
                    return new Sum();
                case "Min":
                    return new Min();         
                case "Mult":
                    return new Mult();
                case "Div":
                    return new Div();
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
    }
}
