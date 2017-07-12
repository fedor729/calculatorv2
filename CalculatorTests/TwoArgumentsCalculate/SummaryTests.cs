using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.TwoArgumentsCalculate
{
    [TestFixture]
    public class SummaryTests
    {
        [Test]
        public void SummaryTest()
        {
            var calc = new Summary();
            double first = 3;
            double second = 7;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(10, result);
        }
    }
}