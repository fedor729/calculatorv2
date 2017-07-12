using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class Logarithm10Tests
    {
        [TestCase(0.5, -0.3010)]
        [TestCase(1, 0)]
        [TestCase(1, 0)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Logarithm10();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}