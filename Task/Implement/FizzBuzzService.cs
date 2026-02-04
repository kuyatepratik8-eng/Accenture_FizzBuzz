using Task.Interface;
using Task.Model;

namespace Task.Implement
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public FizzBuzzResult ProcessValue(string value)
        {
            var result = new FizzBuzzResult { Input = value };

            if (string.IsNullOrWhiteSpace(value))
            {
                result.Output = "Invalid Item";
                return result;
            }

            if (!int.TryParse(value, out int number))
            {
                result.Output = "Invalid Item";
                return result;
            }

            bool divisibleBy3 = number % 3 == 0;
            bool divisibleBy5 = number % 5 == 0;

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
                result.Output = string.Empty;
                result.DivisionLog.Add($"Divided {number} by 3");
                result.DivisionLog.Add($"Divided {number} by 5");
            }

            return result;
        }
    }
}
