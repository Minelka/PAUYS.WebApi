using Microsoft.EntityFrameworkCore;
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
    public class CustomerRequestRepository : Repository<CustomerRequest>, ICustomerRequestRepository
    {
        public PAUYSDbContext PAUYSDbContext => _dbContext;

        public CustomerRequestRepository(PAUYSDbContext dbContext) : base(dbContext)
        { }

        public CustomerRequest? GetCustomerRequest(Expression<Func<CustomerRequest, bool>> predicate)
        {
            return _entities.Where(predicate).SingleOrDefault();
        }
    }
}
