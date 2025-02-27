using AutoMapper;
using PAUYS.DAL.Repositories.Abstract;
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
	public class NewsDalService : DalService<NewsDto, News>, INewsDalService
	{
		public NewsDalService(IUnitOfWork unitOfWork, INewsRepository newsRepository, IMapper mapper) : base(unitOfWork, newsRepository, mapper)
		{ }
	}
}
