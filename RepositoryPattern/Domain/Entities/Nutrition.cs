﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Nutrition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }
        public int Percentage { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public ICollection<Nutrient>  Nutrients { get; set; }

    }
}
