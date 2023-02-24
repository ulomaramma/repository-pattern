using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodRecipe.DataAccess.Migrations
{
    /// <summary>
    /// /
    /// </summary>
    public partial class SeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cousines",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Italian" },
                    { 2, "Mexican" }
                });

            migrationBuilder.InsertData(
                table: "Diets",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Vegan" },
                    { 2, "Ketogenic" }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dessert" },
                    { 2, "Main Course" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cousines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cousines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
