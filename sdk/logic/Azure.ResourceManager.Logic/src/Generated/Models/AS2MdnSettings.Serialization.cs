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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2MdnSettings : IUtf8JsonSerializable, IJsonModel<AS2MdnSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2MdnSettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AS2MdnSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AS2MdnSettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AS2MdnSettings>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("needMDN"u8);
            writer.WriteBooleanValue(NeedMdn);
            writer.WritePropertyName("signMDN"u8);
            writer.WriteBooleanValue(SignMdn);
            writer.WritePropertyName("sendMDNAsynchronously"u8);
            writer.WriteBooleanValue(SendMdnAsynchronously);
            if (Optional.IsDefined(ReceiptDeliveryUri))
            {
                writer.WritePropertyName("receiptDeliveryUrl"u8);
                writer.WriteStringValue(ReceiptDeliveryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DispositionNotificationTo))
            {
                writer.WritePropertyName("dispositionNotificationTo"u8);
                writer.WriteStringValue(DispositionNotificationTo);
            }
            writer.WritePropertyName("signOutboundMDNIfOptional"u8);
            writer.WriteBooleanValue(SignOutboundMdnIfOptional);
            if (Optional.IsDefined(MdnText))
            {
                writer.WritePropertyName("mdnText"u8);
                writer.WriteStringValue(MdnText);
            }
            writer.WritePropertyName("sendInboundMDNToMessageBox"u8);
            writer.WriteBooleanValue(SendInboundMdnToMessageBox);
            writer.WritePropertyName("micHashingAlgorithm"u8);
            writer.WriteStringValue(MicHashingAlgorithm.ToString());
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

        AS2MdnSettings IJsonModel<AS2MdnSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2MdnSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2MdnSettings(document.RootElement, options);
        }

        internal static AS2MdnSettings DeserializeAS2MdnSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool needMdn = default;
            bool signMdn = default;
            bool sendMdnAsynchronously = default;
            Optional<Uri> receiptDeliveryUrl = default;
            Optional<string> dispositionNotificationTo = default;
            bool signOutboundMdnIfOptional = default;
            Optional<string> mdnText = default;
            bool sendInboundMdnToMessageBox = default;
            AS2HashingAlgorithm micHashingAlgorithm = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("needMDN"u8))
                {
                    needMdn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("signMDN"u8))
                {
                    signMdn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendMDNAsynchronously"u8))
                {
                    sendMdnAsynchronously = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("receiptDeliveryUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    receiptDeliveryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dispositionNotificationTo"u8))
                {
                    dispositionNotificationTo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("signOutboundMDNIfOptional"u8))
                {
                    signOutboundMdnIfOptional = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mdnText"u8))
                {
                    mdnText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendInboundMDNToMessageBox"u8))
                {
                    sendInboundMdnToMessageBox = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("micHashingAlgorithm"u8))
                {
                    micHashingAlgorithm = new AS2HashingAlgorithm(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AS2MdnSettings(needMdn, signMdn, sendMdnAsynchronously, receiptDeliveryUrl.Value, dispositionNotificationTo.Value, signOutboundMdnIfOptional, mdnText.Value, sendInboundMdnToMessageBox, micHashingAlgorithm, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AS2MdnSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2MdnSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AS2MdnSettings IPersistableModel<AS2MdnSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AS2MdnSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAS2MdnSettings(document.RootElement, options);
        }

        string IPersistableModel<AS2MdnSettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
