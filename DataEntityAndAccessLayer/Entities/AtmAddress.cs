namespace DataEntityAndAccessLayer.Entities;

public class AtmAddress
{
    public int AtmAddressId { get; set; }
    public string StreetName { get; set; }
    public string BuildingNumber { get; set; }
    public string TownName { get; set; }
    public string CountrySubDivision { get; set; }
    public string Code { get; set; }
    public string AddressLine { get; set; }
    public string Description { get; set; }

    // Relationships
    public int AtmId { get; set; }
}
