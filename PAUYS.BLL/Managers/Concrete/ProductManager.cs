using AutoMapper;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DAL.Services.Concrete;
using PAUYS.DTO.Concrete;
using PAUYS.ViewModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.BLL.Managers.Concrete
{

    public class ProductManager : Manager<ProductViewModel, ProductDto, int>, IProductManager
    {
        private readonly IProductDalService _productDalService;
        public ProductManager(IProductDalService service, IMapper mapper) : base(service, mapper)
        {
        }
        public ICollection<ProductViewModel> GetAllWithMaterial(int materialId = 0)
        {
            ICollection<ProductDto>productWithMaterial = _productDalService.GetAllWithMaterial(materialId);
            return _mapper.Map<ICollection<ProductViewModel>>(productWithMaterial);
        }
        public ICollection<ProductViewModel> GetAllWithCategory(int categoryId = 0)
        {
            ICollection<ProductDto> productWithCategory = _productDalService.GetAllWithCategory(categoryId);
            return _mapper.Map<ICollection<ProductViewModel>>(productWithCategory);
        }
    }
}
