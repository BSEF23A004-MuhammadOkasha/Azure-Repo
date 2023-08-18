// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DiagnosticDataset : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table"u8);
                writer.WriteObjectValue(Table);
            }
            if (Core.Optional.IsDefined(RenderingProperties))
            {
                writer.WritePropertyName("renderingProperties"u8);
                writer.WriteObjectValue(RenderingProperties);
            }
            writer.WriteEndObject();
        }

        internal static DiagnosticDataset DeserializeDiagnosticDataset(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DataTableResponseObject> table = default;
            Core.Optional<DiagnosticDataRendering> renderingProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("table"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    table = DataTableResponseObject.DeserializeDataTableResponseObject(property.Value);
                    continue;
                }
                if (property.NameEquals("renderingProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renderingProperties = DiagnosticDataRendering.DeserializeDiagnosticDataRendering(property.Value);
                    continue;
                }
            }
            return new DiagnosticDataset(table.Value, renderingProperties.Value);
        }
    }
}
