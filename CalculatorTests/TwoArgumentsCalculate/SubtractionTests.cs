using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.TwoArgumentsCalculate
{
    [TestFixture]
    public class SubtractionTests
    {
        [Test]
        public void SubtractionTest()
        {
            var calc = new Subtraction();
            double first = 7;
            double second = 3;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(4, result);
        }
    }
}