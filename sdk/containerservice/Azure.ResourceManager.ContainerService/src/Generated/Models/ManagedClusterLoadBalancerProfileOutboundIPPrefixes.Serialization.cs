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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterLoadBalancerProfileOutboundIPPrefixes : IUtf8JsonSerializable, IModelJsonSerializable<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PublicIPPrefixes))
            {
                writer.WritePropertyName("publicIPPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in PublicIPPrefixes)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
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

        internal static ManagedClusterLoadBalancerProfileOutboundIPPrefixes DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<WritableSubResource>> publicIPPrefixes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    publicIPPrefixes = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedClusterLoadBalancerProfileOutboundIPPrefixes(Optional.ToList(publicIPPrefixes), rawData);
        }

        ManagedClusterLoadBalancerProfileOutboundIPPrefixes IModelJsonSerializable<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedClusterLoadBalancerProfileOutboundIPPrefixes IModelSerializable<ManagedClusterLoadBalancerProfileOutboundIPPrefixes>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ManagedClusterLoadBalancerProfileOutboundIPPrefixes model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ManagedClusterLoadBalancerProfileOutboundIPPrefixes(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedClusterLoadBalancerProfileOutboundIPPrefixes(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
