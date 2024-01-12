using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour.Services.GreaterOrLessThan;

namespace MiniChallengeTwoToFour.Controllers;
[ApiController]
[Route("GreaterOrLessThan")]
public class GreaterOrLessThanController
{
    private readonly IGreaterOrLessThanService _greaterOrLessThanService;

    public GreaterOrLessThanController(IGreaterOrLessThanService greaterOrLessThanService){
        _greaterOrLessThanService = greaterOrLessThanService;
    }

    [HttpGet]
    [Route("InputTwoNum/{num1}/{num2}")]
    public string GreaterOrLess(int num1, int num2)
    {
        return _greaterOrLessThanService.GreaterOrLess(num1, num2);
    }
}