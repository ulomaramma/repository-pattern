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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cousine>().HasData(
            new Cousine { Id = 1, Name = "Italian" },
            new Cousine { Id = 2, Name = "Mexican" }
           );

            modelBuilder.Entity<RecipeCategory>().HasData(
            new RecipeCategory { Id = 1, Name = "Dessert" },
            new RecipeCategory { Id = 2, Name = "Main Course" }
           );

            modelBuilder.Entity<Diet>().HasData(
                new Diet { Id = 1, Name = "Vegan" },
                new Diet { Id = 2, Name = "Ketogenic" }
           );
            
        }
    }
}
