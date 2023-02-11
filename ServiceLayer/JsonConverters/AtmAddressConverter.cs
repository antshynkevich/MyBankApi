using System.Text.Json;
using System.Text.Json.Serialization;
using ServiceLayer.DTO.Atm;

namespace ServiceLayer.JsonConverters;

public class AtmAddressConverter : JsonConverter<AtmAddressDto>
{
    public override AtmAddressDto? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                //switch (reader.GetString())
                //{
                //    case ""
                //}
            }


        }

        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, AtmAddressDto value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
