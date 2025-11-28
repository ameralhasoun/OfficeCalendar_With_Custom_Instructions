using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OfficeCalendar.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    EventDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    AdminApproval = table.Column<bool>(type: "INTEGER", nullable: false),
                    Delete = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    ToUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    FromUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    BeenRead = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    RecuringDays = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeArrived = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_Attendance_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event_Attendance",
                columns: table => new
                {
                    Event_AttendanceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<TimeSpan>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event_Attendance", x => x.Event_AttendanceId);
                    table.ForeignKey(
                        name: "FK_Event_Attendance_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_Attendance_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Feedback = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false),
                    Event_AttendanceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Event_Attendance_Event_AttendanceId",
                        column: x => x.Event_AttendanceId,
                        principalTable: "Event_Attendance",
                        principalColumn: "Event_AttendanceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminId", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "admin1@example.com", "^�H��(qQ��o��)'s`=\rj���*�rB�", "admin1" },
                    { 2, "admin2@example.com", "\\N@6��G��Ae=j_��a%0�QU��\\", "admin2" },
                    { 3, "admin3@example.com", "�j\\��f������x�s+2��D�o���", "admin3" },
                    { 4, "admin4@example.com", "�].��g��Պ��t��?��^�T��`aǳ", "admin4" },
                    { 5, "admin5@example.com", "E�=���:�-����gd����bF��80]�", "admin5" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "AdminApproval", "Capacity", "Delete", "Description", "EndTime", "EventDate", "Location", "StartTime", "Title" },
                values: new object[,]
                {
                    { 1, true, 100, false, "First day", new TimeSpan(0, 15, 0, 0, 0), new DateOnly(2024, 9, 2), "Hogeschool Rotterdam", new TimeSpan(0, 10, 30, 0, 0), "Opening" },
                    { 2, true, 120, false, "Last day", new TimeSpan(0, 12, 0, 0, 0), new DateOnly(2025, 6, 30), "Hogeschool Rotterdam", new TimeSpan(0, 11, 0, 0, 0), "Final" }
                });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "MessageId", "BeenRead", "Content", "Date", "FromUserId", "ToUserId" },
                values: new object[,]
                {
                    { 1, true, "Hello Amer!", new DateTime(2024, 10, 4, 16, 15, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 2, false, "Hello Max!", new DateTime(2024, 10, 4, 16, 20, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 3, false, "ohio", new DateTime(2024, 10, 4, 16, 20, 0, 0, DateTimeKind.Unspecified), 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "RecuringDays" },
                values: new object[,]
                {
                    { 1, "max@example.com", "Max", "Bretherton", "+�\rS{���a��V�����qb���_�{�'�[", "mo,tu,we" },
                    { 2, "amer@example.com", "Amer", "Alhasoun", "+�\rS{���a��V�����qb���_�{�'�[", "we,th,fr" },
                    { 3, "aymane@example.com", "Aymane", "Aazouz", "+�\rS{���a��V�����qb���_�{�'�[", "mo,we,fr" },
                    { 4, "jordy@example.com", "Jordy", "Mahn", "+�\rS{���a��V�����qb���_�{�'�[", "tu,we,th" }
                });

            migrationBuilder.InsertData(
                table: "Attendance",
                columns: new[] { "AttendanceId", "TimeArrived", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1 },
                    { 2, null, 2 },
                    { 3, null, 3 },
                    { 4, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Event_Attendance",
                columns: new[] { "Event_AttendanceId", "EventId", "Time", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, 1 },
                    { 2, 2, null, 1 },
                    { 3, 1, null, 2 },
                    { 4, 1, null, 3 },
                    { 5, 2, null, 3 },
                    { 6, 2, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "EventId", "Event_AttendanceId", "Feedback", "Rating" },
                values: new object[,]
                {
                    { 1, 1, 1, "It was decent", 3 },
                    { 2, 1, 3, "It was awesome", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UserName",
                table: "Admin",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_AttendanceId",
                table: "Attendance",
                column: "AttendanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_UserId",
                table: "Attendance",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventId",
                table: "Event",
                column: "EventId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Event_Attendance_Event_AttendanceId",
                table: "Event_Attendance",
                column: "Event_AttendanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Event_Attendance_EventId",
                table: "Event_Attendance",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Attendance_UserId",
                table: "Event_Attendance",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_MessageId",
                table: "Message",
                column: "MessageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_Event_AttendanceId",
                table: "Review",
                column: "Event_AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ReviewId",
                table: "Review",
                column: "ReviewId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId",
                table: "User",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Event_Attendance");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
