using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.Repositories
{
    
    public class NutritionRepository : GenericRepository<Nutrition>, INutritionRepository
    {
        public NutritionRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }
    }
}
