// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class PrivateEndpointDestination : IUtf8JsonSerializable, IJsonModel<PrivateEndpointDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateEndpointDestination>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateEndpointDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointDestination)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceResourceId))
            {
                writer.WritePropertyName("serviceResourceId"u8);
                writer.WriteStringValue(ServiceResourceId);
            }
            if (Optional.IsDefined(SparkEnabled))
            {
                writer.WritePropertyName("sparkEnabled"u8);
                writer.WriteBooleanValue(SparkEnabled.Value);
            }
            if (Optional.IsDefined(SparkStatus))
            {
                writer.WritePropertyName("sparkStatus"u8);
                writer.WriteStringValue(SparkStatus.Value.ToString());
            }
            if (Optional.IsDefined(SubresourceTarget))
            {
                writer.WritePropertyName("subresourceTarget"u8);
                writer.WriteStringValue(SubresourceTarget);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        PrivateEndpointDestination IJsonModel<PrivateEndpointDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointDestination)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateEndpointDestination(document.RootElement, options);
        }

        internal static PrivateEndpointDestination DeserializePrivateEndpointDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceResourceId = default;
            bool? sparkEnabled = default;
            OutboundRuleStatus? sparkStatus = default;
            string subresourceTarget = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceResourceId"u8))
                {
                    serviceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sparkEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sparkStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sparkStatus = new OutboundRuleStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subresourceTarget"u8))
                {
                    subresourceTarget = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateEndpointDestination(serviceResourceId, sparkEnabled, sparkStatus, subresourceTarget, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateEndpointDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointDestination)} does not support '{options.Format}' format.");
            }
        }

        PrivateEndpointDestination IPersistableModel<PrivateEndpointDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateEndpointDestination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointDestination)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateEndpointDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
