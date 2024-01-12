using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour.Services.WokeUp;

namespace MiniChallengeTwoToFour.Controllers
{
    [ApiController]
    [Route("WokeUpTime")]
    public class WokeUpController
    {
        private readonly IWokeUpService _wokeUpService;

        public WokeUpController(IWokeUpService wokeUpService){
            _wokeUpService = wokeUpService;
        }

        [HttpGet]
        [Route("TimeAndName/{time}/{name}")]
        public string Wake(int time, string name){
            return _wokeUpService.Wake(time, name);
        }
    }
}