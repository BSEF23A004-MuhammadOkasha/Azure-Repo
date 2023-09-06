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
    public partial class BgpServiceLoadBalancerConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<BgpServiceLoadBalancerConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BgpServiceLoadBalancerConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BgpServiceLoadBalancerConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BgpServiceLoadBalancerConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BgpAdvertisements))
            {
                writer.WritePropertyName("bgpAdvertisements"u8);
                writer.WriteStartArray();
                foreach (var item in BgpAdvertisements)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BgpAdvertisement>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BgpPeers))
            {
                writer.WritePropertyName("bgpPeers"u8);
                writer.WriteStartArray();
                foreach (var item in BgpPeers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ServiceLoadBalancerBgpPeer>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FabricPeeringEnabled))
            {
                writer.WritePropertyName("fabricPeeringEnabled"u8);
                writer.WriteStringValue(FabricPeeringEnabled.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPAddressPools))
            {
                writer.WritePropertyName("ipAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in IPAddressPools)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<IPAddressPool>)item).Serialize(writer, options);
                    }
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

        internal static BgpServiceLoadBalancerConfiguration DeserializeBgpServiceLoadBalancerConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<BgpAdvertisement>> bgpAdvertisements = default;
            Optional<IList<ServiceLoadBalancerBgpPeer>> bgpPeers = default;
            Optional<FabricPeeringEnabled> fabricPeeringEnabled = default;
            Optional<IList<IPAddressPool>> ipAddressPools = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bgpAdvertisements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BgpAdvertisement> array = new List<BgpAdvertisement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BgpAdvertisement.DeserializeBgpAdvertisement(item));
                    }
                    bgpAdvertisements = array;
                    continue;
                }
                if (property.NameEquals("bgpPeers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceLoadBalancerBgpPeer> array = new List<ServiceLoadBalancerBgpPeer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceLoadBalancerBgpPeer.DeserializeServiceLoadBalancerBgpPeer(item));
                    }
                    bgpPeers = array;
                    continue;
                }
                if (property.NameEquals("fabricPeeringEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricPeeringEnabled = new FabricPeeringEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddressPools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddressPool> array = new List<IPAddressPool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressPool.DeserializeIPAddressPool(item));
                    }
                    ipAddressPools = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BgpServiceLoadBalancerConfiguration(Optional.ToList(bgpAdvertisements), Optional.ToList(bgpPeers), Optional.ToNullable(fabricPeeringEnabled), Optional.ToList(ipAddressPools), rawData);
        }

        BgpServiceLoadBalancerConfiguration IModelJsonSerializable<BgpServiceLoadBalancerConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BgpServiceLoadBalancerConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBgpServiceLoadBalancerConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BgpServiceLoadBalancerConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BgpServiceLoadBalancerConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BgpServiceLoadBalancerConfiguration IModelSerializable<BgpServiceLoadBalancerConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BgpServiceLoadBalancerConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBgpServiceLoadBalancerConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BgpServiceLoadBalancerConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BgpServiceLoadBalancerConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(BgpServiceLoadBalancerConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BgpServiceLoadBalancerConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BgpServiceLoadBalancerConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBgpServiceLoadBalancerConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
