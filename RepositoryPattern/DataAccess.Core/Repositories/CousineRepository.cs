using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.Repositories
{
    public class CousineRepository : GenericRepository<Cousine>, ICousineRepository
    {
   /// <summary>
   /// 
   /// </summary>
   /// <param name="dbContext"></param>
        public CousineRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }
    }
}
