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
    public partial class L3NetworkAttachmentConfiguration : IUtf8JsonSerializable, IJsonModel<L3NetworkAttachmentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<L3NetworkAttachmentConfiguration>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<L3NetworkAttachmentConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IpamEnabled))
            {
                writer.WritePropertyName("ipamEnabled"u8);
                writer.WriteStringValue(IpamEnabled.Value.ToString());
            }
            writer.WritePropertyName("networkId"u8);
            writer.WriteStringValue(NetworkId);
            if (Optional.IsDefined(PluginType))
            {
                writer.WritePropertyName("pluginType"u8);
                writer.WriteStringValue(PluginType.Value.ToString());
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

        L3NetworkAttachmentConfiguration IJsonModel<L3NetworkAttachmentConfiguration>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(L3NetworkAttachmentConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeL3NetworkAttachmentConfiguration(document.RootElement, options);
        }

        internal static L3NetworkAttachmentConfiguration DeserializeL3NetworkAttachmentConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<L3NetworkConfigurationIpamEnabled> ipamEnabled = default;
            ResourceIdentifier networkId = default;
            Optional<KubernetesPluginType> pluginType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipamEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipamEnabled = new L3NetworkConfigurationIpamEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkId"u8))
                {
                    networkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("pluginType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pluginType = new KubernetesPluginType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new L3NetworkAttachmentConfiguration(Optional.ToNullable(ipamEnabled), networkId, Optional.ToNullable(pluginType), serializedAdditionalRawData);
        }

        BinaryData IModel<L3NetworkAttachmentConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(L3NetworkAttachmentConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        L3NetworkAttachmentConfiguration IModel<L3NetworkAttachmentConfiguration>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(L3NetworkAttachmentConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeL3NetworkAttachmentConfiguration(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<L3NetworkAttachmentConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
