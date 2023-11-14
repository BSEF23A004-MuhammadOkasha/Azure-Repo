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
    public partial class VpnGatewayPacketCaptureStartContent : IUtf8JsonSerializable, IJsonModel<VpnGatewayPacketCaptureStartContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnGatewayPacketCaptureStartContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<VpnGatewayPacketCaptureStartContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<VpnGatewayPacketCaptureStartContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<VpnGatewayPacketCaptureStartContent>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FilterData))
            {
                writer.WritePropertyName("filterData"u8);
                writer.WriteStringValue(FilterData);
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

        VpnGatewayPacketCaptureStartContent IJsonModel<VpnGatewayPacketCaptureStartContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStartContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnGatewayPacketCaptureStartContent(document.RootElement, options);
        }

        internal static VpnGatewayPacketCaptureStartContent DeserializeVpnGatewayPacketCaptureStartContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> filterData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterData"u8))
                {
                    filterData = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnGatewayPacketCaptureStartContent(filterData.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnGatewayPacketCaptureStartContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStartContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        VpnGatewayPacketCaptureStartContent IPersistableModel<VpnGatewayPacketCaptureStartContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStartContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeVpnGatewayPacketCaptureStartContent(document.RootElement, options);
        }

        string IPersistableModel<VpnGatewayPacketCaptureStartContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
