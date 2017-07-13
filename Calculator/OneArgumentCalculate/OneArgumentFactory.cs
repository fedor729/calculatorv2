using System;

namespace Calculator.OneArgumentCalculate
{
    /// <summary>
    /// 
    /// </summary>
    public static class OneArgumentFactory
    {
/// <summary>
/// 
/// </summary>
/// <param name="calcName"></param>
/// <returns></returns>
        public static IOneArgumentCalculate CreateCalculator(string calcName)
        {
            switch (calcName)
            {
                case "Exponentiation3":
                    return new Exponentiation2();
                case "Cosine":
                    return new Cosine();
                case "Sinus":
                    return new Sinus();
                case "Exhibitor":
                    return new Exhibitor();
                case "Logarithm3":
                    return new Logarithm2();
                case "Tangent":
                    return new Tangent();
                case "Cotangent":
                    return new Cotangent();
                case "Logarithm10":
                    return new Logarithm10();
                case "Exponentiation10":
                    return new Exponentiation10();
                case "Denial":
                    return new Denial();
                case "SinG":
                    return new SinG();
                case "CosG":
                    return new CosG();
                case "Absolute":
                    return new Absolute();
                case "Negative":
                    return new Negative();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }

    }
}
