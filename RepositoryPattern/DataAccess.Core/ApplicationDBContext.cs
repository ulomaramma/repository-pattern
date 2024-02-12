using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
namespace DataAccess.Core
{
    

    public class ApplicationDBContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Cousine> Cousines { get; set; }

        public DbSet<Diet> Diets { get; set; }

        public DbSet<Instruction> Instructions { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Nutrient> Nutrients { get; set; }

        public DbSet<Nutrition> Nutritions { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<RecipeCategory> RecipeCategories { get; set; }


    }
}