// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseLinkedIntegrationRuntime : IUtf8JsonSerializable, IJsonModel<SynapseLinkedIntegrationRuntime>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseLinkedIntegrationRuntime>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseLinkedIntegrationRuntime>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLinkedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseLinkedIntegrationRuntime)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && SubscriptionId != null)
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (options.Format != "W" && DataFactoryName != null)
            {
                writer.WritePropertyName("dataFactoryName"u8);
                writer.WriteStringValue(DataFactoryName);
            }
            if (options.Format != "W" && DataFactoryLocation != null)
            {
                writer.WritePropertyName("dataFactoryLocation"u8);
                writer.WriteStringValue(DataFactoryLocation);
            }
            if (options.Format != "W" && CreateOn.HasValue)
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteStringValue(CreateOn.Value, "O");
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

        SynapseLinkedIntegrationRuntime IJsonModel<SynapseLinkedIntegrationRuntime>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLinkedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseLinkedIntegrationRuntime)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseLinkedIntegrationRuntime(document.RootElement, options);
        }

        internal static SynapseLinkedIntegrationRuntime DeserializeSynapseLinkedIntegrationRuntime(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> subscriptionId = default;
            Optional<string> dataFactoryName = default;
            Optional<string> dataFactoryLocation = default;
            Optional<DateTimeOffset> createTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFactoryLocation"u8))
                {
                    dataFactoryLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseLinkedIntegrationRuntime(name.Value, subscriptionId.Value, dataFactoryName.Value, dataFactoryLocation.Value, Optional.ToNullable(createTime), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseLinkedIntegrationRuntime>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLinkedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseLinkedIntegrationRuntime)} does not support '{options.Format}' format.");
            }
        }

        SynapseLinkedIntegrationRuntime IPersistableModel<SynapseLinkedIntegrationRuntime>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLinkedIntegrationRuntime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseLinkedIntegrationRuntime(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseLinkedIntegrationRuntime)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseLinkedIntegrationRuntime>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
