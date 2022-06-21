using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_reviews_site.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoGame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGame", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "VideoGame",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fall Guys" },
                    { 2, "Bloodhunt" },
                    { 3, "Fortnite" },
                    { 4, "Apex Legends" },
                    { 5, "COD: Warzone" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGame");
        }
    }
}
