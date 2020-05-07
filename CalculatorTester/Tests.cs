using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTester
{
    [TestClass]
    public class Tests
    {
        private Calculator calculator;
        [TestInitialize]
        public void Initialise()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void CanDivideTwoDecimals()
        {
            calculator.Divide(12.4M, 6.2M).Should().Be(2);
        }

        [TestMethod]
        public void CanSubtractIntegerFromDecimal()
        {
            calculator.Subtract(3.2M, 2).Should().Be(1.2M);
        }

        [TestMethod]
        public void CanSubtractDecimalFromInteger()
        {
            calculator.Subtract(3, 2.2M).Should().Be(0.8M);
        }

        [TestMethod]
        public void CanSubtractTwoDecimals()
        {
            calculator.Subtract(3.6M, 2.4M).Should().Be(1.2M);
        }

        [TestMethod]
        public void CanAddTwoDecimals()
        {
            calculator.Add(2.3M, 5.6M).Should().Be(7.9M);
        }

        [TestMethod]
        public void CanAddTwoIntegers()
        {
            calculator.Add(3, 5).Should().Be(8);
        }

        [TestMethod]
        public void CanAddAnIntegerAndADecimal()
        {
            calculator.Add(3, 4.5M).Should().Be(7.5M);
        }

        [TestMethod]
        public void CanMultiplyTwoDecimals()
        {
            calculator.Multiply(3.4M, 4.6M).Should().Be(15.64M);
        }

        [TestMethod]
        public void CanMultiplyTwoIntegers()
        {
            calculator.Multiply(3, 2).Should().Be(6);
        }

        [TestMethod]
        public void CanMultiplyIntegerAndDecimal()
        {
            calculator.Multiply(3, 6M).Should().Be(18M);
        }
    }
}