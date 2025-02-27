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
	public class NewsRepository : Repository<News>, INewsRepository
	{
		public PAUYSDbContext PAUYSDbContext => _dbContext;

		public NewsRepository(PAUYSDbContext dbContext) : base(dbContext)
		{ }

		public News? GetNews(Expression<Func<News, bool>> predicate)
		{
			return _entities.Where(predicate).SingleOrDefault();
		}
	}
}
