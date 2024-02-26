// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class GridLayout : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rows"u8);
            writer.WriteNumberValue(Rows);
            writer.WritePropertyName("columns"u8);
            writer.WriteNumberValue(Columns);
            writer.WritePropertyName("inputIds"u8);
            writer.WriteStartArray();
            foreach (var item in InputIds)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStartArray();
                foreach (var item0 in item)
                {
                    writer.WriteStringValue(item0);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Resolution != null)
            {
                writer.WritePropertyName("resolution"u8);
                writer.WriteObjectValue(Resolution);
            }
            if (PlaceholderImageUri != null)
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
            }
            if (ScalingMode.HasValue)
            {
                writer.WritePropertyName("scalingMode"u8);
                writer.WriteStringValue(ScalingMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static GridLayout DeserializeGridLayout(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int rows = default;
            int columns = default;
            IList<IList<string>> inputIds = default;
            LayoutType kind = default;
            Optional<LayoutResolution> resolution = default;
            Optional<string> placeholderImageUri = default;
            Optional<ScalingMode> scalingMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rows"u8))
                {
                    rows = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columns"u8))
                {
                    columns = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inputIds"u8))
                {
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<string> array0 = new List<string>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetString());
                            }
                            array.Add(array0);
                        }
                    }
                    inputIds = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new LayoutType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"u8))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scalingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scalingMode = new ScalingMode(property.Value.GetString());
                    continue;
                }
            }
            return new GridLayout(kind, resolution.Value, placeholderImageUri.Value, Optional.ToNullable(scalingMode), rows, columns, inputIds);
        }
    }
}
