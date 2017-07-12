using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.TwoArgumentsCalculate
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(10, 2, 5)]
        [TestCase(20, 2, 10)]
        [TestCase(12, 2, 6)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected,actualResult);
        }
    }
}
