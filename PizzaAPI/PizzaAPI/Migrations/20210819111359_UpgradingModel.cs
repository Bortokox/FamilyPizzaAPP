using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaAPI.Migrations
{
    public partial class UpgradingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dislike",
                table: "Pizzas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "Pizzas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dislike",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Like",
                table: "Pizzas");
        }
    }
}