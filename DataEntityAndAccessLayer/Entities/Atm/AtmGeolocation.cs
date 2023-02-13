using System.ComponentModel.DataAnnotations;

namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmGeolocation
{
    [Required]
    public AtmGeographicCoordinates AtmGeographicCoordinates { get; set; }
}
