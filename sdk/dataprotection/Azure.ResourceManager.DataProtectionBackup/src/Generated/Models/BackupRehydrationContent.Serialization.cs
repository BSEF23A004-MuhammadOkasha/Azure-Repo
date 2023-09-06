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
    public partial class BackupRehydrationContent : IUtf8JsonSerializable, IModelJsonSerializable<BackupRehydrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupRehydrationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupRehydrationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupRehydrationContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointId"u8);
            writer.WriteStringValue(RecoveryPointId);
            if (Optional.IsDefined(RehydrationPriority))
            {
                writer.WritePropertyName("rehydrationPriority"u8);
                writer.WriteStringValue(RehydrationPriority.Value.ToString());
            }
            writer.WritePropertyName("rehydrationRetentionDuration"u8);
            writer.WriteStringValue(RehydrationRetentionDuration, "P");
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

        internal static BackupRehydrationContent DeserializeBackupRehydrationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recoveryPointId = default;
            Optional<BackupRehydrationPriority> rehydrationPriority = default;
            TimeSpan rehydrationRetentionDuration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rehydrationPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationPriority = new BackupRehydrationPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rehydrationRetentionDuration"u8))
                {
                    rehydrationRetentionDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BackupRehydrationContent(recoveryPointId, Optional.ToNullable(rehydrationPriority), rehydrationRetentionDuration, rawData);
        }

        BackupRehydrationContent IModelJsonSerializable<BackupRehydrationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupRehydrationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupRehydrationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupRehydrationContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupRehydrationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupRehydrationContent IModelSerializable<BackupRehydrationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupRehydrationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupRehydrationContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupRehydrationContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupRehydrationContent"/> to convert. </param>
        public static implicit operator RequestContent(BackupRehydrationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupRehydrationContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupRehydrationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupRehydrationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
