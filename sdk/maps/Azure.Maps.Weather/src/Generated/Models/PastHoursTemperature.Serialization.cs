// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Weather
{
    public partial class PastHoursTemperature
    {
        internal static PastHoursTemperature DeserializePastHoursTemperature(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WeatherValue minimum = default;
            WeatherValue maximum = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = WeatherValue.DeserializeWeatherValue(property.Value);
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = WeatherValue.DeserializeWeatherValue(property.Value);
                    continue;
                }
            }
            return new PastHoursTemperature(minimum, maximum);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PastHoursTemperature FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePastHoursTemperature(document.RootElement);
        }
    }
}
