using AutoMapper;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DTO.Concrete;
using PAUYS.ViewModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.BLL.Managers.Concrete
{
    public class PackingGuideManager : Manager<PackingGuideViewModel, PackingGuideDto, int>, IPackingGuideManager
    {
        public PackingGuideManager(IPackingGuideDalService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
