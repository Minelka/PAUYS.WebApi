using PAUYS.DTO.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.Services.Abstract
{
    public interface IProductDalService : IDalService<ProductDto>
    {
        ICollection<ProductDto> GetAllWithMaterial(int materialId = 0);
        ICollection<ProductDto> GetAllWithCategory(int categoryId = 0);
    }
}
