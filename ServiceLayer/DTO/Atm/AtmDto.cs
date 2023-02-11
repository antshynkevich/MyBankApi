using System.Text.Json.Serialization;
using ServiceLayer.JsonConverters;

namespace ServiceLayer.DTO.Atm;

public class AtmDto
{
    [JsonConverter(typeof(IdConverter))]
    public int AtmId { get; set; }

    [JsonConverter(typeof(AtmTypeConverter))]
    [JsonPropertyName("type")]
    public AtmTypeDto AtmTypeDto { get; set; }

    public string BaseCurrency { get; set; }
    public string Currency { get; set; }

    [JsonPropertyName("address")]
    [JsonConverter(typeof(AtmAddressConverter))]
    public AtmAddressDto AtmAddressDto { get; set; }

    [JsonPropertyName("cards")]
    [JsonConverter(typeof(CardSchemeConverter))]
    public List<CardSchemeDto> CardSchemesDto { get; set; }

    [JsonPropertyName("services")]
    [JsonConverter(typeof(AtmServiceConverter))]
    public List<AtmServiceDto> AtmServicesDto { get; set; }
}

public class AtmServiceDto
{
    public string ServiceName { get; set; }
    public string Description { get; set; }
}

public class CardSchemeDto
{
    public string CardSchemeName { get; set; }
    public string Description { get; set; }
}

public class AtmTypeDto
{
    public string AtmTypeName { get; set; }
    // public string Description { get; set; }
}
