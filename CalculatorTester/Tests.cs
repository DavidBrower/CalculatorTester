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
    }
}