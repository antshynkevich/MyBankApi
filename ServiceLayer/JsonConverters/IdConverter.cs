using System.Text.Json;
using System.Text.Json.Serialization;

namespace ServiceLayer.JsonConverters;

public class IdConverter : JsonConverter<int>
{
    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? stringValue = reader.GetString();
        if (int.TryParse(stringValue, out int value))
        {
            return value;
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value);
    }
}
