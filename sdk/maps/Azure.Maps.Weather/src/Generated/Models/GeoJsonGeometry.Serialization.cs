// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Weather
{
    public partial class GeoJsonGeometry
    {
        internal static GeoJsonGeometry DeserializeGeoJsonGeometry(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "GeometryCollection": return GeoJsonGeometryCollection.DeserializeGeoJsonGeometryCollection(element);
                    case "LineString": return GeoJsonLineString.DeserializeGeoJsonLineString(element);
                    case "MultiLineString": return GeoJsonMultiLineString.DeserializeGeoJsonMultiLineString(element);
                    case "MultiPoint": return GeoJsonMultiPoint.DeserializeGeoJsonMultiPoint(element);
                    case "MultiPolygon": return GeoJsonMultiPolygon.DeserializeGeoJsonMultiPolygon(element);
                    case "Point": return GeoJsonPoint.DeserializeGeoJsonPoint(element);
                    case "Polygon": return GeoJsonPolygon.DeserializeGeoJsonPolygon(element);
                }
            }
            GeoJsonObjectType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToGeoJsonObjectType();
                    continue;
                }
            }
            return new GeoJsonGeometry(type);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new GeoJsonGeometry FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGeoJsonGeometry(document.RootElement);
        }
    }
}
