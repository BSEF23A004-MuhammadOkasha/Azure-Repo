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
    internal partial class SynapseKustoPoolPrivateLinkList : IUtf8JsonSerializable, IJsonModel<SynapseKustoPoolPrivateLinkList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseKustoPoolPrivateLinkList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseKustoPoolPrivateLinkList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseKustoPoolPrivateLinkList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseKustoPoolPrivateLinkList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<SynapseKustoPoolPrivateLinkData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        SynapseKustoPoolPrivateLinkList IJsonModel<SynapseKustoPoolPrivateLinkList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseKustoPoolPrivateLinkList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseKustoPoolPrivateLinkList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseKustoPoolPrivateLinkList(document.RootElement, options);
        }

        internal static SynapseKustoPoolPrivateLinkList DeserializeSynapseKustoPoolPrivateLinkList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SynapseKustoPoolPrivateLinkData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseKustoPoolPrivateLinkData> array = new List<SynapseKustoPoolPrivateLinkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseKustoPoolPrivateLinkData.DeserializeSynapseKustoPoolPrivateLinkData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseKustoPoolPrivateLinkList(value ?? new ChangeTrackingList<SynapseKustoPoolPrivateLinkData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseKustoPoolPrivateLinkList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseKustoPoolPrivateLinkList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseKustoPoolPrivateLinkList)} does not support '{options.Format}' format.");
            }
        }

        SynapseKustoPoolPrivateLinkList IPersistableModel<SynapseKustoPoolPrivateLinkList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseKustoPoolPrivateLinkList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseKustoPoolPrivateLinkList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseKustoPoolPrivateLinkList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseKustoPoolPrivateLinkList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
