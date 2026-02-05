using Task.Implement;
using Task.Repository;
using Xunit;

namespace Task.Unit_Test
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService _service;

        public FizzBuzzServiceTests()
        {
            var divisionService = new DivisionService();
            _service = new FizzBuzzService(divisionService);
        }

        [Theory]
        [InlineData("3", "Fizz")]
        [InlineData("5", "Buzz")]
        [InlineData("15", "FizzBuzz")]
        [InlineData("23", "Divided 23 by 3\r\nDivided 23 by 5")]
        [InlineData("A", "Invalid Item")]
        [InlineData("", "Invalid Item")]
        public void ProcessValue_ShouldReturnExpectedResult(string input, string expectedOutput)
        {
            var result = _service.ProcessValue(input);

            Assert.Equal(expectedOutput, result.Output);
        }
    }
}
