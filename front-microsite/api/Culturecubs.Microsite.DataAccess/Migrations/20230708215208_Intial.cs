using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Culturecubs.Microsite.DataAccess.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tenant_contest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tenant_contest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "theme_configuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Primary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryDarken1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secondary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryDarken1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Error = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Success = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDark = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theme_configuration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantContestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contest_tenant_contest_TenantContestId",
                        column: x => x.TenantContestId,
                        principalTable: "tenant_contest",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "contest_tab",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contest_tab", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contest_tab_contest_ContestId",
                        column: x => x.ContestId,
                        principalTable: "contest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contest_TenantContestId",
                table: "contest",
                column: "TenantContestId");

            migrationBuilder.CreateIndex(
                name: "IX_contest_tab_ContestId",
                table: "contest_tab",
                column: "ContestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contest_tab");

            migrationBuilder.DropTable(
                name: "theme_configuration");

            migrationBuilder.DropTable(
                name: "contest");

            migrationBuilder.DropTable(
                name: "tenant_contest");
        }
    }
}
