using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorCrud.Migrations.RazorCrudClimber
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Climber",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClimberName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Style = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    FavoritePlace = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Achievement = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Climber", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Climber");
        }
    }
}
