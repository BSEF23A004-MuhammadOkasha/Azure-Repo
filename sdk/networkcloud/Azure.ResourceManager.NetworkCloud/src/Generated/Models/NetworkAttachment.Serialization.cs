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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkAttachment : IUtf8JsonSerializable, IJsonModel<NetworkAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkAttachment>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NetworkAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("attachedNetworkId"u8);
            writer.WriteStringValue(AttachedNetworkId);
            if (Optional.IsDefined(DefaultGateway))
            {
                writer.WritePropertyName("defaultGateway"u8);
                writer.WriteStringValue(DefaultGateway.Value.ToString());
            }
            writer.WritePropertyName("ipAllocationMethod"u8);
            writer.WriteStringValue(IPAllocationMethod.ToString());
            if (Optional.IsDefined(IPv4Address))
            {
                writer.WritePropertyName("ipv4Address"u8);
                writer.WriteStringValue(IPv4Address);
            }
            if (Optional.IsDefined(IPv6Address))
            {
                writer.WritePropertyName("ipv6Address"u8);
                writer.WriteStringValue(IPv6Address);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(MacAddress))
                {
                    writer.WritePropertyName("macAddress"u8);
                    writer.WriteStringValue(MacAddress);
                }
            }
            if (Optional.IsDefined(NetworkAttachmentName))
            {
                writer.WritePropertyName("networkAttachmentName"u8);
                writer.WriteStringValue(NetworkAttachmentName);
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

        NetworkAttachment IJsonModel<NetworkAttachment>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkAttachment)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkAttachment(document.RootElement, options);
        }

        internal static NetworkAttachment DeserializeNetworkAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string attachedNetworkId = default;
            Optional<DefaultGateway> defaultGateway = default;
            VirtualMachineIPAllocationMethod ipAllocationMethod = default;
            Optional<string> ipv4Address = default;
            Optional<string> ipv6Address = default;
            Optional<string> macAddress = default;
            Optional<string> networkAttachmentName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attachedNetworkId"u8))
                {
                    attachedNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultGateway"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultGateway = new DefaultGateway(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAllocationMethod"u8))
                {
                    ipAllocationMethod = new VirtualMachineIPAllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipv4Address"u8))
                {
                    ipv4Address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv6Address"u8))
                {
                    ipv6Address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkAttachmentName"u8))
                {
                    networkAttachmentName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkAttachment(attachedNetworkId, Optional.ToNullable(defaultGateway), ipAllocationMethod, ipv4Address.Value, ipv6Address.Value, macAddress.Value, networkAttachmentName.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<NetworkAttachment>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkAttachment)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkAttachment IModel<NetworkAttachment>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkAttachment)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkAttachment(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NetworkAttachment>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
