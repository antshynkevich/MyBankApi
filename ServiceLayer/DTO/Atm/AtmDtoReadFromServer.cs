using ServiceLayer.JsonConverters;
using System.Text.Json.Serialization;

namespace ServiceLayer.DTO.Atm;

public class AtmDtoReadFromServer
{
    [JsonConverter(typeof(IdConverter))]
    public int atmId { get; set; }
    public string type { get; set; }
    public string baseCurrency { get; set; }
    public string currency { get; set; }
    public ICollection<string> cards { get; set; }
}
