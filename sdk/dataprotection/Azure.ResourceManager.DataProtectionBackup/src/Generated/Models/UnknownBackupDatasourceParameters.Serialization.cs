// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class UnknownBackupDatasourceParameters : IUtf8JsonSerializable, IModelJsonSerializable<BackupDataSourceSettings>
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

        internal static BackupDataSourceSettings DeserializeUnknownBackupDatasourceParameters(JsonElement element, ModelSerializerOptions options = default) => DeserializeBackupDataSourceSettings(element, options);

        BackupDataSourceSettings IModelJsonSerializable<BackupDataSourceSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupDataSourceSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownBackupDatasourceParameters(doc.RootElement, options);
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
    }
}
