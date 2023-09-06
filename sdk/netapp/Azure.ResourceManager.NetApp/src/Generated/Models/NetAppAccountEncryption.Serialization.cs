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

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppAccountEncryption : IUtf8JsonSerializable, IModelJsonSerializable<NetAppAccountEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetAppAccountEncryption>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetAppAccountEncryption>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppAccountEncryption>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(KeySource))
            {
                writer.WritePropertyName("keySource"u8);
                writer.WriteStringValue(KeySource.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                if (KeyVaultProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NetAppKeyVaultProperties>)KeyVaultProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                if (Identity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NetAppEncryptionIdentity>)Identity).Serialize(writer, options);
                }
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

        internal static NetAppAccountEncryption DeserializeNetAppAccountEncryption(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetAppKeySource> keySource = default;
            Optional<NetAppKeyVaultProperties> keyVaultProperties = default;
            Optional<NetAppEncryptionIdentity> identity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keySource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keySource = new NetAppKeySource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultProperties = NetAppKeyVaultProperties.DeserializeNetAppKeyVaultProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = NetAppEncryptionIdentity.DeserializeNetAppEncryptionIdentity(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetAppAccountEncryption(Optional.ToNullable(keySource), keyVaultProperties.Value, identity.Value, rawData);
        }

        NetAppAccountEncryption IModelJsonSerializable<NetAppAccountEncryption>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppAccountEncryption>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppAccountEncryption(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetAppAccountEncryption>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppAccountEncryption>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetAppAccountEncryption IModelSerializable<NetAppAccountEncryption>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppAccountEncryption>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetAppAccountEncryption(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetAppAccountEncryption"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetAppAccountEncryption"/> to convert. </param>
        public static implicit operator RequestContent(NetAppAccountEncryption model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetAppAccountEncryption"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetAppAccountEncryption(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetAppAccountEncryption(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
