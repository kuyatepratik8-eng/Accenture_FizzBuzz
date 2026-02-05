namespace Task.Repository
{
    public interface IDivisionService
    {
        string GetDivisionResult(int number);
    }

    public class DivisionService : IDivisionService
    {
        public string GetDivisionResult(int number)
        {
            return $"Divided {number} by 3{Environment.NewLine}Divided {number} by 5";
        }
    }
}
