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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkInterfaceProperties : IUtf8JsonSerializable, IJsonModel<MobileNetworkInterfaceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkInterfaceProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MobileNetworkInterfaceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IPv4Address))
            {
                writer.WritePropertyName("ipv4Address"u8);
                writer.WriteStringValue(IPv4Address);
            }
            if (Optional.IsDefined(IPv4Subnet))
            {
                writer.WritePropertyName("ipv4Subnet"u8);
                writer.WriteStringValue(IPv4Subnet);
            }
            if (Optional.IsDefined(IPv4Gateway))
            {
                writer.WritePropertyName("ipv4Gateway"u8);
                writer.WriteStringValue(IPv4Gateway);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        MobileNetworkInterfaceProperties IJsonModel<MobileNetworkInterfaceProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkInterfaceProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkInterfaceProperties(document.RootElement, options);
        }

        internal static MobileNetworkInterfaceProperties DeserializeMobileNetworkInterfaceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> ipv4Address = default;
            Optional<string> ipv4Subnet = default;
            Optional<string> ipv4Gateway = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Address"u8))
                {
                    ipv4Address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Subnet"u8))
                {
                    ipv4Subnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Gateway"u8))
                {
                    ipv4Gateway = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkInterfaceProperties(name.Value, ipv4Address.Value, ipv4Subnet.Value, ipv4Gateway.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<MobileNetworkInterfaceProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkInterfaceProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MobileNetworkInterfaceProperties IModel<MobileNetworkInterfaceProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MobileNetworkInterfaceProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMobileNetworkInterfaceProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MobileNetworkInterfaceProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
