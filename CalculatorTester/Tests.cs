using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTester
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CanDivideTwoDecimals()
        {
            var calculator = new Calculator();
            calculator.Divide(12.4M, 6.2M).Should().Be(2);
        }

        [TestMethod]
        public void CanSubtractIntegerFromDecimal()
        {
            var calculator = new Calculator();
            calculator.Subtract(3.2M, 2).Should().Be(1.2M);
        }

        [TestMethod]
        public void CanSubtractDecimalFromInteger()
        {
            var calculator = new Calculator();
            calculator.Subtract(3, 2.2M).Should().Be(0.8M);
        }

        [TestMethod]
        public void CanSubtractTwoDecimals()
        {
            var calculator = new Calculator();
            calculator.Subtract(3.6M, 2.4M).Should().Be(1.2M);
        }

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

        [TestMethod]
        public void CanMultiplyIntegerAndDecimal()
        {
            var calculator = new Calculator();
            calculator.Multiply(3, 6M).Should().Be(18M);
        }
    }
}