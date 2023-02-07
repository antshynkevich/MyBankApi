namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmType
{
    public int AtmTypeId { get; set; }
    public string AtmTypeName { get; set; }
    public string Description { get; set; }

    // Relationship
    public ICollection<Atm> Atms { get; set; }
}
