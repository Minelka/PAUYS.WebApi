using AutoMapper;
using PAUYS.DTO.Concrete;
using PAUYS.Entity.Entities.Concrete;
using PAUYS.ViewModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.Mapping.MapperProfiles
{
	public class NewsProfile : Profile
	{
		public NewsProfile()
		{
			CreateMap<NewsViewModel, NewsDto>()
				.ReverseMap();


			CreateMap<NewsDto, News>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status))
                .ReverseMap();
		}
	}
}
