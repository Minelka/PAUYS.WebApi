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
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public PAUYSDbContext PAUYSDbContext => _dbContext;

        public QuestionRepository(PAUYSDbContext dbContext) : base(dbContext)
        { }

        public Question? GetQuestion(Expression<Func<Question, bool>> predicate)
        {
            return _entities.Where(predicate).SingleOrDefault();
        }
    }
}
