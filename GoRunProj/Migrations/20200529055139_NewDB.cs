using Microsoft.EntityFrameworkCore.Migrations;

namespace GoRunProj.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LocationName",
                table: "Runningspot",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AddColumn<string>(
                name: "No",
                table: "Runningspot",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yes",
                table: "Runningspot",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RunningSpots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunningSpots", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RunningSpots");

            migrationBuilder.DropColumn(
                name: "No",
                table: "Runningspot");

            migrationBuilder.DropColumn(
                name: "Yes",
                table: "Runningspot");

            migrationBuilder.AlterColumn<string>(
                name: "LocationName",
                table: "Runningspot",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
