using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class CotangenTests
    {
        [TestCase(4, 0.8636)]
        [TestCase(1, 0.6420)]
        [TestCase(-1, -0.6420)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Cotangent();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}