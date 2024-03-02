// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppQueueScaleRule : IUtf8JsonSerializable, IJsonModel<ContainerAppQueueScaleRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppQueueScaleRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppQueueScaleRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppQueueScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppQueueScaleRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (QueueName != null)
            {
                writer.WritePropertyName("queueName"u8);
                writer.WriteStringValue(QueueName);
            }
            if (QueueLength.HasValue)
            {
                writer.WritePropertyName("queueLength"u8);
                writer.WriteNumberValue(QueueLength.Value);
            }
            if (!(Auth is ChangeTrackingList<ContainerAppScaleRuleAuth> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("auth"u8);
                writer.WriteStartArray();
                foreach (var item in Auth)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ContainerAppQueueScaleRule IJsonModel<ContainerAppQueueScaleRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppQueueScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppQueueScaleRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppQueueScaleRule(document.RootElement, options);
        }

        internal static ContainerAppQueueScaleRule DeserializeContainerAppQueueScaleRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queueName = default;
            int? queueLength = default;
            IList<ContainerAppScaleRuleAuth> auth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueName"u8))
                {
                    queueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queueLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("auth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppScaleRuleAuth> array = new List<ContainerAppScaleRuleAuth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppScaleRuleAuth.DeserializeContainerAppScaleRuleAuth(item, options));
                    }
                    auth = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppQueueScaleRule(queueName, queueLength, auth ?? new ChangeTrackingList<ContainerAppScaleRuleAuth>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppQueueScaleRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppQueueScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppQueueScaleRule)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppQueueScaleRule IPersistableModel<ContainerAppQueueScaleRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppQueueScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppQueueScaleRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppQueueScaleRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppQueueScaleRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
