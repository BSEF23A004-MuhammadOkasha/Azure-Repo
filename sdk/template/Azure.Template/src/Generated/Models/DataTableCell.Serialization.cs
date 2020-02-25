// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Template.Models
{
    public partial class DataTableCell : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rowIndex");
            writer.WriteNumberValue(RowIndex);
            writer.WritePropertyName("columnIndex");
            writer.WriteNumberValue(ColumnIndex);
            if (RowSpan != null)
            {
                writer.WritePropertyName("rowSpan");
                writer.WriteNumberValue(RowSpan.Value);
            }
            if (ColumnSpan != null)
            {
                writer.WritePropertyName("columnSpan");
                writer.WriteNumberValue(ColumnSpan.Value);
            }
            writer.WritePropertyName("text");
            writer.WriteStringValue(Text);
            writer.WritePropertyName("boundingBox");
            writer.WriteStartArray();
            foreach (var item in BoundingBox)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("confidence");
            writer.WriteNumberValue(Confidence);
            if (Elements != null)
            {
                writer.WritePropertyName("elements");
                writer.WriteStartArray();
                foreach (var item0 in Elements)
                {
                    writer.WriteStringValue(item0);
                }
                writer.WriteEndArray();
            }
            if (IsHeader != null)
            {
                writer.WritePropertyName("isHeader");
                writer.WriteBooleanValue(IsHeader.Value);
            }
            if (IsFooter != null)
            {
                writer.WritePropertyName("isFooter");
                writer.WriteBooleanValue(IsFooter.Value);
            }
            writer.WriteEndObject();
        }
        internal static DataTableCell DeserializeDataTableCell(JsonElement element)
        {
            DataTableCell result = new DataTableCell();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rowIndex"))
                {
                    result.RowIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnIndex"))
                {
                    result.ColumnIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rowSpan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RowSpan = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnSpan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ColumnSpan = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    result.Text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingBox"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.BoundingBox.Add(item.GetSingle());
                    }
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    result.Confidence = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("elements"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Elements = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Elements.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("isHeader"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IsHeader = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isFooter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IsFooter = property.Value.GetBoolean();
                    continue;
                }
            }
            return result;
        }
    }
}
