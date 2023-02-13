using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.DataAccess.Migrations
{
    public partial class RemoveFullAuditInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RecipeCategories");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "RecipeCategories");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "RecipeCategories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "RecipeCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "RecipeCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "RecipeCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "RecipeCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "RecipeCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Nutritions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Diets");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Diets");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "Diets");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Diets");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Diets");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Diets");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "Diets");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Diets");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Cousines");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Cousines");

            migrationBuilder.DropColumn(
                name: "CreatedByIp",
                table: "Cousines");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Cousines");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Cousines");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Cousines");

            migrationBuilder.DropColumn(
                name: "ModifiedByIp",
                table: "Cousines");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Cousines");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Recipes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "Recipes",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Recipes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "Recipes",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Recipes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "RecipeCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "RecipeCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "RecipeCategories",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "RecipeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "RecipeCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "RecipeCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "RecipeCategories",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "RecipeCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Nutritions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Nutritions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "Nutritions",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Nutritions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Nutritions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Nutritions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "Nutritions",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Nutritions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Nutrients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Nutrients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "Nutrients",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Nutrients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Nutrients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Nutrients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "Nutrients",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Nutrients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Instructions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Instructions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "Instructions",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Instructions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Instructions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "Instructions",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Instructions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Ingredients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "Ingredients",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Ingredients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Ingredients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "Ingredients",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Ingredients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Diets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Diets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "Diets",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Diets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Diets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Diets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "Diets",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Diets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Cousines",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Cousines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByIp",
                table: "Cousines",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Cousines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Cousines",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Cousines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByIp",
                table: "Cousines",
                type: "nvarchar(39)",
                maxLength: 39,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Cousines",
                type: "datetime2",
                nullable: true);
        }
    }
}
