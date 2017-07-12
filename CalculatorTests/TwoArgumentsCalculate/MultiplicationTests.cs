using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.TwoArgumentsCalculate
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void MultiplicationTest()
        {
            var calc = new Multiplication();
            double first = 3;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(6, result);
        }
    }
}