using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAUYS.DAL.Repositories.Abstract;
using PAUYS.Entity.Entities.Concrete;
using PAUYS.DAL.Context;
using System.Linq.Expressions;

namespace PAUYS.DAL.Repositories.Concrete
{
    public class MaterialRepository : Repository<Material>, IMaterialRepository
    {
        public PAUYSDbContext PAUYSDbContext => _dbContext;

        public MaterialRepository(PAUYSDbContext dbContext) : base(dbContext)
        { }

        public Material? GetMaterial(Expression<Func<Material, bool>> predicate)
        {
            return _entities.Where(predicate).SingleOrDefault();
        }
    }


   
}

