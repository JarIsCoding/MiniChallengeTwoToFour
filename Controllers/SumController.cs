using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour.Services.Sum;
namespace MiniChallengeTwoToFour.Controllers;

[ApiController]
[Route("SumOf")]
public class SumController : Controller
{    
    private readonly ISumService _sumService;

    public SumController(ISumService sumService){
        _sumService = sumService;
    }

    [HttpGet]
    [Route("FindSum/{num1}/{num2}")]
    public string Sums(int num1, int num2){
        return _sumService.Sums(num1, num2);
    }
}
