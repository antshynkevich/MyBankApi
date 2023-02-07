using System.ComponentModel.DataAnnotations;

namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmAvailability
{
    public int AtmAvailabilityId { get; set; }
    public bool Access24Hours { get; set; }
    public bool IsRestricted { get; set; }
    public bool SameAsOrganization { get; set; }

    // Relationships
    [Required]
    public AtmStandardAvailability AtmStandardAvailability { get; set; }
}
