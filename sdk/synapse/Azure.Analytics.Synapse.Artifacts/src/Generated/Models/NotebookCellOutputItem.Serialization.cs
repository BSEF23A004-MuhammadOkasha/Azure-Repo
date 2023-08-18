// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(NotebookCellOutputItemConverter))]
    public partial class NotebookCellOutputItem : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsDefined(ExecutionCount))
            {
                writer.WritePropertyName("execution_count"u8);
                writer.WriteNumberValue(ExecutionCount.Value);
            }
            writer.WritePropertyName("output_type"u8);
            writer.WriteStringValue(OutputType.ToString());
            if (Core.Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text"u8);
                writer.WriteObjectValue(Text);
            }
            if (Core.Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteObjectValue(Data);
            }
            if (Core.Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata);
            }
            writer.WriteEndObject();
        }

        internal static NotebookCellOutputItem DeserializeNotebookCellOutputItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<int> executionCount = default;
            CellOutputType outputType = default;
            Core.Optional<object> text = default;
            Core.Optional<object> data = default;
            Core.Optional<object> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("execution_count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("output_type"u8))
                {
                    outputType = new CellOutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    text = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    data = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = property.Value.GetObject();
                    continue;
                }
            }
            return new NotebookCellOutputItem(name.Value, Core.Optional.ToNullable(executionCount), outputType, text.Value, data.Value, metadata.Value);
        }

        internal partial class NotebookCellOutputItemConverter : JsonConverter<NotebookCellOutputItem>
        {
            public override void Write(Utf8JsonWriter writer, NotebookCellOutputItem model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override NotebookCellOutputItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeNotebookCellOutputItem(document.RootElement);
            }
        }
    }
}
