using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.DataAccess.Data.Entities
{
    public class Recipe : FullAuditInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Duration { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
        public int RecipeCategoryId { get; set; }

        public string Servings { get; set; }
        public string SourceUrl { get; set; }

        public string LocalUrl { get; set; }
        public RecipeCategory  RecipeCategory { get; set; }

        public int DietId { get; set; }

        public Diet Diet { get; set; }

        public int CousineId { get; set; }

        public Cousine Cousine { get; set; }
        public ICollection<Nutrition> Nutritions { get; set; }
        public ICollection<Instruction> Instructions { get; set; }
        public ICollection<Ingredients> Ingredients { get; set; }

    }
}
