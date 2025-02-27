using PAUYS.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.UnıtOfWorks
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }
        IMaterialRepository Materials { get; }
        IProductRepository Products { get; }
        int Complete();
    }
}
