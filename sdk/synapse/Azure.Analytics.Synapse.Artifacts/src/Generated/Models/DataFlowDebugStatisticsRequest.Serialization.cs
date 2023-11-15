// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DataFlowDebugStatisticsRequestConverter))]
    public partial class DataFlowDebugStatisticsRequest : IUtf8JsonSerializable, IJsonModel<DataFlowDebugStatisticsRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFlowDebugStatisticsRequest>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<DataFlowDebugStatisticsRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DataFlowDebugStatisticsRequest>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DataFlowDebugStatisticsRequest>)} interface");
            }

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
            if (Optional.IsCollectionDefined(Columns))
            {
                writer.WritePropertyName("columns"u8);
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DataFlowDebugStatisticsRequest IJsonModel<DataFlowDebugStatisticsRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFlowDebugStatisticsRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFlowDebugStatisticsRequest(document.RootElement, options);
        }

        internal static DataFlowDebugStatisticsRequest DeserializeDataFlowDebugStatisticsRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sessionId = default;
            Optional<string> dataFlowName = default;
            Optional<string> streamName = default;
            Optional<IList<string>> columns = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    columns = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataFlowDebugStatisticsRequest(sessionId.Value, dataFlowName.Value, streamName.Value, Optional.ToList(columns), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFlowDebugStatisticsRequest>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFlowDebugStatisticsRequest)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataFlowDebugStatisticsRequest IPersistableModel<DataFlowDebugStatisticsRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFlowDebugStatisticsRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataFlowDebugStatisticsRequest(document.RootElement, options);
        }

        string IPersistableModel<DataFlowDebugStatisticsRequest>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class DataFlowDebugStatisticsRequestConverter : JsonConverter<DataFlowDebugStatisticsRequest>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugStatisticsRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowDebugStatisticsRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugStatisticsRequest(document.RootElement);
            }
        }
    }
}
