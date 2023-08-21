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
    [JsonConverter(typeof(DataFlowDebugPreviewDataRequestConverter))]
    public partial class DataFlowDebugPreviewDataRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(DataFlowName))
            {
                writer.WritePropertyName("dataFlowName"u8);
                writer.WriteStringValue(DataFlowName);
            }
            if (Optional.IsDefined(StreamName))
            {
                writer.WritePropertyName("streamName"u8);
                writer.WriteStringValue(StreamName);
            }
            if (Optional.IsDefined(RowLimits))
            {
                writer.WritePropertyName("rowLimits"u8);
                writer.WriteNumberValue(RowLimits.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowDebugPreviewDataRequest DeserializeDataFlowDebugPreviewDataRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sessionId = default;
            Optional<string> dataFlowName = default;
            Optional<string> streamName = default;
            Optional<int> rowLimits = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlowName"u8))
                {
                    dataFlowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamName"u8))
                {
                    streamName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rowLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowLimits = property.Value.GetInt32();
                    continue;
                }
            }
            return new DataFlowDebugPreviewDataRequest(sessionId.Value, dataFlowName.Value, streamName.Value, Optional.ToNullable(rowLimits));
        }

        internal partial class DataFlowDebugPreviewDataRequestConverter : JsonConverter<DataFlowDebugPreviewDataRequest>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugPreviewDataRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowDebugPreviewDataRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugPreviewDataRequest(document.RootElement);
            }
        }
    }
}
