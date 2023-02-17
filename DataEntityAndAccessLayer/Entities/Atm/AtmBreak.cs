using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntityAndAccessLayer.Entities.Atm;

public class AtmBreak
{
    [Required]
    [Column(TypeName = "time")]
    public TimeSpan BreakFromTime { get; set; }
    [Required]
    [Column(TypeName = "time")]
    public TimeSpan BreakToTime { get; set; }
}
