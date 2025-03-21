using Lab5TestTask.Data;
using Lab5TestTask.Models;
using Lab5TestTask.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Lab5TestTask.Enums;

namespace Lab5TestTask.Services.Implementations;

/// <summary>
/// SessionService implementation.
/// Implement methods here.
/// </summary>
public class SessionService : ISessionService
{
    private readonly ApplicationDbContext _dbContext;

    public SessionService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Session> GetSessionAsync()
    {
            return await _dbContext.Sessions
                .Where(s => s.DeviceType == DeviceType.Desktop)
                .OrderBy(s => s.StartedAtUTC)
                .FirstOrDefaultAsync();
                
    }

    

    public async Task<List<Session>> GetSessionsAsync()
    {
        DateTime thresholdDate = new DateTime(2025, 1, 1);

    var activeSessions = await _dbContext.Sessions
        .AsNoTracking()
        .Where(s => s.EndedAtUTC < thresholdDate && s.User.Status == UserStatus.Active)
        .Select(s => new Session
        {
            Id = s.Id,
            StartedAtUTC = s.StartedAtUTC,
            EndedAtUTC = s.EndedAtUTC,
            DeviceType = s.DeviceType,
            UserId = s.UserId,
            User = new User
            {
                Id = s.User.Id,
                Email = s.User.Email,
                Status = s.User.Status
            }
        })
        .ToListAsync();

    return activeSessions;
    }
}
