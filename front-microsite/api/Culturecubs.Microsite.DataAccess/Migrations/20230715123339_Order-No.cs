using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Culturecubs.Microsite.DataAccess.Migrations
{
    public partial class OrderNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "contest_tab",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "contest_tab");
        }
    }
}
