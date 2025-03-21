using Lab5TestTask.Enums;

namespace Lab5TestTask.Models;

/// <summary>
/// User.
/// DO NOT change anything here.
/// </summary>
public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public UserStatus Status { get; set; }
    public virtual ICollection<Session> Sessions { get; set; }
}
