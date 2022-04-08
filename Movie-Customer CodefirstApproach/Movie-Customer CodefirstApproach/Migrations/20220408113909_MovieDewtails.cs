using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Customer_CodefirstApproach.Migrations
{
    public partial class MovieDewtails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieDetails",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(nullable: true),
                    MovieCount = table.Column<int>(nullable: false),
                    MovieType = table.Column<string>(nullable: true),
                    MovieDate = table.Column<DateTime>(nullable: false),
                    MoviePrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDetails", x => x.MovieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieDetails");
        }
    }
}
