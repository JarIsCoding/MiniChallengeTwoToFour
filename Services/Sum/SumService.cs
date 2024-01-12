namespace MiniChallengeTwoToFour.Services.Sum;
public class SumService : ISumService
{
    public string Sums(int num1, int num2)
    {
        int results = num1 + num2;
        return $"Your first number was {num1}, Your second number was {num2}. Together they add up to {results}";
    }
}