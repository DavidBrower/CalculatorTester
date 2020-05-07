using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTester
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CanAddTwoNumbers()
        {
            var calculator = new Calculator();
            calculator.Add(2.3, 5.6).Should().Be(7.9);
        }
    }
}