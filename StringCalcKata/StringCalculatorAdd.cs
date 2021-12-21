using System;
using Xunit;

namespace StringCalcKata
{
    public class StringCalculatorAdd
    {
        private StringCalculator _calculator = new StringCalculator();

        [Fact]
        public void Returns0GivenEmptyString()
        {
            
            var result = _calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        public void ReturnsNumberGivenString(string numbers, int expectedResult)
        {
            
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        public void
            ReturnsNumberGivenStringCommaSepereatedNumbers
            (string numbers, int expectedResult)
        {
            
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
