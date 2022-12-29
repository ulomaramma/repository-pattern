using FoodRecipe.DataAccess.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.DataAccess.Data
{
    public class FoodRecipeDBContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public FoodRecipeDBContext(DbContextOptions<FoodRecipeDBContext> options): base(options)
        {
            
        }

        public DbSet<Cousine> Cousines { get; set; }

        public DbSet<Diet> Diets { get; set; }       

        public DbSet <Instruction> Instructions { get; set; }

        public DbSet<Ingredients> Ingredients { get; set; }

        public DbSet<Nutrients> Nutrients { get; set; }

        public DbSet<Nutrition> Nutritions { get; set; }

        public DbSet<Recipe> Recipes { get; set; }  

        public DbSet<RecipeCategory> RecipeCategories { get; set; }


    }
}
