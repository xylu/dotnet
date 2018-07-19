using System.Linq;
using webApp.Models;

namespace webApp.Services.RecipesServices.QueryObjects
// Based on https://github.com/JonPSmith/EfCoreInAction
{
    public static class RecipeListDtoFilter
    {
        public static IQueryable<RecipeListDto> //#A
            MapRecipeToDto(this IQueryable<Recipe> recipes) //#A
        {
            return recipes.Select(r => new RecipeListDto()
            {
                RecipeId = r.RecipeId, //#B
                Dish= r.Dish, //#B
                Description = r.Description, //#B
                MinutesToPrepare = r.MinutesToPrepare, //#B
                QualityStars = r.QualityStars,//#B
            });
        }

        /*********************************************************
        #A This extension method takes in IQueryable<Recipe> and returns IQueryable<RecipeListDto>
        #B These are simple copies of existing columns in the Books table
        * *******************************************************/
    }
}