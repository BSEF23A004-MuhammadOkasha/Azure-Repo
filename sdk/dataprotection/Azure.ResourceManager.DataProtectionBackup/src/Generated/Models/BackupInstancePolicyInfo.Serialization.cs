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
    public partial class BackupInstancePolicyInfo : IUtf8JsonSerializable, IModelJsonSerializable<BackupInstancePolicyInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupInstancePolicyInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupInstancePolicyInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupInstancePolicyInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("policyId"u8);
            writer.WriteStringValue(PolicyId);
            if (Optional.IsDefined(PolicyParameters))
            {
                writer.WritePropertyName("policyParameters"u8);
                if (PolicyParameters is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BackupInstancePolicySettings>)PolicyParameters).Serialize(writer, options);
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

        internal static BackupInstancePolicyInfo DeserializeBackupInstancePolicyInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier policyId = default;
            Optional<string> policyVersion = default;
            Optional<BackupInstancePolicySettings> policyParameters = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyId"u8))
                {
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyVersion"u8))
                {
                    policyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyParameters = BackupInstancePolicySettings.DeserializeBackupInstancePolicySettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BackupInstancePolicyInfo(policyId, policyVersion.Value, policyParameters.Value, rawData);
        }

        BackupInstancePolicyInfo IModelJsonSerializable<BackupInstancePolicyInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupInstancePolicyInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupInstancePolicyInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupInstancePolicyInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupInstancePolicyInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupInstancePolicyInfo IModelSerializable<BackupInstancePolicyInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BackupInstancePolicyInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupInstancePolicyInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupInstancePolicyInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupInstancePolicyInfo"/> to convert. </param>
        public static implicit operator RequestContent(BackupInstancePolicyInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupInstancePolicyInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupInstancePolicyInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupInstancePolicyInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
