using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Groceries2.Data.Migrations
{
    public partial class AddTagsToRecipe2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Recipies_RecipeId",
                table: "Tag");

            migrationBuilder.DropTable(
                name: "Recipies");

            migrationBuilder.DropIndex(
                name: "IX_Tag_RecipeId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Tag");

            migrationBuilder.RenameColumn(
                name: "tag",
                table: "Tag",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Tag",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Tag",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Cuisine",
                table: "Tag",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Tag_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_RecipeId",
                table: "Tags",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "Cuisine",
                table: "Tag");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Tag",
                newName: "tag");

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "Tag",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Recipies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cuisine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tag_RecipeId",
                table: "Tag",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Recipies_RecipeId",
                table: "Tag",
                column: "RecipeId",
                principalTable: "Recipies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
