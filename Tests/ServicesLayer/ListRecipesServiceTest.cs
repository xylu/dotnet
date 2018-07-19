using System.Linq;
using TestSupport.EfHelpers;
using webApp.Data;
using webApp.Models;
using webApp.Services.RecipesServices.Concrete;
using Xunit;
using Xunit.Extensions.AssertExtensions;

namespace Tests.ServicesLayer
{
    public class ListRecipesServiceTest
    {
        [Fact]
        public void ShouldListRecipes()
        {
            //SETUP
            var options = SqliteInMemory
                .CreateOptions<MyDatabaseContext>();
            var numRecipes = 5;
            using (var context = new MyDatabaseContext(options))
            {
                context.Database.EnsureCreated();
                for (var i = 0; i < numRecipes ; i++)
                {
                    var r = new Recipe
                    {
                        Dish = $"Cup of tea #{i}",
                        Description = $"Boil water and add tea for {i} minute(s) ",
                        MinutesToPrepare = i,
                        QualityStars = i,
                    };

                    context.Recipes.Add(r);
                }
                context.SaveChanges();
                
                //ATTEMPT
                var service = new ListRecipesService(context);
                var dtos = service.SelectAll().ToList();
                
                //VERIFY
                dtos.Count.ShouldEqual(numRecipes);
            }
        }
    }
}
