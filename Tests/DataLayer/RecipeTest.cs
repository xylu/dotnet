using Xunit;
using System;
using TestSupport.EfHelpers;
using System.Linq;
using FluentAssertions;
using webApp.Models;
using webApp.Data;
using Xunit.Extensions.AssertExtensions;

namespace Tests
{
    public class RecipeTest
    {
        [Fact]
        public void ShouldSaveRecipe()
        {
            //SETUP
            var options = SqliteInMemory
                .CreateOptions<MyDatabaseContext>();
            using (var context = new MyDatabaseContext(options))
            {
                context.Database.EnsureCreated();
                //ATEMPT
                var r = new Recipe
                {
                    Dish = "Cup of tea",
                    Description = "Boil water and add tea",
                    MinutesToPrepare = 5,
                    QualityStars = 1,
                };
                context.Recipes.Add(r);
                context.SaveChanges();
            }

            using (var context = new MyDatabaseContext(options))
            {
                //VERIFY  
                var recipe = context.Recipes.First();
                recipe.Dish.Should().BeEquivalentTo("Cup of tea");
                recipe.Description.Should().BeEquivalentTo("Boil water and add tea");
                recipe.MinutesToPrepare.ShouldEqual(5);
                recipe.QualityStars.ShouldEqual(1);
            }
        }
    }
}