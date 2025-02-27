using PAUYS.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.Repositories.Abstract
{
    //Bu örnekte c => c.Name == "Prefincate" ifadesi, material ismi "Prefincate" olan bir material nesnesini sorgulayan bir predicate örneğidir.
    public interface IMaterialRepository : IRepository<Material>
    {
        public Material? GetMaterial(Expression<Func<Material, bool>> predicate);
    }
}
