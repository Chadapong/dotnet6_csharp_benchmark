using dotnet6_csharp_benchmark.DbContextFolder;
using dotnet6_csharp_benchmark.Services.HealthCareServices;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_csharp_benchmark.Controllers;

[ApiController]
public class HealthCareController: ControllerBase
{
    private readonly IHealthCareInfoService _healthCareInfoService;
    public HealthCareController(IHealthCareInfoService healthCareInfoService)
    {
        _healthCareInfoService = healthCareInfoService;
    }

    [HttpGet]
    [Route("/very-complex-query")]
    public  IActionResult GetVeryComplexQuery()
    {
        var result = _healthCareInfoService.GetVeryComplexQuery();
        return result.StatusCodes == StatusCodes.Status200OK ? new OkObjectResult(result.Payload) : BadRequest();
    }

    [HttpGet]
    [Route("complex-query")]
    public  IActionResult GetComplexQuery()
    {
        var result =  _healthCareInfoService.GetComplexQuery();
        return result.StatusCodes == StatusCodes.Status200OK? new  OkObjectResult(result.Payload): BadRequest();
    }
}