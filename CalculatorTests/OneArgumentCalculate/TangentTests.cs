using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class TangentTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.5574)]
        [TestCase(-1, -1.5574)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Tangent();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}