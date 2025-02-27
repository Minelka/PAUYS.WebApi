﻿using AutoMapper;
using PAUYS.DTO.Concrete;
using PAUYS.Entity.Entities.Concrete;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.Mapping.MapperProfiles
{
    public class MaterialProfile : Profile
	{
		public MaterialProfile()
		{
            CreateMap<MaterialDto,Material>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products))
                .ReverseMap();

            CreateMap<MaterialViewModel, MaterialDto>()
             .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.ProductViewModels))
             .ReverseMap();
        }


	}
}
