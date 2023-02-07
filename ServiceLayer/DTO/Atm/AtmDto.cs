using System.Text.Json.Serialization;

namespace ServiceLayer.DTO.Atm;

internal class AtmDto
{
    public int AtmId { get; set; }

    [JsonPropertyName("type")]
    public AtmTypeDto AtmTypeDto { get; set; }
    public string BaseCurrency { get; set; }
    public string Currency { get; set; }

    [JsonPropertyName("address")]
    public AtmAddressDto AtmAddressDto { get; set; }

    [JsonPropertyName("cards")]
    public List<CardSchemeDto> CardSchemesDto { get; set; }

    [JsonPropertyName("services")]
    public List<AtmServiceDto> AtmServicesDto { get; set; }
}

internal class AtmServiceDto
{
    public string ServiceName { get; set; }
    public string Description { get; set; }
}

internal class CardSchemeDto
{
    public string CardSchemeName { get; set; }
    public string Description { get; set; }
}

internal class AtmTypeDto
{
    public string AtmTypeName { get; set; }
    public string Description { get; set; }
}
