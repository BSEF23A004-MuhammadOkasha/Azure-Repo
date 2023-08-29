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

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreAccountEncryptionConfig : IUtf8JsonSerializable, IModelJsonSerializable<DataLakeStoreAccountEncryptionConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataLakeStoreAccountEncryptionConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataLakeStoreAccountEncryptionConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConfigType.ToSerialString());
            if (Optional.IsDefined(KeyVaultMetaInfo))
            {
                writer.WritePropertyName("keyVaultMetaInfo"u8);
                writer.WriteObjectValue(KeyVaultMetaInfo);
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

        internal static DataLakeStoreAccountEncryptionConfig DeserializeDataLakeStoreAccountEncryptionConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataLakeStoreAccountEncryptionConfigType type = default;
            Optional<DataLakeStoreAccountKeyVaultMetaInfo> keyVaultMetaInfo = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToDataLakeStoreAccountEncryptionConfigType();
                    continue;
                }
                if (property.NameEquals("keyVaultMetaInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultMetaInfo = DataLakeStoreAccountKeyVaultMetaInfo.DeserializeDataLakeStoreAccountKeyVaultMetaInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataLakeStoreAccountEncryptionConfig(type, keyVaultMetaInfo.Value, rawData);
        }

        DataLakeStoreAccountEncryptionConfig IModelJsonSerializable<DataLakeStoreAccountEncryptionConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreAccountEncryptionConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataLakeStoreAccountEncryptionConfig>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataLakeStoreAccountEncryptionConfig IModelSerializable<DataLakeStoreAccountEncryptionConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataLakeStoreAccountEncryptionConfig(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataLakeStoreAccountEncryptionConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataLakeStoreAccountEncryptionConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataLakeStoreAccountEncryptionConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
