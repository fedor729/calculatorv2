using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class SinusTests
    {
        [TestCase(1, 0.8414)]
        [TestCase(0, 0)]
        [TestCase(-1, -0.8414)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Sinus();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}