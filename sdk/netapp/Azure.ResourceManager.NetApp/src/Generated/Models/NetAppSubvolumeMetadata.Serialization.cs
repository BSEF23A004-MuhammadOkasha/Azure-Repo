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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppSubvolumeMetadata : IUtf8JsonSerializable, IModelJsonSerializable<NetAppSubvolumeMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetAppSubvolumeMetadata>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetAppSubvolumeMetadata>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppSubvolumeMetadata>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(ParentPath))
            {
                writer.WritePropertyName("parentPath"u8);
                writer.WriteStringValue(ParentPath);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteNumberValue(Size.Value);
            }
            if (Optional.IsDefined(BytesUsed))
            {
                writer.WritePropertyName("bytesUsed"u8);
                writer.WriteNumberValue(BytesUsed.Value);
            }
            if (Optional.IsDefined(Permissions))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStringValue(Permissions);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTimeStamp"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(AccessedOn))
            {
                writer.WritePropertyName("accessedTimeStamp"u8);
                writer.WriteStringValue(AccessedOn.Value, "O");
            }
            if (Optional.IsDefined(ModifiedOn))
            {
                writer.WritePropertyName("modifiedTimeStamp"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(ChangedOn))
            {
                writer.WritePropertyName("changedTimeStamp"u8);
                writer.WriteStringValue(ChangedOn.Value, "O");
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WriteEndObject();
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

        internal static NetAppSubvolumeMetadata DeserializeNetAppSubvolumeMetadata(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> path = default;
            Optional<string> parentPath = default;
            Optional<long> size = default;
            Optional<long> bytesUsed = default;
            Optional<string> permissions = default;
            Optional<DateTimeOffset> creationTimeStamp = default;
            Optional<DateTimeOffset> accessedTimeStamp = default;
            Optional<DateTimeOffset> modifiedTimeStamp = default;
            Optional<DateTimeOffset> changedTimeStamp = default;
            Optional<string> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parentPath"u8))
                        {
                            parentPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            size = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesUsed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesUsed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("permissions"u8))
                        {
                            permissions = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessedTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modifiedTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changedTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetAppSubvolumeMetadata(id, name, type, systemData.Value, path.Value, parentPath.Value, Optional.ToNullable(size), Optional.ToNullable(bytesUsed), permissions.Value, Optional.ToNullable(creationTimeStamp), Optional.ToNullable(accessedTimeStamp), Optional.ToNullable(modifiedTimeStamp), Optional.ToNullable(changedTimeStamp), provisioningState.Value, rawData);
        }

        NetAppSubvolumeMetadata IModelJsonSerializable<NetAppSubvolumeMetadata>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppSubvolumeMetadata>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppSubvolumeMetadata(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetAppSubvolumeMetadata>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppSubvolumeMetadata>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetAppSubvolumeMetadata IModelSerializable<NetAppSubvolumeMetadata>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppSubvolumeMetadata>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetAppSubvolumeMetadata(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetAppSubvolumeMetadata"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetAppSubvolumeMetadata"/> to convert. </param>
        public static implicit operator RequestContent(NetAppSubvolumeMetadata model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetAppSubvolumeMetadata"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetAppSubvolumeMetadata(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetAppSubvolumeMetadata(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
