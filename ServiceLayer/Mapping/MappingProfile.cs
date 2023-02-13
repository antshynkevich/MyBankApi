using AutoMapper;
using DataEntityAndAccessLayer.Entities.Atm;

namespace ServiceLayer.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ATM, Atm>()
            //.ForMember(atm => 
            //    atm.atmId, opt => opt.MapFrom(x => x.AtmId))
            .ForMember(dest => dest.AtmType.AtmTypeName, act => act.MapFrom(src => src.type))
            .ForMember(dest => dest.AtmAddress, act => act.MapFrom(src => src.Address))
            .ForMember(dest => dest.AtmAddress.AtmGeolocation, act => act.MapFrom(src => src.Address.Geolocation))
            .ReverseMap();
    }
}
