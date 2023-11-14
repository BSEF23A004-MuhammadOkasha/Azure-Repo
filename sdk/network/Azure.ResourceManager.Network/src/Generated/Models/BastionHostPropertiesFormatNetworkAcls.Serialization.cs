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

namespace Azure.ResourceManager.Network.Models
{
    internal partial class BastionHostPropertiesFormatNetworkAcls : IUtf8JsonSerializable, IJsonModel<BastionHostPropertiesFormatNetworkAcls>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BastionHostPropertiesFormatNetworkAcls>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BastionHostPropertiesFormatNetworkAcls>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BastionHostPropertiesFormatNetworkAcls>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BastionHostPropertiesFormatNetworkAcls>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item);
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

        BastionHostPropertiesFormatNetworkAcls IJsonModel<BastionHostPropertiesFormatNetworkAcls>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BastionHostPropertiesFormatNetworkAcls)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBastionHostPropertiesFormatNetworkAcls(document.RootElement, options);
        }

        internal static BastionHostPropertiesFormatNetworkAcls DeserializeBastionHostPropertiesFormatNetworkAcls(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<BastionHostIPRule>> ipRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BastionHostIPRule> array = new List<BastionHostIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BastionHostIPRule.DeserializeBastionHostIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BastionHostPropertiesFormatNetworkAcls(Optional.ToList(ipRules), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BastionHostPropertiesFormatNetworkAcls>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BastionHostPropertiesFormatNetworkAcls)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BastionHostPropertiesFormatNetworkAcls IPersistableModel<BastionHostPropertiesFormatNetworkAcls>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BastionHostPropertiesFormatNetworkAcls)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBastionHostPropertiesFormatNetworkAcls(document.RootElement, options);
        }

        string IPersistableModel<BastionHostPropertiesFormatNetworkAcls>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
