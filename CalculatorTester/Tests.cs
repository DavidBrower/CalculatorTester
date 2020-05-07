using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTester
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CanAddTwoDecimals()
        {
            var calculator = new Calculator();
            calculator.Add(2.3M, 5.6M).Should().Be(7.9M);
        }

        [TestMethod]
        public void CanAddTwoIntegers()
        {
            var calculator = new Calculator();
            calculator.Add(3, 5).Should().Be(8);
        }

        [TestMethod]
        public void CanAddAnIntegerAndADecimal()
        {
            var calculator = new Calculator();
            calculator.Add(3, 4.5M).Should().Be(7.5M);
        }

        [TestMethod]
        public void CanMultiplyTwoDecimals()
        {
            var calculator = new Calculator();
            calculator.Multiply(3.4M, 4.6M).Should().Be(15.64M);
        }

        [TestMethod]
        public void CanMultiplyTwoIntegers()
        {
            var calculator = new Calculator();
            calculator.Multiply(3, 2).Should().Be(6);
        }
    }
}