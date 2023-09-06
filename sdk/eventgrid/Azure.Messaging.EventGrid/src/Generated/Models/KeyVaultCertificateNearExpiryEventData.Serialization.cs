// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(KeyVaultCertificateNearExpiryEventDataConverter))]
    public partial class KeyVaultCertificateNearExpiryEventData : IUtf8JsonSerializable, IModelJsonSerializable<KeyVaultCertificateNearExpiryEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KeyVaultCertificateNearExpiryEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KeyVaultCertificateNearExpiryEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultCertificateNearExpiryEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("Id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(VaultName))
            {
                writer.WritePropertyName("VaultName"u8);
                writer.WriteStringValue(VaultName);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("ObjectType"u8);
                writer.WriteStringValue(ObjectType);
            }
            if (Optional.IsDefined(ObjectName))
            {
                writer.WritePropertyName("ObjectName"u8);
                writer.WriteStringValue(ObjectName);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("Version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(Nbf))
            {
                writer.WritePropertyName("NBF"u8);
                writer.WriteNumberValue(Nbf.Value);
            }
            if (Optional.IsDefined(Exp))
            {
                writer.WritePropertyName("EXP"u8);
                writer.WriteNumberValue(Exp.Value);
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

        internal static KeyVaultCertificateNearExpiryEventData DeserializeKeyVaultCertificateNearExpiryEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> vaultName = default;
            Optional<string> objectType = default;
            Optional<string> objectName = default;
            Optional<string> version = default;
            Optional<float> nbf = default;
            Optional<float> exp = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("VaultName"u8))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NBF"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nbf = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("EXP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exp = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KeyVaultCertificateNearExpiryEventData(id.Value, vaultName.Value, objectType.Value, objectName.Value, version.Value, Optional.ToNullable(nbf), Optional.ToNullable(exp), rawData);
        }

        KeyVaultCertificateNearExpiryEventData IModelJsonSerializable<KeyVaultCertificateNearExpiryEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultCertificateNearExpiryEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultCertificateNearExpiryEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KeyVaultCertificateNearExpiryEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultCertificateNearExpiryEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KeyVaultCertificateNearExpiryEventData IModelSerializable<KeyVaultCertificateNearExpiryEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultCertificateNearExpiryEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKeyVaultCertificateNearExpiryEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KeyVaultCertificateNearExpiryEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KeyVaultCertificateNearExpiryEventData"/> to convert. </param>
        public static implicit operator RequestContent(KeyVaultCertificateNearExpiryEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KeyVaultCertificateNearExpiryEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KeyVaultCertificateNearExpiryEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKeyVaultCertificateNearExpiryEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class KeyVaultCertificateNearExpiryEventDataConverter : JsonConverter<KeyVaultCertificateNearExpiryEventData>
        {
            public override void Write(Utf8JsonWriter writer, KeyVaultCertificateNearExpiryEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override KeyVaultCertificateNearExpiryEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeKeyVaultCertificateNearExpiryEventData(document.RootElement);
            }
        }
    }
}
