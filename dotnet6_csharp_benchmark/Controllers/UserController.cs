using dotnet6_csharp_benchmark.Dtos;
using dotnet6_csharp_benchmark.Models;
using dotnet6_csharp_benchmark.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_csharp_benchmark.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    [Route("/create")]
    public IActionResult CreateAccount([FromBody] User model)
    {
        var res =  _userService.CreateAccount(model);
        return res.StatusCodes == StatusCodes.Status200OK ? new OkObjectResult(new { ExecuteTime=res.ExecuteTime}) : BadRequest();
    }

    [HttpGet]
    [Route("/getUser")]
    public IActionResult GetAccount()
    {
        var res =  _userService.GetAllAccount();
        return res.StatusCodes == StatusCodes.Status200OK ? new OkObjectResult(new{Records= res.Payload, ExecuteTime=res.ExecuteTime}) : BadRequest();
    }

    [HttpPut]
    [Route("/editUser")]
    public IActionResult EditAccount([FromBody] UserDto model)
    {
        var res =  _userService.EditAccount(model);
        return res.StatusCodes == StatusCodes.Status200OK ? new OkObjectResult(new{ExecuteTime=res.ExecuteTime}) : BadRequest();
    }

    [HttpDelete]
    [Route("/deleteUser/{username}")]
    public  IActionResult DeleteAccount(string username)
    {
        var res = _userService.DeleteAccount(username);
        return res.StatusCodes == StatusCodes.Status200OK ? new OkObjectResult(new{ExecuteTime=res.ExecuteTime}) : BadRequest();
    }
}