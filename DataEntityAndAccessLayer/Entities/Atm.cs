using ServiceLayer.ViewModels.Enums;

namespace DataEntityAndAccessLayer.Entities;

public class Atm
{
    public int AtmId { get; set; }
    public AtmTypeStaticType AtmTypeStaticType { get; set; }
    public int AtmAddressId { get; set; }
    public string BaseCurrency { get; set; }
    public string Currency { get; set; }

    // Relationships
    public AtmAddress AtmAddress { get; set; }
}
