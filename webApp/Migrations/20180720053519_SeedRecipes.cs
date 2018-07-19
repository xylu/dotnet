using Microsoft.EntityFrameworkCore.Migrations;

namespace webApp.Migrations
{
    public partial class SeedRecipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "Description", "Dish", "MinutesToPrepare", "QualityStars" },
                values: new object[] { 1, "Boil water and add tea", "Tea", 3, 1 });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "Description", "Dish", "MinutesToPrepare", "QualityStars" },
                values: new object[] { 2, "Boil water. Add coffe and sugar", "Coffe", 5, 2 });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "Description", "Dish", "MinutesToPrepare", "QualityStars" },
                values: new object[] { 3, "Boil water. Add coffe. Add milk. Add sugar", "Caffe Latte", 7, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "RecipeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "RecipeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "RecipeId",
                keyValue: 3);
        }
    }
}
