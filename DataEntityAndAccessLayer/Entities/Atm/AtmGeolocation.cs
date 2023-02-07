using System.ComponentModel.DataAnnotations;

namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmGeolocation
{
    // public int GeolocationId { get; set; }

    // Relationships
    public int AtmId { get; set; }
    [Required]
    public AtmGeographicCoordinates AtmGeographicCoordinates { get; set; }
}
