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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceNetworkProfileKubeProxyConfig : IUtf8JsonSerializable, IModelJsonSerializable<ContainerServiceNetworkProfileKubeProxyConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerServiceNetworkProfileKubeProxyConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerServiceNetworkProfileKubeProxyConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(IPVSConfig))
            {
                writer.WritePropertyName("ipvsConfig"u8);
                writer.WriteObjectValue(IPVSConfig);
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

        internal static ContainerServiceNetworkProfileKubeProxyConfig DeserializeContainerServiceNetworkProfileKubeProxyConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<ContainerServiceNetworkProfileKubeProxyMode> mode = default;
            Optional<ContainerServiceNetworkProfileKubeProxyIPVSConfig> ipvsConfig = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new ContainerServiceNetworkProfileKubeProxyMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipvsConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipvsConfig = ContainerServiceNetworkProfileKubeProxyIPVSConfig.DeserializeContainerServiceNetworkProfileKubeProxyIPVSConfig(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerServiceNetworkProfileKubeProxyConfig(Optional.ToNullable(enabled), Optional.ToNullable(mode), ipvsConfig.Value, rawData);
        }

        ContainerServiceNetworkProfileKubeProxyConfig IModelJsonSerializable<ContainerServiceNetworkProfileKubeProxyConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceNetworkProfileKubeProxyConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerServiceNetworkProfileKubeProxyConfig>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerServiceNetworkProfileKubeProxyConfig IModelSerializable<ContainerServiceNetworkProfileKubeProxyConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerServiceNetworkProfileKubeProxyConfig(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContainerServiceNetworkProfileKubeProxyConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContainerServiceNetworkProfileKubeProxyConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerServiceNetworkProfileKubeProxyConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
