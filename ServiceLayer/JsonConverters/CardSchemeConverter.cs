using System.Text.Json;
using System.Text.Json.Serialization;
using ServiceLayer.DTO.Atm;

namespace ServiceLayer.JsonConverters;

public class CardSchemeConverter : JsonConverter<CardSchemeDto>
{
    public override CardSchemeDto? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, CardSchemeDto value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
