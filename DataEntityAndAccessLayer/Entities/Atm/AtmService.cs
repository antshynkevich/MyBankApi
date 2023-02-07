namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmService
{
    public int AtmServiceId { get; set; }
    public string ServiceName { get; set; }
    public string Description { get; set; }

    // Relationships
    public ICollection<Atm> Atms { get; set; }
}
