using AutoMapper;
using DataEntityAndAccessLayer.Entities.Atm;

namespace ServiceLayer.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Atm, ATM>()
            .ForMember(atm => 
                atm.atmId, opt => opt.MapFrom(x => x.AtmId))
            .ForMember(atm => atm.type, opt => opt.MapFrom(x => x.AtmType.AtmTypeName))
            .ReverseMap();
    }
}
