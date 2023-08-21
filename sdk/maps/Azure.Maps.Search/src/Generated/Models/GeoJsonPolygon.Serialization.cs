// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    internal partial class GeoJsonPolygon : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("coordinates"u8);
            writer.WriteStartArray();
            foreach (var item in Coordinates)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStartArray();
                foreach (var item0 in item)
                {
                    if (item0 == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item1 in item0)
                    {
                        writer.WriteNumberValue(item1);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToSerialString());
            writer.WriteEndObject();
        }

        internal static GeoJsonPolygon DeserializeGeoJsonPolygon(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IList<IList<double>>> coordinates = default;
            GeoJsonObjectType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"u8))
                {
                    List<IList<IList<double>>> array = new List<IList<IList<double>>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<IList<double>> array0 = new List<IList<double>>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                if (item0.ValueKind == JsonValueKind.Null)
                                {
                                    array0.Add(null);
                                }
                                else
                                {
                                    List<double> array1 = new List<double>();
                                    foreach (var item1 in item0.EnumerateArray())
                                    {
                                        array1.Add(item1.GetDouble());
                                    }
                                    array0.Add(array1);
                                }
                            }
                            array.Add(array0);
                        }
                    }
                    coordinates = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToGeoJsonObjectType();
                    continue;
                }
            }
            return new GeoJsonPolygon(type, coordinates);
        }
    }
}
