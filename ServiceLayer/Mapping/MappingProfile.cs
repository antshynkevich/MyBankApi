using System.Globalization;
using AutoMapper;
using DataEntityAndAccessLayer.Entities.Atm;
using ServiceLayer.DTO.Atm;

namespace ServiceLayer.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Atm, AtmDto>()
            .ForMember(atmDto => atmDto.AtmId, expr => expr.MapFrom(atm => atm.AtmId.ToString()))
            .ForMember(atmDto => atmDto.AtmType, expr => expr.MapFrom(atm => atm.AtmType.AtmTypeName))
            .ForMember(atmDto => atmDto.Cards, expr =>
                expr.MapFrom(atm => atm.AtmCardSchemes.Select(p => p.CardSchemeName)))
            .ForMember(atmDto => atmDto.AtmAddress, expr => expr.MapFrom(atm => atm.AtmAddress))
            .ForMember(x => x.AtmAvailabilityDto, e => e.MapFrom(y => y.AtmAvailability))
            .ForMember(x => x.ContactDetailsDto, e => e.MapFrom(y => y.ContactDetails));

        CreateMap<AtmService, AtmServiceDto>()
            .ForMember(x => x.ServiceType, e => e.MapFrom(y => y.Description))
            .ForMember(x => x.Description, e => e.Ignore());

        CreateMap<ContactDetails, ContactDetailsDto>();

        // Address mapping
        CreateMap<AtmAddress, AtmAddressDto>()
            .ForMember(atmDto => atmDto.AtmGeolocationDto,
                expr => expr.MapFrom(atm => atm.AtmGeolocation));
        CreateMap<AtmGeolocation, AtmGeolocationDto>()
            .ForMember(x => x.AtmGeographicCoordinatesDto, e => e.MapFrom(y => y.AtmGeographicCoordinates));
        CreateMap<AtmGeographicCoordinates, AtmGeographicCoordinatesDto>()
            .ForMember(x => x.Latitude, expr => expr.MapFrom(y => y.Latitude.ToString(CultureInfo.InvariantCulture)))
            .ForMember(x => x.Longitude, expr => expr.MapFrom(y => y.Longitude.ToString(CultureInfo.InvariantCulture)));

        // Availability days mapping
        CreateMap<AtmAvailability, AtmAvailabilityDto>()
            .ForMember(x => x.StandardAvailabilityDto, e => e.MapFrom(y => y.AtmStandardAvailability));
        CreateMap<AtmStandardAvailability, StandardAvailabilityDto>()
            .ForMember(x => x.Days, e => e.MapFrom(y => y.Days));
        CreateMap<AtmDay, DayDto>()
            .ForMember(x => x.DayCode, expr => expr.MapFrom(y => y.DayCode.ToString("D2")))
            .ForMember(x => x.OpeningTime, expr => expr.MapFrom(y => y.OpeningTime.ToString()))
            .ForMember(x => x.ClosingTime, expr => expr.MapFrom(y => y.ClosingTime.ToString()))
            .ForMember(x => x.Break, ex => ex.MapFrom(y => y.AtmBreak));
        CreateMap<AtmBreak, BreakDto>()
            .ForMember(breakDto => breakDto.BreakFromTime,
                expr => expr.MapFrom(br => br.BreakFromTime))
            .ForMember(breakDto => breakDto.BreakToTime,
                expr => expr.MapFrom(br => br.BreakToTime));
    }
}
