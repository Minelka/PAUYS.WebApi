using Microsoft.Extensions.DependencyInjection;
using PAUYS.DAL.Context;
using PAUYS.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.UnıtOfWorks
{
    public class UnitOfWork(PAUYSDbContext dbContext, IServiceProvider serviceProvider) : IUnitOfWork, IDisposable
    {
        private readonly PAUYSDbContext _dbContext = dbContext;
        private readonly IServiceProvider _serviceProvider = serviceProvider;
        private bool _disposed = false;

        public ICategoryRepository Categories => _serviceProvider.GetService<ICategoryRepository>() ?? null!;

        public IMaterialRepository Materials => _serviceProvider.GetService<IMaterialRepository>() ?? null!;

        public IProductRepository Products => _serviceProvider.GetService<IProductRepository>() ?? null!;


        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
