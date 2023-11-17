using Domain;
using FluentAssertions;

namespace CalculatorTest
{
    public class CalculatorTests
    {
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        {
            var calculator = new Calculator();
            var result = calculator.Sum(2, 2);

            result.Should().Be(4);
        }
    }
}