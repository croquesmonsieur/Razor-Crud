using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorCrud.Migrations.RazorCrudClimbingCompetition
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClimbingCompetition",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompetitionName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    CurrentChampionMen = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    CurrentChampionWomen = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimbingCompetition", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClimbingCompetition");
        }
    }
}
