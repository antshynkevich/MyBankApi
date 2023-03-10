using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntityAndAccessLayer.Entities.Atm;

[Table(nameof(AtmDay) + "s")]
public class AtmDay
{
    public int AtmDayId { get; set; }
    [Required]
    public int DayCode { get; set; }
    [Column(TypeName = "time")]
    public TimeSpan? OpeningTime { get; set; }
    [Column(TypeName = "time")]
    public TimeSpan? ClosingTime { get; set; }

    // Relationships
    [Required]
    public AtmBreak AtmBreak { get; set; }
    public int AtmStandardAvailabilityId { get; set; }
}
