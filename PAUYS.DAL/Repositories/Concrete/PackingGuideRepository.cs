using PAUYS.DAL.Context;
using PAUYS.DAL.Repositories.Abstract;
using PAUYS.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.Repositories.Concrete
{
    public class PackingGuideRepository : Repository<PackingGuide>, IPackingGuideRepository
    {
        public PAUYSDbContext PAUYSDbContext => _dbContext;

        public PackingGuideRepository(PAUYSDbContext dbContext) : base(dbContext)
        { }

        public PackingGuide? GetPackingGuide(Expression<Func<PackingGuide, bool>> predicate)
        {
            return _entities.Where(predicate).SingleOrDefault();
        }
    }
}
