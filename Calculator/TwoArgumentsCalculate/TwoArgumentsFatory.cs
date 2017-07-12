using System;

namespace Calculator
{
    public static class TwoArgumentsFatory

    {
        public static ITwoArgumentsCalculate CreateCalculator(string calcName)
        {

            switch (calcName)
            {
                case "Sum":
                    return new Summary();
                case "Min":
                    return new Subtraction();         
                case "Mult":
                    return new Multiplication();
                case "Div":
                    return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
    }
}
