using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webApp.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Dish { get; set; }

        public string Description { get; set; }
        public int MinutesToPrepare { get; set; }
        
        public int QualityStars { get; set; }

    }
}
