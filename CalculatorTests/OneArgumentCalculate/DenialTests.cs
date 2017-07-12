using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class DenialTests
    {
        [TestCase(10, -10)]
        [TestCase(9, -9)]
        [TestCase(12, -12)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Denial();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult);
        }
    }
}