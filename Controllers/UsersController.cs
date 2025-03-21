using Lab5TestTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab5TestTask.Controllers;

/// <summary>
/// Users controller.
/// DO NOT change anything here. Use created contract and provide only needed implementation.
/// </summary>
[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Returns selected user. 
    /// Selection rules are specified in Task description provided by recruiter
    /// </summary>
    [HttpGet]
    [Route("selected-user")]
    public async Task<IActionResult> Get()
    {
        var result = await _userService.GetUserAsync();
        return Ok(result);
    }

    /// <summary>
    /// Returns list of selected users. 
    /// Selection rules are specified in Task description provided by recruiter
    /// </summary>
    [HttpGet]
    [Route("selected-users")]
    public async Task<IActionResult> GetUsers()
    {
        var result = await _userService.GetUsersAsync();
        return Ok(result);
    }
}
