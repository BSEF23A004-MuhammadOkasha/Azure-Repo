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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class TrunkedNetworkAttachmentConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<TrunkedNetworkAttachmentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TrunkedNetworkAttachmentConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TrunkedNetworkAttachmentConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrunkedNetworkAttachmentConfiguration>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("networkId"u8);
            writer.WriteStringValue(NetworkId);
            if (Optional.IsDefined(PluginType))
            {
                writer.WritePropertyName("pluginType"u8);
                writer.WriteStringValue(PluginType.Value.ToString());
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

        internal static TrunkedNetworkAttachmentConfiguration DeserializeTrunkedNetworkAttachmentConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier networkId = default;
            Optional<KubernetesPluginType> pluginType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkId"u8))
                {
                    networkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("pluginType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pluginType = new KubernetesPluginType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TrunkedNetworkAttachmentConfiguration(networkId, Optional.ToNullable(pluginType), rawData);
        }

        TrunkedNetworkAttachmentConfiguration IModelJsonSerializable<TrunkedNetworkAttachmentConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrunkedNetworkAttachmentConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTrunkedNetworkAttachmentConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TrunkedNetworkAttachmentConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrunkedNetworkAttachmentConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TrunkedNetworkAttachmentConfiguration IModelSerializable<TrunkedNetworkAttachmentConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrunkedNetworkAttachmentConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTrunkedNetworkAttachmentConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TrunkedNetworkAttachmentConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TrunkedNetworkAttachmentConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(TrunkedNetworkAttachmentConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TrunkedNetworkAttachmentConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TrunkedNetworkAttachmentConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTrunkedNetworkAttachmentConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
