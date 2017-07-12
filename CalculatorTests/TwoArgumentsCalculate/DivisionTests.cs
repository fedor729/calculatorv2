using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.TwoArgumentsCalculate
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void DivisionTest()
        {
            var calc=new Division();
            double first = 2;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(1,result);
        }
    }
}
