// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Weather
{
    public partial class WeatherValueYearMaxMinAvg
    {
        internal static WeatherValueYearMaxMinAvg DeserializeWeatherValueYearMaxMinAvg(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WeatherValueYear maximum = default;
            WeatherValueYear minimum = default;
            WeatherValue average = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = WeatherValueYear.DeserializeWeatherValueYear(property.Value);
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = WeatherValueYear.DeserializeWeatherValueYear(property.Value);
                    continue;
                }
                if (property.NameEquals("average"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    average = WeatherValue.DeserializeWeatherValue(property.Value);
                    continue;
                }
            }
            return new WeatherValueYearMaxMinAvg(maximum, minimum, average);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static WeatherValueYearMaxMinAvg FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWeatherValueYearMaxMinAvg(document.RootElement);
        }
    }
}
