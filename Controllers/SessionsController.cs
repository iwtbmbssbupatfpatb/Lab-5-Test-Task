using Lab5TestTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab5TestTask.Controllers;

/// <summary>
/// Sessions controller.
/// DO NOT change anything here. Use created contract and provide only needed implementation.
/// </summary>
[ApiController]
[Route("api/sessions")]
public class SessionsController : ControllerBase
{
    private readonly ISessionService _sessionService;

    public SessionsController(ISessionService sessionService)
    {
        _sessionService = sessionService;
    }

    /// <summary>
    /// Returns selected session. 
    /// Selection rules are specified in Task description provided by recruiter
    /// </summary>
    [HttpGet]
    [Route("selected-session")]
    public async Task<IActionResult> Get()
    {
        var result = await _sessionService.GetSessionAsync();
        return Ok(result);
    }

    /// <summary>
    /// Returns list of selected sessions. 
    /// Selection rules are specified in Task description provided by recruiter
    /// </summary>
    [HttpGet]
    [Route("selected-sessions")]
    public async Task<IActionResult> GetUsers()
    {
        var result = await _sessionService.GetSessionsAsync();
        return Ok(result);
    }
}
