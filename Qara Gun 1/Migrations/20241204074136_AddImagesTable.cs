﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qara_Gun_1.Migrations
{
    /// <inheritdoc />
    public partial class AddImagesTable : Migration
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
                newName: "productsImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "productsImages",
                newName: "IX_productsImages_ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "products",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productsImages",
                table: "productsImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productsImages_products_ProductId",
                table: "productsImages",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productsImages_products_ProductId",
                table: "productsImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productsImages",
                table: "productsImages");

            migrationBuilder.RenameTable(
                name: "productsImages",
                newName: "ProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_productsImages_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

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