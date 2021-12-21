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
        [InlineData("1,2,4", 7)]
        public void
            ReturnsNumberGivenStringCommaSepereatedNumbers
            (string numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("//;\n1;2;3", 6)]
        public void
            ReturnsNumberGivenStringWithCustomDelimiter
            (string numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("-1,2", "Negatives not allowed: -1")]
        [InlineData("-5,-2", "Negatives not allowed: -5,-2")]
        public void
           CancelsCalcGivenNegativeInput
            (string numbers, string expectedMessage)
        {
            Action action = () =>_calculator.Add(numbers);

            var ex = Assert.Throws<Exception>(action);

            Assert.Equal(expectedMessage, ex.Message);
        }
    }
}
