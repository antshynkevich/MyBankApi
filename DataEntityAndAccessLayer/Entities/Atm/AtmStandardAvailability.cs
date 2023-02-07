using System.ComponentModel.DataAnnotations;

namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmStandardAvailability
{
    public int AtmStandardAvailabilityId { get; set; }

    // Relationships
    public int AvailabilityId { get; set; }
    [Required]
    [MaxLength(7)]
    public ICollection<AtmDay> Days { get; set; }
}
