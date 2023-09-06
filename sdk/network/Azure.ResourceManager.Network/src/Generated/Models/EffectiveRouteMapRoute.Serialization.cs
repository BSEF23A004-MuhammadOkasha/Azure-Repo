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

namespace Azure.ResourceManager.Network.Models
{
    public partial class EffectiveRouteMapRoute : IUtf8JsonSerializable, IModelJsonSerializable<EffectiveRouteMapRoute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EffectiveRouteMapRoute>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EffectiveRouteMapRoute>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EffectiveRouteMapRoute>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix"u8);
                writer.WriteStringValue(Prefix);
            }
            if (Optional.IsDefined(BgpCommunities))
            {
                writer.WritePropertyName("bgpCommunities"u8);
                writer.WriteStringValue(BgpCommunities);
            }
            if (Optional.IsDefined(AsPath))
            {
                writer.WritePropertyName("asPath"u8);
                writer.WriteStringValue(AsPath);
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

        internal static EffectiveRouteMapRoute DeserializeEffectiveRouteMapRoute(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> prefix = default;
            Optional<string> bgpCommunities = default;
            Optional<string> asPath = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefix"u8))
                {
                    prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bgpCommunities"u8))
                {
                    bgpCommunities = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asPath"u8))
                {
                    asPath = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EffectiveRouteMapRoute(prefix.Value, bgpCommunities.Value, asPath.Value, rawData);
        }

        EffectiveRouteMapRoute IModelJsonSerializable<EffectiveRouteMapRoute>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EffectiveRouteMapRoute>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEffectiveRouteMapRoute(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EffectiveRouteMapRoute>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EffectiveRouteMapRoute>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EffectiveRouteMapRoute IModelSerializable<EffectiveRouteMapRoute>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EffectiveRouteMapRoute>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEffectiveRouteMapRoute(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EffectiveRouteMapRoute"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EffectiveRouteMapRoute"/> to convert. </param>
        public static implicit operator RequestContent(EffectiveRouteMapRoute model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EffectiveRouteMapRoute"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EffectiveRouteMapRoute(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEffectiveRouteMapRoute(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
