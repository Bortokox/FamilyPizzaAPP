using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PizzaAPI.Migrations
{
    public partial class ModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeAdded",
                table: "Comments",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeAdded",
                table: "Comments");
        }
    }
}