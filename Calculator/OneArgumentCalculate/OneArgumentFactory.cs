using System;

namespace Calculator
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculate CreateCalculator(string calcName)
        {
            switch (calcName)
            {
                case "square":
                    return new Exponentiation2();
                case "cos":
                    return new Cosine();
                case "sin":
                    return new Sinus();
                case "ex":
                    return new Exhibitor();
                case "ln":
                    return new Logarithm2();
                case "tg":
                    return new Tangent();
                case "ctg":
                    return new Cotangent();
                case "log10":
                    return new Logarithm10();
                case "x10":
                    return new Exponentiation10();
                case "min_x":
                    return new Denial();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }

    }
}
