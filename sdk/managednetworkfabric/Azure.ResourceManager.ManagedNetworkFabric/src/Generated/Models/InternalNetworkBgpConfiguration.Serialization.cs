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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class InternalNetworkBgpConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<InternalNetworkBgpConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InternalNetworkBgpConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InternalNetworkBgpConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InternalNetworkBgpConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BfdConfiguration))
            {
                writer.WritePropertyName("bfdConfiguration"u8);
                if (BfdConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BfdConfiguration>)BfdConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DefaultRouteOriginate))
            {
                writer.WritePropertyName("defaultRouteOriginate"u8);
                writer.WriteStringValue(DefaultRouteOriginate.Value.ToString());
            }
            if (Optional.IsDefined(AllowAS))
            {
                writer.WritePropertyName("allowAS"u8);
                writer.WriteNumberValue(AllowAS.Value);
            }
            if (Optional.IsDefined(AllowASOverride))
            {
                writer.WritePropertyName("allowASOverride"u8);
                writer.WriteStringValue(AllowASOverride.Value.ToString());
            }
            if (Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerASN"u8);
                writer.WriteNumberValue(PeerAsn.Value);
            }
            if (Optional.IsCollectionDefined(IPv4ListenRangePrefixes))
            {
                writer.WritePropertyName("ipv4ListenRangePrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4ListenRangePrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6ListenRangePrefixes))
            {
                writer.WritePropertyName("ipv6ListenRangePrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6ListenRangePrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv4NeighborAddress))
            {
                writer.WritePropertyName("ipv4NeighborAddress"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4NeighborAddress)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NeighborAddress>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPv6NeighborAddress))
            {
                writer.WritePropertyName("ipv6NeighborAddress"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6NeighborAddress)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NeighborAddress>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static InternalNetworkBgpConfiguration DeserializeInternalNetworkBgpConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BfdConfiguration> bfdConfiguration = default;
            Optional<NetworkFabricBooleanValue> defaultRouteOriginate = default;
            Optional<int> allowAS = default;
            Optional<AllowASOverride> allowASOverride = default;
            Optional<long> fabricAsn = default;
            Optional<long> peerAsn = default;
            Optional<IList<string>> ipv4ListenRangePrefixes = default;
            Optional<IList<string>> ipv6ListenRangePrefixes = default;
            Optional<IList<NeighborAddress>> ipv4NeighborAddress = default;
            Optional<IList<NeighborAddress>> ipv6NeighborAddress = default;
            Optional<string> annotation = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bfdConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdConfiguration = BfdConfiguration.DeserializeBfdConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("defaultRouteOriginate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultRouteOriginate = new NetworkFabricBooleanValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowAS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowAS = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowASOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowASOverride = new AllowASOverride(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("peerASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("ipv4ListenRangePrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv4ListenRangePrefixes = array;
                    continue;
                }
                if (property.NameEquals("ipv6ListenRangePrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipv6ListenRangePrefixes = array;
                    continue;
                }
                if (property.NameEquals("ipv4NeighborAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NeighborAddress> array = new List<NeighborAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NeighborAddress.DeserializeNeighborAddress(item));
                    }
                    ipv4NeighborAddress = array;
                    continue;
                }
                if (property.NameEquals("ipv6NeighborAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NeighborAddress> array = new List<NeighborAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NeighborAddress.DeserializeNeighborAddress(item));
                    }
                    ipv6NeighborAddress = array;
                    continue;
                }
                if (property.NameEquals("annotation"u8))
                {
                    annotation = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InternalNetworkBgpConfiguration(annotation.Value, bfdConfiguration.Value, Optional.ToNullable(defaultRouteOriginate), Optional.ToNullable(allowAS), Optional.ToNullable(allowASOverride), Optional.ToNullable(fabricAsn), Optional.ToNullable(peerAsn), Optional.ToList(ipv4ListenRangePrefixes), Optional.ToList(ipv6ListenRangePrefixes), Optional.ToList(ipv4NeighborAddress), Optional.ToList(ipv6NeighborAddress), serializedAdditionalRawData);
        }

        InternalNetworkBgpConfiguration IModelJsonSerializable<InternalNetworkBgpConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InternalNetworkBgpConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalNetworkBgpConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InternalNetworkBgpConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InternalNetworkBgpConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InternalNetworkBgpConfiguration IModelSerializable<InternalNetworkBgpConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InternalNetworkBgpConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInternalNetworkBgpConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InternalNetworkBgpConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InternalNetworkBgpConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(InternalNetworkBgpConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InternalNetworkBgpConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InternalNetworkBgpConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInternalNetworkBgpConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
