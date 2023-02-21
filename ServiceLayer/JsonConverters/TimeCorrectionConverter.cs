using System.Text.Json;
using System.Text.Json.Serialization;

namespace ServiceLayer.JsonConverters;

public class TimeCorrectionConverter : JsonConverter<string>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        var output = value[..5];
        writer.WriteStringValue(output == "23:59" ? "24:00" : output);
    }
}
