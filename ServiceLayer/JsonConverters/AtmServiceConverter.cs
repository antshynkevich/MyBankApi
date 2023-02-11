using System.Text.Json;
using System.Text.Json.Serialization;
using ServiceLayer.DTO.Atm;

namespace ServiceLayer.JsonConverters;

public class AtmServiceConverter : JsonConverter<List<AtmServiceDto>>
{
    public override List<AtmServiceDto>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, List<AtmServiceDto> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
