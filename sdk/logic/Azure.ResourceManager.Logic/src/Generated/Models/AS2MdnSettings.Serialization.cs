// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2MdnSettings : IUtf8JsonSerializable, IModelJsonSerializable<AS2MdnSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AS2MdnSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AS2MdnSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AS2MdnSettings>(this, options.Format);

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
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AS2MdnSettings DeserializeAS2MdnSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

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
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AS2MdnSettings(needMdn, signMdn, sendMdnAsynchronously, receiptDeliveryUrl.Value, dispositionNotificationTo.Value, signOutboundMdnIfOptional, mdnText.Value, sendInboundMdnToMessageBox, micHashingAlgorithm, serializedAdditionalRawData);
        }

        AS2MdnSettings IModelJsonSerializable<AS2MdnSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AS2MdnSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2MdnSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AS2MdnSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AS2MdnSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AS2MdnSettings IModelSerializable<AS2MdnSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AS2MdnSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAS2MdnSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AS2MdnSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AS2MdnSettings"/> to convert. </param>
        public static implicit operator RequestContent(AS2MdnSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AS2MdnSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AS2MdnSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAS2MdnSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
