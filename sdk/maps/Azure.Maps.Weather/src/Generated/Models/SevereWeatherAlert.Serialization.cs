// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather
{
    public partial class SevereWeatherAlert
    {
        internal static SevereWeatherAlert DeserializeSevereWeatherAlert(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string countryCode = default;
            int? alertId = default;
            SevereWeatherAlertDescription description = default;
            string category = default;
            int? priority = default;
            string @class = default;
            string level = default;
            string source = default;
            int? sourceId = default;
            string disclaimer = default;
            IReadOnlyList<AlertDetails> alertAreas = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = SevereWeatherAlertDescription.DeserializeSevereWeatherAlertDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("class"u8))
                {
                    @class = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    level = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("disclaimer"u8))
                {
                    disclaimer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertAreas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AlertDetails> array = new List<AlertDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Weather.AlertDetails.DeserializeAlertDetails(item));
                    }
                    alertAreas = array;
                    continue;
                }
            }
            return new SevereWeatherAlert(
                countryCode,
                alertId,
                description,
                category,
                priority,
                @class,
                level,
                source,
                sourceId,
                disclaimer,
                alertAreas ?? new ChangeTrackingList<AlertDetails>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SevereWeatherAlert FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSevereWeatherAlert(document.RootElement);
        }
    }
}
