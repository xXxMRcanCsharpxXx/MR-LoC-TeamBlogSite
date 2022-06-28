using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_reviews_site.Migrations
{
    public partial class newbuildRev : Migration
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
                    ReviewBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { 5, "COD: Warzone", "Acti-Blizz" },
                    { 6, "PUBG Moblie", "PUBG Studios/Krafton" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "PublishDate", "Rating", "ReviewBody", "User", "VideoGameId" },
                values: new object[,]
                {
                    { 1, "Fall guys is awesome", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Just a fun game to mess with my friends. I loved just knocking them off the levels, every time I got the chance.. 'Bang' .", "John Doe", 1 },
                    { 2, "Bloodhunt is alright", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Good idea with what they were going for. Love the gameplay and a new style to these types of game.", "Jane Doe", 2 },
                    { 3, "Fortnite sucks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "I would do lower but it was good to pump shotgun some noobs.", "Jonnathan Doe", 3 },
                    { 4, "Apex Legends is decent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "work the playtime, but too many lootboxes and pay-to-win mechanics.", "John Deer", 4 },
                    { 5, "Warzone is horrible", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Warzone was a cashgrab that stole my money.", "Jack Doe", 5 },
                    { 6, "PUBG Moblie is decent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "PUBG Moblie is decent for this year's showcase", "Jackline O'Connor", 6 }
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
