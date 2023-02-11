using System.Text.Json;
using System.Text.Json.Serialization;
using ServiceLayer.DTO.Atm;

namespace ServiceLayer.JsonConverters;

public class AtmTypeConverter : JsonConverter<AtmTypeDto>
{
    public override AtmTypeDto? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new AtmTypeDto()
        {
            AtmTypeName = reader.GetString() ?? "",
        };
    }

    public override void Write(Utf8JsonWriter writer, AtmTypeDto value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
