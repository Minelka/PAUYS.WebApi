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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public PAUYSDbContext PAUYSDbContext => _dbContext;

        public CategoryRepository(PAUYSDbContext dbContext) : base(dbContext)
        { }

        public Category? GetCategory(Expression<Func<Category, bool>> predicate)
        {
            return _entities.Where(predicate).SingleOrDefault();
        }
    }


   
}

