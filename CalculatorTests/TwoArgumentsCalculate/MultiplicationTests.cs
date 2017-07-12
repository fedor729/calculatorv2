using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.TwoArgumentsCalculate
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(5, 2, 10)]
        [TestCase(20, 2, 40)]
        [TestCase(12, 2, 24)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
