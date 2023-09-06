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
    public partial class DataProtectionBackupSettings : IUtf8JsonSerializable, IModelJsonSerializable<DataProtectionBackupSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataProtectionBackupSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataProtectionBackupSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBackupSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("backupType"u8);
            writer.WriteStringValue(BackupType);
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

        internal static DataProtectionBackupSettings DeserializeDataProtectionBackupSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string backupType = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupType"u8))
                {
                    backupType = property.Value.GetString();
                    continue;
                }
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
            return new DataProtectionBackupSettings(objectType, backupType, rawData);
        }

        DataProtectionBackupSettings IModelJsonSerializable<DataProtectionBackupSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBackupSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataProtectionBackupSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBackupSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataProtectionBackupSettings IModelSerializable<DataProtectionBackupSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBackupSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataProtectionBackupSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataProtectionBackupSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataProtectionBackupSettings"/> to convert. </param>
        public static implicit operator RequestContent(DataProtectionBackupSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataProtectionBackupSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataProtectionBackupSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataProtectionBackupSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
