using Calculator.OneArgumentCalculate;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.OneArgumentCalculate
{
    [TestFixture]
    public class Exponentiation3Tests
    {
        [TestCase(3, 9)]
        [TestCase(9, 81)]
        [TestCase(10, 100)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Exponentiation2();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult);
        }
    }
}