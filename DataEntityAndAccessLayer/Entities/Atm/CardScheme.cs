namespace DataEntityAndAccessLayer.Entities.Atm;

public class CardScheme
{
    public int CardSchemeId { get; set; }
    public string CardSchemeName { get; set; }
    public string Description { get; set; }

    // Relationships
    public ICollection<Atm> Atms { get; set; }
}
