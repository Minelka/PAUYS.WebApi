using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using PAUYS.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAUYS.Entity.Entities.Concrete;
using PAUYS.DAL.Context;

namespace PAUYS.DAL.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public PAUYSDbContext PAUYSDbContext => _dbContext;

        public ProductRepository(PAUYSDbContext dbContext) : base(dbContext)
        { }

        public ICollection<Product> GetAllWithMaterial(int materialId = 0)
        {
            IIncludableQueryable<Product, Material> materialIncludeProduct = _dbContext.Products.Include(p => p.Material);
            return (materialId > 0) ? materialIncludeProduct.Where(p => p.MaterialId == materialId).ToList() : materialIncludeProduct.ToList();
        }
        public ICollection<Product> GetAllWithCategory(int categoryId = 0)
        {
            IIncludableQueryable<Product, Category> categoryIncludeProduct = _dbContext.Products.Include(p => p.Category);
            return (categoryId > 0) ? categoryIncludeProduct.Where(p => p.CategoryId == categoryId).ToList() : categoryIncludeProduct.ToList();
        }
    }

}
