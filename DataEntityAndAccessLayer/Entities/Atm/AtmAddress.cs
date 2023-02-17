using System.ComponentModel.DataAnnotations;

namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmAddress
{
    public string StreetName { get; set; }
    public string BuildingNumber { get; set; }
    [Required]
    public string TownName { get; set; }
    public string CountrySubDivision { get; set; }
    public string Country { get; set; }
    public string AddressLine { get; set; }
    public string Description { get; set; }

    // Relationships
    public AtmGeolocation AtmGeolocation { get; set; }
}
