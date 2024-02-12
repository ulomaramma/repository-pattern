using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRecipeRepository RecipeRepository { get; }
        IRecipeCategoryRepository RecipeCategoryRepository { get; }
        INutrientRepository NutrientRepository { get; }
        INutritionRepository NutritionRepository { get; }
        IIngredientRepository IngredientRepository { get; }
        int Complete();
    }
}
