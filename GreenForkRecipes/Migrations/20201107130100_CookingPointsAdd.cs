using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenForkRecipes.Migrations
{
    public partial class CookingPointsAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CookingPoints",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CookingPoints",
                table: "Users");
        }
    }
}
