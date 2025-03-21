using Lab5TestTask.Models;

namespace Lab5TestTask.Services.Interfaces;

/// <summary>
/// IUserService.
/// DO NOT change anything here. Use created contract and provide only needed implementation.
/// </summary>
public interface IUserService
{
    Task<User> GetUserAsync();
    Task<List<User>> GetUsersAsync();
}
