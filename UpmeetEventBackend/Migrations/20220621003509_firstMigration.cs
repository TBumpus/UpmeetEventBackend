using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpmeetEventBackend.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Details", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Concert", 200m, "Red Hot Chili Peppers" },
                    { 2, "Hockey Game", 50m, "Detroit Red Wings" },
                    { 3, "Baseball Game", 25m, "Detroit Tigers" },
                    { 4, "Basketball Game", 57m, "Detroit Pistons" },
                    { 5, "Concert", 89m, "Blink-182" },
                    { 6, "Craft Fair", 0m, "Ann Arbor Art fair" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Favorites");
        }
    }
}
