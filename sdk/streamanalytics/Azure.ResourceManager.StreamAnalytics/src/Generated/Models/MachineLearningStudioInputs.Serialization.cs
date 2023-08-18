// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class MachineLearningStudioInputs : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsCollectionDefined(ColumnNames))
            {
                writer.WritePropertyName("columnNames"u8);
                writer.WriteStartArray();
                foreach (var item in ColumnNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static MachineLearningStudioInputs DeserializeMachineLearningStudioInputs(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<IList<MachineLearningStudioInputColumn>> columnNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("columnNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningStudioInputColumn> array = new List<MachineLearningStudioInputColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningStudioInputColumn.DeserializeMachineLearningStudioInputColumn(item));
                    }
                    columnNames = array;
                    continue;
                }
            }
            return new MachineLearningStudioInputs(name.Value, Core.Optional.ToList(columnNames));
        }
    }
}
