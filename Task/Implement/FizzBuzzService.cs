using Task.Interface;
using Task.Model;
using Task.Repository;

namespace Task.Implement
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IDivisionService _divisionService;
        private const int FizzDivisor = 3;
        private const int BuzzDivisor = 5;

        public FizzBuzzService(IDivisionService divisionService)
        {
            _divisionService = divisionService;
        }

        public FizzBuzzResult ProcessValue(string value)
        {
            var result = new FizzBuzzResult { Input = value };

            if (string.IsNullOrWhiteSpace(value) || !int.TryParse(value, out int number))
            {
                result.Output = "Invalid Item";
                return result;
            }

            bool divisibleBy3 = number % FizzDivisor == 0;
            bool divisibleBy5 = number % BuzzDivisor == 0;

            if (divisibleBy3 && divisibleBy5)
            {
                result.Output = "FizzBuzz";
            }
            else if (divisibleBy3)
            {
                result.Output = "Fizz";
            }
            else if (divisibleBy5)
            {
                result.Output = "Buzz";
            }
            else
            {
                result.Output = _divisionService.GetDivisionResult(number);
            }

            return result;
        }
    }
}
