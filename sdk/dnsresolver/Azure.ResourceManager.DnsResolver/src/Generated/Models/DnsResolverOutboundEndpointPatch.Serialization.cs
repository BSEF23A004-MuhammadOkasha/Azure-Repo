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

namespace Azure.ResourceManager.DnsResolver.Models
{
    public partial class DnsResolverOutboundEndpointPatch : IUtf8JsonSerializable, IModelJsonSerializable<DnsResolverOutboundEndpointPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DnsResolverOutboundEndpointPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DnsResolverOutboundEndpointPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DnsResolverOutboundEndpointPatch>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static DnsResolverOutboundEndpointPatch DeserializeDnsResolverOutboundEndpointPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DnsResolverOutboundEndpointPatch(Optional.ToDictionary(tags), rawData);
        }

        DnsResolverOutboundEndpointPatch IModelJsonSerializable<DnsResolverOutboundEndpointPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DnsResolverOutboundEndpointPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDnsResolverOutboundEndpointPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DnsResolverOutboundEndpointPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DnsResolverOutboundEndpointPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DnsResolverOutboundEndpointPatch IModelSerializable<DnsResolverOutboundEndpointPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DnsResolverOutboundEndpointPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDnsResolverOutboundEndpointPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DnsResolverOutboundEndpointPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DnsResolverOutboundEndpointPatch"/> to convert. </param>
        public static implicit operator RequestContent(DnsResolverOutboundEndpointPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DnsResolverOutboundEndpointPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DnsResolverOutboundEndpointPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDnsResolverOutboundEndpointPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
