using Task.Implement;
using Xunit;

namespace Task.Unit_Test
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService _service = new FizzBuzzService();

        [Theory]
        [InlineData("3", "Fizz")]
        [InlineData("5", "Buzz")]
        [InlineData("15", "FizzBuzz")]
        [InlineData("23", "")]
        [InlineData("A", "Invalid Item")]
        [InlineData("", "Invalid Item")]
        public void ProcessValue_ShouldReturnExpectedResult(string input, string expectedOutput)
        {
            var result = _service.ProcessValue(input);
            Assert.Equal(expectedOutput, result.Output);
        }
    }
}
