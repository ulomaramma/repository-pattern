using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.Repositories
{
    public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(ApplicationDBContext dbContext) : base(dbContext)
        {

        }
        /// <summary>
        /// Get Recipe By Category
        /// </summary>
        /// <param name="recipeCategory"></param>
        /// <returns></returns>
        public IEnumerable<Recipe> GetRecipeByCategory(RecipeCategory recipeCategory)
        {
           return _dbContext.Recipes.Where(r=>r.RecipeCategoryId == recipeCategory.Id).ToList();
        }
    }
}
