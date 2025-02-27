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
	public class BlogDalService : DalService<BlogDto, Blog>, IBlogDalService
	{
		public BlogDalService(IUnitOfWork unitOfWork, IBlogRepository blogRepository, IMapper mapper) : base(unitOfWork, blogRepository, mapper)
		{ }
	}
}
