using PAUYS.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.Repositories.Abstract
{
    public interface IPackingGuideRepository : IRepository<PackingGuide>
    {
        public PackingGuide? GetPackingGuide(Expression<Func<PackingGuide, bool>> predicate);
    }
}
