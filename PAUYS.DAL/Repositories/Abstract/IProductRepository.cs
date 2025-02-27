using PAUYS.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.Repositories.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        ICollection<Product> GetAllWithMaterial(int materialId = 0);
        ICollection<Product> GetAllWithCategory(int categoryId = 0);
    }
}
