using System;
using Xunit;

namespace StringCalcKata
{
    public class StringCalculatorAdd
    {
        [Fact]
        public void Returns0GivenEmptyString()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("");

            Assert.Equal(0, result);
        }
    }
}
