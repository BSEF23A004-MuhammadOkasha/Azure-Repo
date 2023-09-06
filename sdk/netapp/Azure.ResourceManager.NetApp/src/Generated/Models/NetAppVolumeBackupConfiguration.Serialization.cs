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
    public partial class NetAppVolumeBackupConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<NetAppVolumeBackupConfiguration>
    {
        void IModelJsonSerializable<NetAppVolumeBackupConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppVolumeBackupConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BackupPolicyId))
            {
                writer.WritePropertyName("backupPolicyId"u8);
                writer.WriteStringValue(BackupPolicyId);
            }
            if (Optional.IsDefined(IsPolicyEnforced))
            {
                writer.WritePropertyName("policyEnforced"u8);
                writer.WriteBooleanValue(IsPolicyEnforced.Value);
            }
            if (Optional.IsDefined(IsBackupEnabled))
            {
                writer.WritePropertyName("backupEnabled"u8);
                writer.WriteBooleanValue(IsBackupEnabled.Value);
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

        internal static NetAppVolumeBackupConfiguration DeserializeNetAppVolumeBackupConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> backupPolicyId = default;
            Optional<bool> policyEnforced = default;
            Optional<bool> backupEnabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupPolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupPolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyEnforced"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyEnforced = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetAppVolumeBackupConfiguration(backupPolicyId.Value, Optional.ToNullable(policyEnforced), Optional.ToNullable(backupEnabled), rawData);
        }

        NetAppVolumeBackupConfiguration IModelJsonSerializable<NetAppVolumeBackupConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppVolumeBackupConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeBackupConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetAppVolumeBackupConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppVolumeBackupConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetAppVolumeBackupConfiguration IModelSerializable<NetAppVolumeBackupConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppVolumeBackupConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetAppVolumeBackupConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetAppVolumeBackupConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetAppVolumeBackupConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(NetAppVolumeBackupConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetAppVolumeBackupConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetAppVolumeBackupConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetAppVolumeBackupConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
