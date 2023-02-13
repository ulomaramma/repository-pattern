using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.Repositories
{
    public class DietRepository : GenericRepository<Diet>, IDietRepository
    {
        public DietRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }
    }
}
