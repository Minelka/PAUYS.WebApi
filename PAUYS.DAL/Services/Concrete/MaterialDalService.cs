using AutoMapper;
using PAUYS.DAL.Repositories.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DAL.UnıtOfWorks;
using PAUYS.DTO.Concrete;
using PAUYS.Entity.Entities.Concrete;

namespace PAUYS.DAL.Services.Concrete
{
    public class MaterialDalService : DalService<MaterialDto, Material>, IMaterialDalService
    {
        public MaterialDalService(IUnitOfWork unitOfWork, IMaterialRepository materialRepository, IMapper mapper) : base(unitOfWork, materialRepository, mapper)
        { }
    }
}
