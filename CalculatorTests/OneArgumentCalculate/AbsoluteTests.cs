using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class AbsoluteTests
    {
        [TestCase(-5, 5)]
        [TestCase(9, 9)]
        [TestCase(-4, 4)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Absolute();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult);
        }
    }
}