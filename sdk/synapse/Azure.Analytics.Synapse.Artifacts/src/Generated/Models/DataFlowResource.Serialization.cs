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
    [JsonConverter(typeof(DataFlowResourceConverter))]
    public partial class DataFlowResource : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties);
            writer.WriteEndObject();
        }

        internal static DataFlowResource DeserializeDataFlowResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFlow properties = default;
            Core.Optional<string> etag = default;
            Core.Optional<string> id = default;
            Core.Optional<string> name = default;
            Core.Optional<string> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = DataFlow.DeserializeDataFlow(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new DataFlowResource(id.Value, name.Value, type.Value, etag.Value, properties);
        }

        internal partial class DataFlowResourceConverter : JsonConverter<DataFlowResource>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowResource(document.RootElement);
            }
        }
    }
}
