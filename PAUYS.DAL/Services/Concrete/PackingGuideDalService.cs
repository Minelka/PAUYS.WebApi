using AutoMapper;
using PAUYS.DAL.Repositories.Abstract;
using PAUYS.DAL.Repositories.Concrete;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DAL.UnıtOfWorks;
using PAUYS.DTO.Concrete;
using PAUYS.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.Services.Concrete
{
    public class PackingGuideDalService : DalService<PackingGuideDto, PackingGuide>, IPackingGuideDalService
    {
        public PackingGuideDalService(IUnitOfWork unitOfWork, IPackingGuideRepository packingGuideRepository, IMapper mapper) : base(unitOfWork, packingGuideRepository, mapper)
        { }
    }
}
