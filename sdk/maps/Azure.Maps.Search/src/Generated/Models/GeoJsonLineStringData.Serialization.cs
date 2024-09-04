// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Maps.Search.Models
{
    public partial class GeoJsonLineStringData
    {
        internal static GeoJsonLineStringData DeserializeGeoJsonLineStringData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IList<double>> coordinates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"u8))
                {
                    List<IList<double>> array = new List<IList<double>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<double> array0 = new List<double>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetDouble());
                            }
                            array.Add(array0);
                        }
                    }
                    coordinates = array;
                    continue;
                }
            }
            return new GeoJsonLineStringData(coordinates);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GeoJsonLineStringData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGeoJsonLineStringData(document.RootElement);
        }
    }
}
