using System.Globalization;
using DataEntityAndAccessLayer;
using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.Mapping;

internal class AtmMappingHelper
{
    private readonly BankDbContext _context;

    public AtmMappingHelper(BankDbContext context)
    {
        _context = context;
    }

    public async Task<Atm> ConvertToEntity(ATM jsonObj)
    {
        var atmToDb = new Atm
        {
            AtmType = await GetAtmType(jsonObj.type),
            BaseCurrency = jsonObj.baseCurrency,
            Currency = jsonObj.currency,
            AtmCardSchemes = GetCardSchemes(jsonObj.cards),
            AtmAddress = new AtmAddress
            {
                StreetName = jsonObj.Address.streetName,
                BuildingNumber = jsonObj.Address.buildingNumber,
                TownName = jsonObj.Address.townName,
                CountrySubDivision = jsonObj.Address.countrySubDivision,
                Country = jsonObj.Address.country,
                AddressLine = jsonObj.Address.addressLine,
                Description = jsonObj.Address.description,
                AtmGeolocation = new AtmGeolocation
                {
                    AtmGeographicCoordinates = new AtmGeographicCoordinates
                    {
                        Longitude = decimal.Parse(jsonObj.Address.Geolocation.GeographicCoordinates.longitude, 
                            NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture),
                        Latitude = decimal.Parse(jsonObj.Address.Geolocation.GeographicCoordinates.latitude, 
                            NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture)
                    }
                }
            },

            AtmServices = GetAtmServices(jsonObj.Services),
            AtmAvailability = GetAvailability(jsonObj.Availability),
            ContactDetails = new ContactDetails { PhoneNumber = jsonObj.ContactDetails.phoneNumber }
        };

        return atmToDb;
    }

    public async Task<AtmType?> GetAtmType(string typeName)
    {
        return await _context.AtmTypes.FirstOrDefaultAsync(type => type.AtmTypeName == typeName);
    }

    public List<CardScheme?>  GetCardSchemes(string[] cards)
    {
        return cards.Select(card => _context.CardSchemes.FirstOrDefault(cs => cs.CardSchemeName == card)).ToList();
    }

    public List<AtmService?> GetAtmServices(Service[] services)
    {
        return services.Select(service => _context.AtmServices.FirstOrDefault(ser => ser.Description == service.serviceType)).ToList();
    }

    public AtmAvailability GetAvailability(Availability availability)
    {
        return new AtmAvailability
        {
            Access24Hours = availability.access24Hours,
            IsRestricted = availability.isRestricted,
            SameAsOrganization = availability.sameAsOrganization,
            AtmStandardAvailability = new AtmStandardAvailability
            {
                Days = GetAtmDays(availability.StandardAvailability.Day).ToList()
            }
        };
    }

    public AtmDay[] GetAtmDays(Day[] days)
    {
        var atmDays = new AtmDay[days.Length];

        for (var i = 0; i < days.Length; i++)
        {
            var day = days[i];
            atmDays[i] = new AtmDay
            {
                DayCode = int.Parse(day.dayCode),
                OpeningTime = TimeSpan.Parse(day.openingTime),
                ClosingTime = TimeConverter(day.closingTime),
                AtmBreak = new AtmBreak
                {
                    BreakFromTime = TimeSpan.Parse(day.Break.breakFromTime),
                    BreakToTime = TimeSpan.Parse(day.Break.breakToTime)
                }
            };
        }

        return atmDays;
    }

    public TimeSpan TimeConverter(string input)
    {
        return input.Equals("24:00") ? new TimeSpan(23,59, 0) : TimeSpan.Parse(input);
    }
}
