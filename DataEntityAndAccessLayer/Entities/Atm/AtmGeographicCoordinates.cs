namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmGeographicCoordinates
{
    // public int GeographicCoordinatesId { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }

    // Relationships
    public int GeolocationId { get; set; }
}
