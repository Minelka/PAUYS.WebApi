using AutoMapper;
using PAUYS.DAL.Repositories.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DAL.UnıtOfWorks;
using PAUYS.DTO.Concrete;
using PAUYS.Entity.Entities.Concrete;

namespace PAUYS.DAL.Services.Concrete
{
    public class CategoryDalService : DalService<CategoryDto, Category>, ICategoryDalService
    {
        public CategoryDalService(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(unitOfWork, categoryRepository, mapper)
        { }
    }
}

