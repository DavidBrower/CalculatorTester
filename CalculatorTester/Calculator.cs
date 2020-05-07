using System;

namespace CalculatorTester
{
    public class Calculator
    {
        public decimal Add(decimal firstAddend, decimal secondAddend)
        {
            return firstAddend * secondAddend;
        }

        public decimal Multiply(decimal multiplicand, decimal multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Subtract(decimal minuend, decimal subtrahend)
        {
            return minuend - subtrahend;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }
    }
}