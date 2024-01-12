namespace MiniChallengeTwoToFour.Services.GreaterOrLessThan
{
    public class GreaterOrLessThanService : IGreaterOrLessThanService
    {
        public string GreaterOrLess(int num1, int num2)
        {
            if (num1 > num2)
            {
                return $"Your first number {num1}, is greater than your second number {num2}. \nYour second number {num2}, is less than your first number {num1}.";
            }
            else if (num1 < num2)
            {
                return $"Your first number {num1}, is less than your second number {num2}. \nYour second number {num2}, is greater than your first number {num1}.";
            }
            else
            {
                return $"Your first number {num1}, is equal to your second number {num2}. \nYour second number {num2}, is equal to your first number {num1}.";
            }
        }
    }
}