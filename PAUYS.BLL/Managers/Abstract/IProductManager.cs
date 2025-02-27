using PAUYS.DTO.Concrete;
using PAUYS.ViewModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.BLL.Managers.Abstract
{
    public interface IProductManager : IManager<ProductViewModel, ProductDto>
    {
        ICollection<ProductViewModel> GetAllWithMaterial(int materialId = 0);
        ICollection<ProductViewModel> GetAllWithCategory(int categoryId = 0);

    }
}
