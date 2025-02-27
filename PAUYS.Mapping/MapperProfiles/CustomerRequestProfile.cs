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
    public class CustomerRequestProfile : Profile
    {
        public CustomerRequestProfile() 
        {
            CreateMap<CustomerRequestViewModel, CustomerRequestDto>()
            .ReverseMap();

            CreateMap<CustomerRequestDto, CustomerRequest>()
               .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status))
               .ReverseMap();
        }
    }
}
