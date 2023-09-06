// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeMountTarget : IUtf8JsonSerializable, IModelJsonSerializable<NetAppVolumeMountTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetAppVolumeMountTarget>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetAppVolumeMountTarget>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppVolumeMountTarget>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("fileSystemId"u8);
            writer.WriteStringValue(FileSystemId);
            if (Optional.IsDefined(SmbServerFqdn))
            {
                writer.WritePropertyName("smbServerFqdn"u8);
                writer.WriteStringValue(SmbServerFqdn);
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

        internal static NetAppVolumeMountTarget DeserializeNetAppVolumeMountTarget(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> mountTargetId = default;
            Guid fileSystemId = default;
            Optional<IPAddress> ipAddress = default;
            Optional<string> smbServerFqdn = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mountTargetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mountTargetId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("fileSystemId"u8))
                {
                    fileSystemId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("smbServerFqdn"u8))
                {
                    smbServerFqdn = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetAppVolumeMountTarget(Optional.ToNullable(mountTargetId), fileSystemId, ipAddress.Value, smbServerFqdn.Value, rawData);
        }

        NetAppVolumeMountTarget IModelJsonSerializable<NetAppVolumeMountTarget>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppVolumeMountTarget>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeMountTarget(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetAppVolumeMountTarget>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppVolumeMountTarget>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetAppVolumeMountTarget IModelSerializable<NetAppVolumeMountTarget>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetAppVolumeMountTarget>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetAppVolumeMountTarget(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetAppVolumeMountTarget"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetAppVolumeMountTarget"/> to convert. </param>
        public static implicit operator RequestContent(NetAppVolumeMountTarget model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetAppVolumeMountTarget"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetAppVolumeMountTarget(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetAppVolumeMountTarget(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
