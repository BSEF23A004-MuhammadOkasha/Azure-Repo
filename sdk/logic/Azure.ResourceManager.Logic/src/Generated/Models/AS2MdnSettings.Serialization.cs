// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2MdnSettings : IUtf8JsonSerializable, IJsonModel<AS2MdnSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2MdnSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AS2MdnSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2MdnSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2MdnSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("needMDN"u8);
            writer.WriteBooleanValue(NeedMdn);
            writer.WritePropertyName("signMDN"u8);
            writer.WriteBooleanValue(SignMdn);
            writer.WritePropertyName("sendMDNAsynchronously"u8);
            writer.WriteBooleanValue(SendMdnAsynchronously);
            if (ReceiptDeliveryUri != null)
            {
                writer.WritePropertyName("receiptDeliveryUrl"u8);
                writer.WriteStringValue(ReceiptDeliveryUri.AbsoluteUri);
            }
            if (DispositionNotificationTo != null)
            {
                writer.WritePropertyName("dispositionNotificationTo"u8);
                writer.WriteStringValue(DispositionNotificationTo);
            }
            writer.WritePropertyName("signOutboundMDNIfOptional"u8);
            writer.WriteBooleanValue(SignOutboundMdnIfOptional);
            if (MdnText != null)
            {
                writer.WritePropertyName("mdnText"u8);
                writer.WriteStringValue(MdnText);
            }
            writer.WritePropertyName("sendInboundMDNToMessageBox"u8);
            writer.WriteBooleanValue(SendInboundMdnToMessageBox);
            writer.WritePropertyName("micHashingAlgorithm"u8);
            writer.WriteStringValue(MicHashingAlgorithm.ToString());
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

        AS2MdnSettings IJsonModel<AS2MdnSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2MdnSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2MdnSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2MdnSettings(document.RootElement, options);
        }

        internal static AS2MdnSettings DeserializeAS2MdnSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AS2MdnSettings(needMdn, signMdn, sendMdnAsynchronously, receiptDeliveryUrl.Value, dispositionNotificationTo.Value, signOutboundMdnIfOptional, mdnText.Value, sendInboundMdnToMessageBox, micHashingAlgorithm, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AS2MdnSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2MdnSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AS2MdnSettings)} does not support '{options.Format}' format.");
            }
        }

        AS2MdnSettings IPersistableModel<AS2MdnSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2MdnSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAS2MdnSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AS2MdnSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AS2MdnSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
