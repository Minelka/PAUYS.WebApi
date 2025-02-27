using PAUYS.Entity.Entities.Concrete;
using System.Linq.Expressions;

namespace PAUYS.DAL.Repositories.Abstract
{
    public interface ICustomerRequestRepository : IRepository<CustomerRequest>
    {
        public CustomerRequest? GetCustomerRequest(Expression<Func<CustomerRequest, bool>> predicate);
    }
}
