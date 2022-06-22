using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_reviews_site.Migrations
{
    public partial class addedViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Studio",
                table: "VideoGame",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Review",
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
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_VideoGame_VideoGameId",
                        column: x => x.VideoGameId,
                        principalTable: "VideoGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "Rating", "User", "VideoGameId" },
                values: new object[,]
                {
                    { 1, "Fall guys is awesome", 8, "John Doe", 1 },
                    { 2, "Bloodhunt is alright", 6, "Jane Doe", 2 },
                    { 3, "Fortnite sucks", 3, "Jonnathan Doe", 3 },
                    { 4, "Apex Legends is decent", 5, "John Deer", 4 },
                    { 5, "Warzone is horrible", 1, "Jack Doe", 5 }
                });

            migrationBuilder.UpdateData(
                table: "VideoGame",
                keyColumn: "Id",
                keyValue: 1,
                column: "Studio",
                value: "Mediatonic");

            migrationBuilder.UpdateData(
                table: "VideoGame",
                keyColumn: "Id",
                keyValue: 2,
                column: "Studio",
                value: "Sharkmob");

            migrationBuilder.UpdateData(
                table: "VideoGame",
                keyColumn: "Id",
                keyValue: 3,
                column: "Studio",
                value: "Epic Games");

            migrationBuilder.UpdateData(
                table: "VideoGame",
                keyColumn: "Id",
                keyValue: 4,
                column: "Studio",
                value: "Respawn");

            migrationBuilder.UpdateData(
                table: "VideoGame",
                keyColumn: "Id",
                keyValue: 5,
                column: "Studio",
                value: "Acti-Blizz");

            migrationBuilder.CreateIndex(
                name: "IX_Review_VideoGameId",
                table: "Review",
                column: "VideoGameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropColumn(
                name: "Studio",
                table: "VideoGame");
        }
    }
}
