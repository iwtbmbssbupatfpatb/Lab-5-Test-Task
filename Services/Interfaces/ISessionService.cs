using Lab5TestTask.Models;

namespace Lab5TestTask.Services.Interfaces;

/// <summary>
/// ISessionService.
/// DO NOT change anything here. Use created contract and provide only needed implementation.
/// </summary>
public interface ISessionService
{
    Task<Session> GetSessionAsync();
    Task<List<Session>> GetSessionsAsync();
}
