﻿using System.Text.Json.Serialization;

namespace ServiceLayer.DTO.Atm;

internal class AtmAddressDto
{
    public string StreetName { get; set; }
    public string BuildingNumber { get; set; }
    public string TownName { get; set; }
    public string CountrySubDivision { get; set; }
    public string Country { get; set; }
    public string AddressLine { get; set; }
    public string Description { get; set; }

    [JsonPropertyName("geolocation")]
    public AtmGeolocationDto AtmGeolocationDto { get; set; }
}

internal class AtmGeolocationDto
{
    [JsonPropertyName("geographicCoordinates")]
    public AtmGeographicCoordinatesDto AtmGeographicCoordinatesDto { get; set; }
}

internal class AtmGeographicCoordinatesDto
{
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}