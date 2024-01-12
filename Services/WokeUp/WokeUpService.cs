namespace MiniChallengeTwoToFour.Services.WokeUp
{
    public class WokeUpService : IWokeUpService
    {
        public string Wake(int time, string name)
        {
            return $"Hello {name}! I see you woke up at {time}, hope the rest of your day is great!";
        }
    }
}