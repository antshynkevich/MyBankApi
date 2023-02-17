using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntityAndAccessLayer.Entities.Atm;

[Table(nameof(AtmService) + "s")]
public class AtmService
{
    public int AtmServiceId { get; set; }
    public string ServiceName { get; set; }
    public string Description { get; set; }
    public string DescriptionEng { get; set; }

    // Relationships
    public ICollection<Atm> Atms { get; set; } = new List<Atm>();
}
