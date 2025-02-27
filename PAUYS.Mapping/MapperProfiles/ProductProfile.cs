using AutoMapper;
using PAUYS.DTO.Concrete;
using PAUYS.Entity.Entities.Concrete;
using PAUYS.ViewModel.Concrete;

namespace PAUYS.Mapping.MapperProfiles
{
    public class ProductProfile : Profile
	{
		//public ProductProfile()
		//{
  //          CreateMap<ProductDto, Product>()
  //             .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status))
  //             .ForMember(dest => dest.Material, opt => opt.MapFrom(src => src.MaterialDto))
  //             .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.Categories))
  //             .ReverseMap();

  //          CreateMap<ProductViewModel, ProductDto>()
  //              .ForMember(dest => dest.Categories, opt => opt.MapFrom(src => src.CategoryViewModels))
  //              .ReverseMap();
  //      }

        public ProductProfile()
        {
            CreateMap<ProductDto, Product>()
               .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status))
               .ForMember(dest => dest.Material, opt => opt.MapFrom(src => src.MaterialDto))
               .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.CategoryDto))              
               .ReverseMap();

            CreateMap<ProductViewModel, ProductDto>()
                
                .ForMember(dest => dest.CategoryDto, opt => opt.MapFrom(src => src.CategoryViewModel))
                .ForMember(dest => dest.MaterialDto, opt => opt.MapFrom(src => src.MaterialViewModel))        // ekledim yoktu yapıda
                .ReverseMap();
        }
    }
}
