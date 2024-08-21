// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Weather
{
    public partial class LocalSource
    {
        internal static LocalSource DeserializeLocalSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? id = default;
            string name = default;
            string weatherCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weatherCode"u8))
                {
                    weatherCode = property.Value.GetString();
                    continue;
                }
            }
            return new LocalSource(id, name, weatherCode);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LocalSource FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLocalSource(document.RootElement);
        }
    }
}
