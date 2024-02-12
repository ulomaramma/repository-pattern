using DataAccess.Core.Repositories;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDBContext _dbContext;
   
        public UnitOfWork(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;

        }

        public IRecipeRepository recipeRepository;
        public IRecipeCategoryRepository recipeCategoryRepository;
        public INutrientRepository nutrientRepository;
        public IIngredientRepository ingredientsRepository;
        public INutritionRepository nutritionRepository;
        public IRecipeRepository RecipeRepository
        {
            get
            {
                if (this.recipeRepository == null)
                {
                    this.recipeRepository = new RecipeRepository(this._dbContext);
                }

                return this.recipeRepository;
            }
        }


        public IRecipeCategoryRepository RecipeCategoryRepository
        {
            get
            {
                if (this.recipeCategoryRepository == null)
                {
                    this.recipeCategoryRepository = new RecipeCategoryRepository(this._dbContext);
                }

                return this.recipeCategoryRepository;
            }
        }

        public INutrientRepository NutrientRepository
        {
            get
            {
                if (this.nutrientRepository == null)
                {
                    this.nutrientRepository = new NutrientRepository(this._dbContext);
                }

                return this.nutrientRepository;
            }
        }

        public IIngredientRepository IngredientRepository
        {
            get
            {
                if (this.ingredientsRepository == null)
                {
                    this.ingredientsRepository = new IngredientRepository(this._dbContext);
                }

                return this.ingredientsRepository;
            }
        }

        public INutritionRepository NutritionRepository
        {
            get
            {
                if (this.nutritionRepository == null)
                {
                    this.nutritionRepository = new NutritionRepository(this._dbContext);
                }

                return this.nutritionRepository;
            }
        }


        public int Complete()
        {
            throw new NotImplementedException();
        }
    }
}
