// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Maps.Search.Models
{
    public partial class GeoJsonGeometryCollectionData
    {
        internal static GeoJsonGeometryCollectionData DeserializeGeoJsonGeometryCollectionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<GeoJsonGeometry> geometries = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("geometries"u8))
                {
                    List<GeoJsonGeometry> array = new List<GeoJsonGeometry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeoJsonGeometry.DeserializeGeoJsonGeometry(item));
                    }
                    geometries = array;
                    continue;
                }
            }
            return new GeoJsonGeometryCollectionData(geometries);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GeoJsonGeometryCollectionData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGeoJsonGeometryCollectionData(document.RootElement);
        }
    }
}
