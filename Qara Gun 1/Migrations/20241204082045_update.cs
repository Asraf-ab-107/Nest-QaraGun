using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qara_Gun_1.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductsImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductsImages",
                newName: "IX_ProductsImages_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsImages",
                table: "ProductsImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsImages_products_ProductId",
                table: "ProductsImages",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsImages_products_ProductId",
                table: "ProductsImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsImages",
                table: "ProductsImages");

            migrationBuilder.RenameTable(
                name: "ProductsImages",
                newName: "ProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsImages_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
