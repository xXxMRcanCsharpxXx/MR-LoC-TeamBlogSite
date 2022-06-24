using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_reviews_site.Migrations
{
    public partial class fridayFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Studio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoGameId = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_VideoGames_VideoGameId",
                        column: x => x.VideoGameId,
                        principalTable: "VideoGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Name", "Studio" },
                values: new object[,]
                {
                    { 1, "Fall Guys", "Mediatonic" },
                    { 2, "Bloodhunt", "Sharkmob" },
                    { 3, "Fortnite", "Epic Games" },
                    { 4, "Apex Legends", "Respawn" },
                    { 5, "COD: Warzone", "Acti-Blizz" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Rating", "User", "VideoGameId" },
                values: new object[,]
                {
                    { 1, "Fall guys is awesome", 8, "John Doe", 1 },
                    { 2, "Bloodhunt is alright", 6, "Jane Doe", 2 },
                    { 3, "Fortnite sucks", 3, "Jonnathan Doe", 3 },
                    { 4, "Apex Legends is decent", 5, "John Deer", 4 },
                    { 5, "Warzone is horrible", 1, "Jack Doe", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_VideoGameId",
                table: "Reviews",
                column: "VideoGameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
