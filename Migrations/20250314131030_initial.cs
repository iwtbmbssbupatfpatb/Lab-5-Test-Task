using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab5TestTask.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartedAtUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndedAtUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeviceType = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Status" },
                values: new object[,]
                {
                    { 1, "user1@gmail.com", 1 },
                    { 2, "user2@gmail.com", 1 },
                    { 3, "user3@gmail.com", 0 },
                    { 4, "user4@gmail.com", 1 },
                    { 5, "user5@gmail.com", 0 },
                    { 6, "user6@gmail.com", 0 },
                    { 7, "user7@gmail.com", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DeviceType", "EndedAtUTC", "StartedAtUTC", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 1, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1, new DateTime(2024, 2, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, 0, new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 4, 0, new DateTime(2024, 4, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 5, 2, new DateTime(2024, 5, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, 2, new DateTime(2024, 6, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 7, 1, new DateTime(2024, 7, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 8, 1, new DateTime(2024, 8, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, 1, new DateTime(2024, 9, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, 0, new DateTime(2025, 10, 12, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, 2, new DateTime(2025, 11, 12, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 12, 1, new DateTime(2025, 12, 12, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, 0, new DateTime(2025, 11, 12, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, 0, new DateTime(2025, 12, 12, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, 2, new DateTime(2025, 10, 12, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
