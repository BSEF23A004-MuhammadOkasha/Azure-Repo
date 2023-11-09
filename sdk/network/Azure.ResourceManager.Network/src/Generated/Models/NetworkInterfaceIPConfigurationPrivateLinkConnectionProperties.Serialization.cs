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
    public partial class NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties : IUtf8JsonSerializable, IJsonModel<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(GroupId))
                {
                    writer.WritePropertyName("groupId"u8);
                    writer.WriteStringValue(GroupId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(RequiredMemberName))
                {
                    writer.WritePropertyName("requiredMemberName"u8);
                    writer.WriteStringValue(RequiredMemberName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Fqdns))
                {
                    writer.WritePropertyName("fqdns"u8);
                    writer.WriteStartArray();
                    foreach (var item in Fqdns)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties IJsonModel<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(document.RootElement, options);
        }

        internal static NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties DeserializeNetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> groupId = default;
            Optional<string> requiredMemberName = default;
            Optional<IReadOnlyList<string>> fqdns = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredMemberName"u8))
                {
                    requiredMemberName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdns"u8))
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
                    fqdns = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(groupId.Value, requiredMemberName.Value, Optional.ToList(fqdns), serializedAdditionalRawData);
        }

        BinaryData IModel<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties IModel<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
