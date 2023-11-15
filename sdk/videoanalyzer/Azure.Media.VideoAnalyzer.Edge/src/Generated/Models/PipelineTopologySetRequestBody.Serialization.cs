// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    internal partial class PipelineTopologySetRequestBody : IUtf8JsonSerializable, IJsonModel<PipelineTopologySetRequestBody>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineTopologySetRequestBody>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PipelineTopologySetRequestBody>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PipelineTopologySetRequestBody>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PipelineTopologySetRequestBody>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                writer.WriteObjectValue(SystemData);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("methodName"u8);
                writer.WriteStringValue(MethodName);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
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

        PipelineTopologySetRequestBody IJsonModel<PipelineTopologySetRequestBody>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PipelineTopologySetRequestBody)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineTopologySetRequestBody(document.RootElement, options);
        }

        internal static PipelineTopologySetRequestBody DeserializePipelineTopologySetRequestBody(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<SystemData> systemData = default;
            Optional<PipelineTopologyProperties> properties = default;
            string methodName = default;
            Optional<string> apiVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = PipelineTopologyProperties.DeserializePipelineTopologyProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PipelineTopologySetRequestBody(methodName, apiVersion.Value, serializedAdditionalRawData, name, systemData.Value, properties.Value);
        }

        BinaryData IPersistableModel<PipelineTopologySetRequestBody>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PipelineTopologySetRequestBody)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PipelineTopologySetRequestBody IPersistableModel<PipelineTopologySetRequestBody>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PipelineTopologySetRequestBody)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePipelineTopologySetRequestBody(document.RootElement, options);
        }

        string IPersistableModel<PipelineTopologySetRequestBody>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
