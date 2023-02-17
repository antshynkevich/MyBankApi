using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntityAndAccessLayer.Entities.Atm;

[Table(nameof(AtmType) + "s")]
public class AtmType
{
    public int AtmTypeId { get; set; }
    public string AtmTypeName { get; set; }
    public string Description { get; set; }

    // Relationship
    public ICollection<Atm> Atms { get; set; } = new List<Atm>();
}
