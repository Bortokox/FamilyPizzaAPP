using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaAPI.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "SuggestedPizzas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "SuggestedPizzas",
                type: "TEXT",
                nullable: true);
        }
    }
}