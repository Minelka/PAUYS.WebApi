using AutoMapper;
using PAUYS.DAL.Repositories.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DAL.UnıtOfWorks;
using PAUYS.DTO.Concrete;
using PAUYS.Entity.Entities.Concrete;

namespace PAUYS.DAL.Services.Concrete
{
    public class ProductDalService : DalService<ProductDto, Product>, IProductDalService
    {
        private readonly IProductRepository _productRepository;
        public ProductDalService(IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(unitOfWork, productRepository, mapper)
        {
            _productRepository = productRepository;
        }

        public ICollection<ProductDto> GetAllWithMaterial(int materialId = 0)
        {
            ICollection<Product> productWithMaterial = _productRepository.GetAllWithMaterial(materialId);

            return _mapper.Map<ICollection<ProductDto>>(productWithMaterial);
        }
        public ICollection<ProductDto> GetAllWithCategory(int categoryId = 0)
        {
            ICollection<Product> productWithCategory = _productRepository.GetAllWithCategory(categoryId);

            return _mapper.Map<ICollection<ProductDto>>(productWithCategory);
        }
    }
}
