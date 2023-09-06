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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupDataSourceSettings : IUtf8JsonSerializable, IModelJsonSerializable<BackupDataSourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupDataSourceSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupDataSourceSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupDataSourceSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static BackupDataSourceSettings DeserializeBackupDataSourceSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "BlobBackupDatasourceParameters": return BlobBackupDataSourceSettings.DeserializeBlobBackupDataSourceSettings(element);
                    case "KubernetesClusterBackupDatasourceParameters": return KubernetesClusterBackupDataSourceSettings.DeserializeKubernetesClusterBackupDataSourceSettings(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownBackupDatasourceParameters(objectType, rawData);
        }

        BackupDataSourceSettings IModelJsonSerializable<BackupDataSourceSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupDataSourceSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupDataSourceSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupDataSourceSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupDataSourceSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupDataSourceSettings IModelSerializable<BackupDataSourceSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupDataSourceSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupDataSourceSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupDataSourceSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupDataSourceSettings"/> to convert. </param>
        public static implicit operator RequestContent(BackupDataSourceSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupDataSourceSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupDataSourceSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupDataSourceSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
