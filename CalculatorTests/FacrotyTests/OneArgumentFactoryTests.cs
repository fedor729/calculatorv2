using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgumentCalculate;
using NUnit.Framework;

namespace CalculatorTests.FacrotyTests
{
    public class OneArgumentFactoryTests
    {
        [TestCase("Exponentiation3", typeof(Exponentiation2))]
        [TestCase("Cosine", typeof(Cosine))]
        [TestCase("Sinus", typeof(Sinus))]
        [TestCase("Exhibitor", typeof(Exhibitor))]
        [TestCase("Logarithm3", typeof(Logarithm2))]
        [TestCase("Tangent", typeof(Tangent))]
        [TestCase("Cotangent", typeof(Cotangent))]
        [TestCase("Logarithm10", typeof(Logarithm10))]
        [TestCase("Exponentiation10", typeof(Exponentiation10))]
        [TestCase("Denial", typeof(Denial))]
        [TestCase("SinG", typeof(SinG))]
        [TestCase("CosG", typeof(CosG))]
        [TestCase("Absolute", typeof(Absolute))]
        [TestCase("Negative", typeof(Negative))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
