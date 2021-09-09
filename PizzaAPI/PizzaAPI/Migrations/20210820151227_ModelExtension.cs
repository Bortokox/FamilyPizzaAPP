using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaAPI.Migrations
{
    public partial class ModelExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prize",
                table: "Pizzas",
                newName: "PrizeForSmall");

            migrationBuilder.AddColumn<double>(
                name: "PrizeForLarge",
                table: "Pizzas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrizeForLarge",
                table: "Pizzas");

            migrationBuilder.RenameColumn(
                name: "PrizeForSmall",
                table: "Pizzas",
                newName: "Prize");
        }
    }
}