using CarSales2.Models;
using Microsoft.EntityFrameworkCore;

namespace CarSales2.Persistence
{
    public class RecipeDbContext : DbContext
    {
       

        public RecipeDbContext(DbContextOptions<RecipeDbContext>options):base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}

