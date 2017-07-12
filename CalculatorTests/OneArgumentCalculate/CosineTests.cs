using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class CosineTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 0.5403)]
        [TestCase(-1, 0.5403)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Cosine();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}