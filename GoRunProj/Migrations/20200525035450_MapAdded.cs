using Microsoft.EntityFrameworkCore.Migrations;

namespace GoRunProj.Migrations
{
    public partial class MapAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Map",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Address = table.Column<string>(maxLength: 60, nullable: false),
                    Lat = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Lng = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Type = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Map", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Map_Runningspot_Id",
                        column: x => x.Id,
                        principalTable: "Runningspot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Map");
        }
    }
}
