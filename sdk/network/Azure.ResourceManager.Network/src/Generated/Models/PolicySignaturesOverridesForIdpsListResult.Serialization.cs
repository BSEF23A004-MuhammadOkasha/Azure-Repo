// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class PolicySignaturesOverridesForIdpsListResult : IUtf8JsonSerializable, IJsonModel<PolicySignaturesOverridesForIdpsListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicySignaturesOverridesForIdpsListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicySignaturesOverridesForIdpsListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySignaturesOverridesForIdpsListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySignaturesOverridesForIdpsListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
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

        PolicySignaturesOverridesForIdpsListResult IJsonModel<PolicySignaturesOverridesForIdpsListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySignaturesOverridesForIdpsListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySignaturesOverridesForIdpsListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicySignaturesOverridesForIdpsListResult(document.RootElement, options);
        }

        internal static PolicySignaturesOverridesForIdpsListResult DeserializePolicySignaturesOverridesForIdpsListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PolicySignaturesOverridesForIdpsData>> value = default;
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
                    List<PolicySignaturesOverridesForIdpsData> array = new List<PolicySignaturesOverridesForIdpsData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicySignaturesOverridesForIdpsData.DeserializePolicySignaturesOverridesForIdpsData(item));
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
            return new PolicySignaturesOverridesForIdpsListResult(Optional.ToList(value), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicySignaturesOverridesForIdpsListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySignaturesOverridesForIdpsListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicySignaturesOverridesForIdpsListResult)} does not support '{options.Format}' format.");
            }
        }

        PolicySignaturesOverridesForIdpsListResult IPersistableModel<PolicySignaturesOverridesForIdpsListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySignaturesOverridesForIdpsListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicySignaturesOverridesForIdpsListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicySignaturesOverridesForIdpsListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicySignaturesOverridesForIdpsListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
