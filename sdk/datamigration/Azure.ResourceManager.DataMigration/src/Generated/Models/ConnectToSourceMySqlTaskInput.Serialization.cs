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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToSourceMySqlTaskInput : IUtf8JsonSerializable, IModelJsonSerializable<ConnectToSourceMySqlTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectToSourceMySqlTaskInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectToSourceMySqlTaskInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo"u8);
            writer.WriteObjectValue(SourceConnectionInfo);
            if (Optional.IsDefined(TargetPlatform))
            {
                writer.WritePropertyName("targetPlatform"u8);
                writer.WriteStringValue(TargetPlatform.Value.ToString());
            }
            if (Optional.IsDefined(CheckPermissionsGroup))
            {
                writer.WritePropertyName("checkPermissionsGroup"u8);
                writer.WriteStringValue(CheckPermissionsGroup.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsOfflineMigration))
            {
                writer.WritePropertyName("isOfflineMigration"u8);
                writer.WriteBooleanValue(IsOfflineMigration.Value);
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

        internal static ConnectToSourceMySqlTaskInput DeserializeConnectToSourceMySqlTaskInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MySqlConnectionInfo sourceConnectionInfo = default;
            Optional<MySqlTargetPlatformType> targetPlatform = default;
            Optional<ServerLevelPermissionsGroup> checkPermissionsGroup = default;
            Optional<bool> isOfflineMigration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetPlatform"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetPlatform = new MySqlTargetPlatformType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("checkPermissionsGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    checkPermissionsGroup = property.Value.GetString().ToServerLevelPermissionsGroup();
                    continue;
                }
                if (property.NameEquals("isOfflineMigration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOfflineMigration = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectToSourceMySqlTaskInput(sourceConnectionInfo, Optional.ToNullable(targetPlatform), Optional.ToNullable(checkPermissionsGroup), Optional.ToNullable(isOfflineMigration), rawData);
        }

        ConnectToSourceMySqlTaskInput IModelJsonSerializable<ConnectToSourceMySqlTaskInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceMySqlTaskInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectToSourceMySqlTaskInput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectToSourceMySqlTaskInput IModelSerializable<ConnectToSourceMySqlTaskInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectToSourceMySqlTaskInput(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ConnectToSourceMySqlTaskInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ConnectToSourceMySqlTaskInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectToSourceMySqlTaskInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
