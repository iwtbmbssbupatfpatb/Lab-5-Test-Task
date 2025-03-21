using Lab5TestTask.Enums;
using Lab5TestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5TestTask.Data;

/// <summary>
/// ApplicationDbContext.
/// DO NOT change anything here.
/// </summary>
public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Session> Sessions { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            [
                    new User { Id = 1, Email = "user1@gmail.com", Status = UserStatus.Active},
                    new User { Id = 2, Email = "user2@gmail.com", Status = UserStatus.Active},
                    new User { Id = 3, Email = "user3@gmail.com", Status = UserStatus.Inactive},
                    new User { Id = 4, Email = "user4@gmail.com", Status = UserStatus.Active},
                    new User { Id = 5, Email = "user5@gmail.com", Status = UserStatus.Inactive},
                    new User { Id = 6, Email = "user6@gmail.com", Status = UserStatus.Inactive},
                    new User { Id = 7, Email = "user7@gmail.com", Status = UserStatus.Active},
            ]);

        modelBuilder.Entity<Session>().HasData(
            [
                    new Session {Id=1, StartedAtUTC = new DateTime(2024, 01, 12, 9, 0, 0), EndedAtUTC = new DateTime(2024, 01, 12, 15, 0, 0), DeviceType = DeviceType.Mobile, UserId = 1 },
                    new Session {Id=2, StartedAtUTC = new DateTime(2024, 02, 12, 9, 0, 0), EndedAtUTC = new DateTime(2024, 02, 12, 15, 0, 0), DeviceType = DeviceType.Desktop, UserId = 3 },
                    new Session {Id=3, StartedAtUTC = new DateTime(2024, 03, 12, 9, 0, 0), EndedAtUTC = new DateTime(2024, 03, 12, 15, 0, 0), DeviceType = DeviceType.Unknown, UserId = 7 },
                    new Session {Id=4, StartedAtUTC = new DateTime(2024, 04, 12, 9, 0, 0), EndedAtUTC = new DateTime(2024, 04, 12, 15, 0, 0), DeviceType = DeviceType.Unknown, UserId = 6 },
                    new Session {Id=5, StartedAtUTC = new DateTime(2024, 05, 12, 9, 0, 0), EndedAtUTC = new DateTime(2024, 05, 12, 20, 0, 0), DeviceType = DeviceType.Mobile, UserId = 2 },
                    new Session {Id=6, StartedAtUTC = new DateTime(2024, 06, 12, 9, 0, 0), EndedAtUTC = new DateTime(2024, 06, 12, 15, 0, 0), DeviceType = DeviceType.Mobile, UserId = 4 },
                    new Session {Id=7, StartedAtUTC = new DateTime(2024, 07, 12, 9, 0, 0), EndedAtUTC = new DateTime(2024, 07, 12, 18, 0, 0), DeviceType = DeviceType.Desktop, UserId = 5 },
                    new Session {Id=8, StartedAtUTC = new DateTime(2024, 08, 12, 9, 0, 0), EndedAtUTC = new DateTime(2024, 08, 12, 15, 0, 0), DeviceType = DeviceType.Desktop, UserId = 4 },
                    new Session {Id=9, StartedAtUTC = new DateTime(2024, 09, 12, 9, 0, 0), EndedAtUTC = new DateTime(2024, 09, 12, 15, 0, 0), DeviceType = DeviceType.Desktop, UserId = 3 },
                    new Session {Id=10, StartedAtUTC = new DateTime(2025, 10, 12, 0, 0, 0), EndedAtUTC = new DateTime(2025, 10, 12, 3, 0, 0), DeviceType = DeviceType.Unknown, UserId = 1 },
                    new Session {Id=11, StartedAtUTC = new DateTime(2025, 11, 12, 0, 0, 0), EndedAtUTC = new DateTime(2025, 11, 12, 3, 0, 0), DeviceType = DeviceType.Mobile, UserId = 5 },
                    new Session {Id=12, StartedAtUTC = new DateTime(2025, 12, 12, 0, 0, 0), EndedAtUTC = new DateTime(2025, 12, 12, 3, 0, 0), DeviceType = DeviceType.Desktop, UserId = 2 },
                    new Session {Id=13, StartedAtUTC = new DateTime(2025, 11, 12, 0, 0, 0), EndedAtUTC = new DateTime(2025, 11, 12, 3, 0, 0), DeviceType = DeviceType.Unknown, UserId = 1 },
                    new Session {Id=14, StartedAtUTC = new DateTime(2025, 12, 12, 0, 0, 0), EndedAtUTC = new DateTime(2025, 12, 12, 3, 0, 0), DeviceType = DeviceType.Unknown, UserId = 2 },
                    new Session {Id=15, StartedAtUTC = new DateTime(2025, 10, 12, 0, 0, 0), EndedAtUTC = new DateTime(2025, 10, 12, 3, 0, 0), DeviceType = DeviceType.Mobile, UserId = 2 },
            ]);
    }
}
