using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmGeographicCoordinates
{
    [Column(TypeName = "decimal(8,6)")]
    public decimal Latitude { get; set; }
    [Column(TypeName = "decimal(8,6)")]
    public decimal Longitude { get; set; }
}
