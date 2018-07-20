using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webApp.Data;
using webApp.Services.RecipesServices;
using webApp.Services.RecipesServices.Concrete;

namespace webApp.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
        private readonly MyDatabaseContext _context;

        public RecipesController(MyDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IQueryable<RecipeListDto> GetAll()
        {
            var service = new ListRecipesService(_context);
            return service.SelectAll();
        }
    }
}