using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArgumentsCalculate;
using NUnit.Framework;

namespace CalculatorTests.FacrotyTests
{
    public class TwoArgumentFactoryTests
    {
        [TestCase("Sum", typeof(Summary))]
        [TestCase("Min", typeof(Subtraction))]
        [TestCase("Mult", typeof(Multiplication))]
        [TestCase("Div", typeof(Division))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFatory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }


    }
}
