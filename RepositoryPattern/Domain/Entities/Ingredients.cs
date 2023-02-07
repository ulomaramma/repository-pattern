using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ingredients : FullAuditInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public double Unit { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

    }
}
