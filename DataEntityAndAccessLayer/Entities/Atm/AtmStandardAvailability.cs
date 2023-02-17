using System.ComponentModel.DataAnnotations;

namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmStandardAvailability
{
    public int AtmStandardAvailabilityId { get; set; }

    // Relationships
    public int AtmAvailabilityId { get; set; }
    public ICollection<AtmDay> Days { get; set; }
}
