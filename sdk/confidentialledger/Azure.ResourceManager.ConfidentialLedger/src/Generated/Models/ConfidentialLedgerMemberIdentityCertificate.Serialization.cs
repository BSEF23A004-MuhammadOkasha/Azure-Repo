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

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class ConfidentialLedgerMemberIdentityCertificate : IUtf8JsonSerializable, IModelJsonSerializable<ConfidentialLedgerMemberIdentityCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConfidentialLedgerMemberIdentityCertificate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConfidentialLedgerMemberIdentityCertificate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteStringValue(Certificate);
            }
            if (Optional.IsDefined(Encryptionkey))
            {
                writer.WritePropertyName("encryptionkey"u8);
                writer.WriteStringValue(Encryptionkey);
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Tags);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Tags.ToString()).RootElement);
#endif
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static ConfidentialLedgerMemberIdentityCertificate DeserializeConfidentialLedgerMemberIdentityCertificate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> certificate = default;
            Optional<string> encryptionkey = default;
            Optional<BinaryData> tags = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificate"u8))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionkey"u8))
                {
                    encryptionkey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tags = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConfidentialLedgerMemberIdentityCertificate(certificate.Value, encryptionkey.Value, tags.Value, rawData);
        }

        ConfidentialLedgerMemberIdentityCertificate IModelJsonSerializable<ConfidentialLedgerMemberIdentityCertificate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConfidentialLedgerMemberIdentityCertificate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConfidentialLedgerMemberIdentityCertificate>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConfidentialLedgerMemberIdentityCertificate IModelSerializable<ConfidentialLedgerMemberIdentityCertificate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConfidentialLedgerMemberIdentityCertificate(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ConfidentialLedgerMemberIdentityCertificate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ConfidentialLedgerMemberIdentityCertificate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConfidentialLedgerMemberIdentityCertificate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
