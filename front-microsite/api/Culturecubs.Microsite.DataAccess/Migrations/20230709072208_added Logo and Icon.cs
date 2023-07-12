using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Culturecubs.Microsite.DataAccess.Migrations
{
    public partial class addedLogoandIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenantIcon",
                table: "theme_configuration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenatLogo",
                table: "theme_configuration",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantIcon",
                table: "theme_configuration");

            migrationBuilder.DropColumn(
                name: "TenatLogo",
                table: "theme_configuration");
        }
    }
}
