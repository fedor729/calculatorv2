using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.TwoArgumentsCalculate
{
    [TestFixture]
    public class SummaryTests
    {
        [TestCase(5, 2, 7)]
        [TestCase(20, 2, 22)]
        [TestCase(12, 2, 14)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Summary();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
