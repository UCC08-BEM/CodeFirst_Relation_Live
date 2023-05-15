using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_Relation_Live.Migrations
{
    public partial class DefinedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriesCategoryID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentsDepartmanID",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonelsPersonelID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductsProductID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesCategoryID",
                table: "Products",
                column: "CategoriesCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmentsDepartmanID",
                table: "Personels",
                column: "DepartmentsDepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PersonelsPersonelID",
                table: "Orders",
                column: "PersonelsPersonelID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductsProductID",
                table: "Orders",
                column: "ProductsProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Personels_PersonelsPersonelID",
                table: "Orders",
                column: "PersonelsPersonelID",
                principalTable: "Personels",
                principalColumn: "PersonelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductsProductID",
                table: "Orders",
                column: "ProductsProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departments_DepartmentsDepartmanID",
                table: "Personels",
                column: "DepartmentsDepartmanID",
                principalTable: "Departments",
                principalColumn: "DepartmanID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoriesCategoryID",
                table: "Products",
                column: "CategoriesCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Personels_PersonelsPersonelID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductsProductID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departments_DepartmentsDepartmanID",
                table: "Personels");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoriesCategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoriesCategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Personels_DepartmentsDepartmanID",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PersonelsPersonelID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductsProductID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CategoriesCategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DepartmentsDepartmanID",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "PersonelsPersonelID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductsProductID",
                table: "Orders");
        }
    }
}
