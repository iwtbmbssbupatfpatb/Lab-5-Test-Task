using Lab5TestTask.Enums;

namespace Lab5TestTask.Models;

/// <summary>
/// Session.
/// DO NOT change anything here.
/// </summary>
public class Session
{
    public int Id { get; set; }
    public DateTime StartedAtUTC { get; set; }
    public DateTime EndedAtUTC { get; set; }
    public DeviceType DeviceType { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
