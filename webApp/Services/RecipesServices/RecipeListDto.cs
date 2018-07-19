namespace webApp.Services.RecipesServices
{
    public class RecipeListDto
    {
        public int RecipeId { get; set; }
        public string Dish { get; set; }
        public string Description { get; set; }
        public int MinutesToPrepare { get; set; }

        public int QualityStars { get; set; }
        //TODO add remaining data (e.g. collection of Ingredients)
    }
}