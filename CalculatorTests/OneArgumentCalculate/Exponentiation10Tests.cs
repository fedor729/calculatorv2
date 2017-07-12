using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class Exponentiation10Tests
    {
        [TestCase(2, 100)]
        [TestCase(3, 1000)]
        [TestCase(4, 10000)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Exponentiation10();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult);
        }
    }
}