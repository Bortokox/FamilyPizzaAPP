using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaAPI.Migrations
{
    public partial class NewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuggestedPizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PrizeForSmall = table.Column<double>(type: "REAL", nullable: false),
                    PrizeForLarge = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Ingridients = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestedPizzas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuggestedPizzas");
        }
    }
}