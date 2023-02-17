using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntityAndAccessLayer.Entities.Atm;

[Table(nameof(CardScheme) + "s")]
public class CardScheme
{
    public int CardSchemeId { get; set; }
    public string CardSchemeName { get; set; }
    public string Description { get; set; }
    public string DescriptionEng { get; set; }

    // Relationships
    public ICollection<Atm> Atms { get; set; } = new List<Atm>();
}
