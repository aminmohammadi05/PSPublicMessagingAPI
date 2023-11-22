using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class step1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PossibleActionId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 200, nullable: false),
                    ClientUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TargetClientUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotificationTitle = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    NotificationText = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    PossibleActionId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 200, nullable: false),
                    ClientUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ClientGroup = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TargetClientUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TargetClientGroup = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TargetGroup = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ClientFullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TargetClientFullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NotificationStatus = table.Column<int>(type: "int", nullable: false),
                    NotificationPriority = table.Column<int>(type: "int", nullable: false),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", maxLength: 200, nullable: false),
                    MethodParameter_Parameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifierUser = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PossibleAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PossibleActionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ModuleName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TargetGroup = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FormName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MethodToCall = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PossibleAction", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientAction");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "PossibleAction");
        }
    }
}
