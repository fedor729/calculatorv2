using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class ExhibitorTests
    {
        [TestCase(4, 54.5981)]
        [TestCase(1, 2.7182)]
        [TestCase(-1, 0.3678)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Exhibitor();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}