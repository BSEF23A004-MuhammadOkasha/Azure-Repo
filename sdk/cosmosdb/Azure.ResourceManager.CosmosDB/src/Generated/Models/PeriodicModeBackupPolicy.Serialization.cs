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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class PeriodicModeBackupPolicy : IUtf8JsonSerializable, IModelJsonSerializable<PeriodicModeBackupPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PeriodicModeBackupPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PeriodicModeBackupPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PeriodicModeBackupPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PeriodicModeProperties))
            {
                writer.WritePropertyName("periodicModeProperties"u8);
                writer.WriteObjectValue(PeriodicModeProperties);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(BackupPolicyType.ToString());
            if (Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteObjectValue(MigrationState);
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

        internal static PeriodicModeBackupPolicy DeserializePeriodicModeBackupPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PeriodicModeProperties> periodicModeProperties = default;
            BackupPolicyType type = default;
            Optional<BackupPolicyMigrationState> migrationState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("periodicModeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    periodicModeProperties = PeriodicModeProperties.DeserializePeriodicModeProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new BackupPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = BackupPolicyMigrationState.DeserializeBackupPolicyMigrationState(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PeriodicModeBackupPolicy(type, migrationState.Value, periodicModeProperties.Value, rawData);
        }

        PeriodicModeBackupPolicy IModelJsonSerializable<PeriodicModeBackupPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PeriodicModeBackupPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePeriodicModeBackupPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PeriodicModeBackupPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PeriodicModeBackupPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PeriodicModeBackupPolicy IModelSerializable<PeriodicModeBackupPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PeriodicModeBackupPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePeriodicModeBackupPolicy(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PeriodicModeBackupPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PeriodicModeBackupPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePeriodicModeBackupPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
