using System.ComponentModel.DataAnnotations;

namespace DataEntityAndAccessLayer.Entities.Atm;

public class Atm
{
    public int AtmId { get; set; }
    [Required]
    public string BaseCurrency { get; set; }
    [Required]
    public string Currency { get; set; }

    // Relationships
    [Required]
    public AtmType AtmType { get; set; }
    [Required]
    public AtmAddress AtmAddress { get; set; }
    public ICollection<CardScheme> AtmCardSchemes { get; set; }
    [Required]
    public ICollection<AtmService> AtmServices { get; set; }
    public AtmAvailability AtmAvailability { get; set; }
    public ContactDetails ContactDetails { get; set; }
}
