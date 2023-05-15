using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_Relation_Live.Migrations
{
    public partial class CityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CitiesCityID",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personels_CitiesCityID",
                table: "Personels",
                column: "CitiesCityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Cities_CitiesCityID",
                table: "Personels",
                column: "CitiesCityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Cities_CitiesCityID",
                table: "Personels");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Personels_CitiesCityID",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "CitiesCityID",
                table: "Personels");
        }
    }
}
