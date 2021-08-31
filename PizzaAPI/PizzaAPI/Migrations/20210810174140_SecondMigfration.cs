using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaAPI.Migrations
{
    public partial class SecondMigfration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pizzas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ingridients",
                table: "Pizzas",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Ingridients",
                table: "Pizzas");
        }
    }
}