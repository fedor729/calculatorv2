using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class NegativeTests
    {
        [TestCase(1, 1)]
        [TestCase(10, 0.1)]
        [TestCase(100, 0.01)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Negative();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult);
        }
    }
}