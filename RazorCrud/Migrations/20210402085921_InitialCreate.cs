using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorCrud.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClimbingRoute",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    OriginatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Originator = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Rating = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimbingRoute", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClimbingRoute");
        }
    }
}
