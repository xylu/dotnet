using System.Linq;
using Microsoft.EntityFrameworkCore;
using webApp.Data;
using webApp.Services.RecipesServices.QueryObjects;

namespace webApp.Services.RecipesServices.Concrete
{
    // Based on https://github.com/JonPSmith/EfCoreInAction
    public class ListRecipesService
    {
        private readonly MyDatabaseContext _context;

        public ListRecipesService(MyDatabaseContext context)
        {
            _context = context;
        }

        //TODO add ordering,filtering and paging ( rename to SortFilterPage when implemented)
        public IQueryable<RecipeListDto> SelectAll()
        {
            var recipesQuery = _context.Recipes //#A
                .AsNoTracking() //#B
                .MapRecipeToDto(); //#C
            
            return recipesQuery.Page(0, int.MaxValue); //#D
        }
    }

    /*********************************************************
    #A This starts by selecting the Books property in the Application's DbContext 
    #B Because this is a read-only query I add .AsNoTracking(). It makes the query faster
    #C It then uses the Select query object which will pick out/calculate the data it needs
    #D Finally it applies the paging commands (TODO: implement it in the right way)
        * *****************************************************/
}