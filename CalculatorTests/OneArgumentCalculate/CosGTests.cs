using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class CosGTests
    {
        [TestCase(1, 0.9998)]
        [TestCase(0, 1)]
        [TestCase(-1, 0.9998)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new CosG();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}