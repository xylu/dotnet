using Microsoft.EntityFrameworkCore;
using webApp.Models;

namespace webApp.Data
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Recipe>()
                .ToTable("Recipe")
                .Property(r => r.Description)
                .HasMaxLength(2000);

            modelBuilder.Entity<Recipe>()
                .HasData(
                    new Recipe()
                    {   RecipeId = 1,
                        Dish = "Tea",
                        Description = "Boil water and add tea",
                        MinutesToPrepare = 3,
                        QualityStars = 1,
                    },
                    new Recipe()
                    {
                        RecipeId = 2,
                        Dish = "Coffe",
                        Description = "Boil water. Add coffe and sugar",
                        MinutesToPrepare = 5,
                        QualityStars = 2,
                    },
                    new Recipe()
                    {
                        RecipeId = 3,
                        Dish = "Caffe Latte",
                        Description = "Boil water. Add coffe. Add milk. Add sugar",
                        MinutesToPrepare = 7,
                        QualityStars = 3,
                    }
                );
        }
    }
}