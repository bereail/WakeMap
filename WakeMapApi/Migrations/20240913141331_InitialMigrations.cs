using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WakeMapApi.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GPS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    Longitude = table.Column<double>(type: "REAL", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    ActivationRadius = table.Column<double>(type: "REAL", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Tel = table.Column<int>(type: "INTEGER", nullable: false),
                    UserSettings = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivationConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ConditionType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ConditionData = table.Column<string>(type: "TEXT", nullable: false),
                    Threshold = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    GpsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivationConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivationConditions_GPS_GpsId",
                        column: x => x.GpsId,
                        principalTable: "GPS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersSettings",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    EnableSound = table.Column<bool>(type: "INTEGER", nullable: false),
                    EnableVibration = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSettings", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UsersSettings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alarms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Hour = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Repeat = table.Column<bool>(type: "INTEGER", nullable: false),
                    Tono = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    Vibration = table.Column<bool>(type: "INTEGER", nullable: false),
                    PersonalizeMessage = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ConditionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alarms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alarms_ActivationConditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "ActivationConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alarms_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlarmsHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AlarmId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivationTimestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TriggeredAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Acknowledged = table.Column<bool>(type: "INTEGER", nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Outcome = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlarmsHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlarmsHistories_Alarms_AlarmId",
                        column: x => x.AlarmId,
                        principalTable: "Alarms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AlarmId = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    SentAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReadAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Alarms_AlarmId",
                        column: x => x.AlarmId,
                        principalTable: "Alarms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivationConditions_GpsId",
                table: "ActivationConditions",
                column: "GpsId");

            migrationBuilder.CreateIndex(
                name: "IX_Alarms_ConditionId",
                table: "Alarms",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Alarms_UserId",
                table: "Alarms",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AlarmsHistories_AlarmId",
                table: "AlarmsHistories",
                column: "AlarmId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_AlarmId",
                table: "Notifications",
                column: "AlarmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlarmsHistories");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "UsersSettings");

            migrationBuilder.DropTable(
                name: "Alarms");

            migrationBuilder.DropTable(
                name: "ActivationConditions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GPS");
        }
    }
}
