using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.TwoArgumentsCalculate
{
    [TestFixture]
    public class SubtractionTests
    {
        [TestCase(5, 2, 3)]
        [TestCase(20, 2, 18)]
        [TestCase(12, 2, 10)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Subtraction();
            var actualResult = calculator.Calculate(first, second);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
