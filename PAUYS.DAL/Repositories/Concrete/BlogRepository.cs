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
	public class BlogRepository : Repository<Blog>, IBlogRepository
	{
		public PAUYSDbContext PAUYSDbContext => _dbContext;

		public BlogRepository(PAUYSDbContext dbContext) : base(dbContext) 
		{ }

		public Blog? GetBlog(Expression<Func<Blog, bool>> predicate)
		{
			return _entities.Where(predicate).SingleOrDefault();
		}
	}
}
