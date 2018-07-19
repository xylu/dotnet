using Microsoft.EntityFrameworkCore;
using webApp.Models;

namespace webApp.Data
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recipe>()
            .Property(r => r.Description)
            .HasMaxLength(2000);
    }
    }
}
