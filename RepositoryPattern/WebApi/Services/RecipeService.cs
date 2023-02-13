using Domain.Entities;
using Domain.Interfaces;
using WebApi.Requests;

namespace WebApi.Services
{
    public class RecipeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RecipeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Recipe AddRecipe(RecipeRequest request)
        {
            var recipe = new Recipe
            {
                Name = request.Name,
                Duration = request.Duration,
                ImageUrl = request.ImageUrl,
                Description = request.Description,
                RecipeCategoryId = request.RecipeCategoryId,
                Servings = request.Servings,
                SourceUrl = request.SourceUrl,
                LocalUrl = request.LocalUrl,
                DietId = request.DietId,
                CousineId = request.CousineId,
            };

            _unitOfWork.RecipeRepository.Add(recipe);
            _unitOfWork.Complete();

            return recipe;
        }
        public Recipe GetRecipeById(int id)
        {
            return _unitOfWork.RecipeRepository.GetById(id);
        }
    }

}
