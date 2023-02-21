using System.Text.Json.Serialization;
using ServiceLayer.JsonConverters;

namespace ServiceLayer.DTO.Atm;

public class AtmDto
{
    public string AtmId { get; set; }
    [JsonPropertyName("type")]
    public string AtmType { get; set; }
    public string BaseCurrency { get; set; }
    public string Currency { get; set; }
    public List<string> Cards { get; set; }
    [JsonPropertyName("address")]
    public AtmAddressDto AtmAddress { get; set; }
    [JsonPropertyName("services")]
    public List<AtmServiceDto> AtmServices{ get; set; }
    [JsonPropertyName("availability")]
    public AtmAvailabilityDto AtmAvailabilityDto { get; set; }
    [JsonPropertyName("contactDetails")]
    public ContactDetailsDto ContactDetailsDto { get; set; }
}

public class AtmServiceDto
{
    public string ServiceType { get; set; }
    public string Description { get; set; } = string.Empty;
}

public class AtmAvailabilityDto
{
    public bool Access24Hours { get; set; }
    public bool IsRestricted { get; set; }
    public bool SameAsOrganization { get; set; }
    [JsonPropertyName("standardAvailability")]
    public StandardAvailabilityDto StandardAvailabilityDto { get; set; }
}

public class StandardAvailabilityDto
{
    public List<DayDto> Days { get; set; }
}

public class DayDto
{
    public string DayCode { get; set; }
    [JsonConverter(typeof(TimeCorrectionConverter))]
    public string OpeningTime { get; set; }
    [JsonConverter(typeof(TimeCorrectionConverter))]
    public string ClosingTime { get; set; }
    public BreakDto Break { get; set; }
}

public class BreakDto
{
    [JsonConverter(typeof(TimeCorrectionConverter))]
    public string BreakFromTime { get; set; }
    [JsonConverter(typeof(TimeCorrectionConverter))]
    public string BreakToTime { get; set; }
}

public class ContactDetailsDto
{
    public string PhoneNumber { get; set; }
}
