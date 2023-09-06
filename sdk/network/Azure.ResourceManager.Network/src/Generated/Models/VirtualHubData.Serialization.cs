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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualHubData : IUtf8JsonSerializable, IModelJsonSerializable<VirtualHubData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualHubData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualHubData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualHubData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualWan))
            {
                writer.WritePropertyName("virtualWan"u8);
                JsonSerializer.Serialize(writer, VirtualWan);
            }
            if (Optional.IsDefined(VpnGateway))
            {
                writer.WritePropertyName("vpnGateway"u8);
                JsonSerializer.Serialize(writer, VpnGateway);
            }
            if (Optional.IsDefined(P2SVpnGateway))
            {
                writer.WritePropertyName("p2SVpnGateway"u8);
                JsonSerializer.Serialize(writer, P2SVpnGateway);
            }
            if (Optional.IsDefined(ExpressRouteGateway))
            {
                writer.WritePropertyName("expressRouteGateway"u8);
                JsonSerializer.Serialize(writer, ExpressRouteGateway);
            }
            if (Optional.IsDefined(AzureFirewall))
            {
                writer.WritePropertyName("azureFirewall"u8);
                JsonSerializer.Serialize(writer, AzureFirewall);
            }
            if (Optional.IsDefined(SecurityPartnerProvider))
            {
                writer.WritePropertyName("securityPartnerProvider"u8);
                JsonSerializer.Serialize(writer, SecurityPartnerProvider);
            }
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsDefined(RouteTable))
            {
                writer.WritePropertyName("routeTable"u8);
                if (RouteTable is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VirtualHubRouteTable>)RouteTable).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SecurityProviderName))
            {
                writer.WritePropertyName("securityProviderName"u8);
                writer.WriteStringValue(SecurityProviderName);
            }
            if (Optional.IsCollectionDefined(VirtualHubRouteTableV2S))
            {
                writer.WritePropertyName("virtualHubRouteTableV2s"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualHubRouteTableV2S)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VirtualHubRouteTableV2Data>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsDefined(VirtualRouterAsn))
            {
                writer.WritePropertyName("virtualRouterAsn"u8);
                writer.WriteNumberValue(VirtualRouterAsn.Value);
            }
            if (Optional.IsCollectionDefined(VirtualRouterIPs))
            {
                writer.WritePropertyName("virtualRouterIps"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualRouterIPs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowBranchToBranchTraffic))
            {
                writer.WritePropertyName("allowBranchToBranchTraffic"u8);
                writer.WriteBooleanValue(AllowBranchToBranchTraffic.Value);
            }
            if (Optional.IsDefined(PreferredRoutingGateway))
            {
                writer.WritePropertyName("preferredRoutingGateway"u8);
                writer.WriteStringValue(PreferredRoutingGateway.Value.ToString());
            }
            if (Optional.IsDefined(HubRoutingPreference))
            {
                writer.WritePropertyName("hubRoutingPreference"u8);
                writer.WriteStringValue(HubRoutingPreference.Value.ToString());
            }
            if (Optional.IsDefined(VirtualRouterAutoScaleConfiguration))
            {
                writer.WritePropertyName("virtualRouterAutoScaleConfiguration"u8);
                if (VirtualRouterAutoScaleConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VirtualRouterAutoScaleConfiguration>)VirtualRouterAutoScaleConfiguration).Serialize(writer, options);
                }
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

        internal static VirtualHubData DeserializeVirtualHubData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<string> kind = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<WritableSubResource> virtualWan = default;
            Optional<WritableSubResource> vpnGateway = default;
            Optional<WritableSubResource> p2sVpnGateway = default;
            Optional<WritableSubResource> expressRouteGateway = default;
            Optional<WritableSubResource> azureFirewall = default;
            Optional<WritableSubResource> securityPartnerProvider = default;
            Optional<string> addressPrefix = default;
            Optional<VirtualHubRouteTable> routeTable = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<string> securityProviderName = default;
            Optional<IList<VirtualHubRouteTableV2Data>> virtualHubRouteTableV2s = default;
            Optional<string> sku = default;
            Optional<RoutingState> routingState = default;
            Optional<IReadOnlyList<WritableSubResource>> bgpConnections = default;
            Optional<IReadOnlyList<WritableSubResource>> ipConfigurations = default;
            Optional<IReadOnlyList<WritableSubResource>> routeMaps = default;
            Optional<long> virtualRouterAsn = default;
            Optional<IList<string>> virtualRouterIPs = default;
            Optional<bool> allowBranchToBranchTraffic = default;
            Optional<PreferredRoutingGateway> preferredRoutingGateway = default;
            Optional<HubRoutingPreference> hubRoutingPreference = default;
            Optional<VirtualRouterAutoScaleConfiguration> virtualRouterAutoScaleConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualWan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualWan = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("vpnGateway"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnGateway = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("p2SVpnGateway"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            p2sVpnGateway = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("expressRouteGateway"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteGateway = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("azureFirewall"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureFirewall = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("securityPartnerProvider"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityPartnerProvider = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"u8))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routeTable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routeTable = VirtualHubRouteTable.DeserializeVirtualHubRouteTable(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("securityProviderName"u8))
                        {
                            securityProviderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualHubRouteTableV2s"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualHubRouteTableV2Data> array = new List<VirtualHubRouteTableV2Data>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualHubRouteTableV2Data.DeserializeVirtualHubRouteTableV2Data(item));
                            }
                            virtualHubRouteTableV2s = array;
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routingState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingState = new RoutingState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("bgpConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            bgpConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("routeMaps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            routeMaps = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualRouterAsn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualRouterAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("virtualRouterIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            virtualRouterIPs = array;
                            continue;
                        }
                        if (property0.NameEquals("allowBranchToBranchTraffic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowBranchToBranchTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("preferredRoutingGateway"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredRoutingGateway = new PreferredRoutingGateway(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hubRoutingPreference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hubRoutingPreference = new HubRoutingPreference(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualRouterAutoScaleConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualRouterAutoScaleConfiguration = VirtualRouterAutoScaleConfiguration.DeserializeVirtualRouterAutoScaleConfiguration(property0.Value);
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
            return new VirtualHubData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), Optional.ToNullable(etag), kind.Value, virtualWan, vpnGateway, p2sVpnGateway, expressRouteGateway, azureFirewall, securityPartnerProvider, addressPrefix.Value, routeTable.Value, Optional.ToNullable(provisioningState), securityProviderName.Value, Optional.ToList(virtualHubRouteTableV2s), sku.Value, Optional.ToNullable(routingState), Optional.ToList(bgpConnections), Optional.ToList(ipConfigurations), Optional.ToList(routeMaps), Optional.ToNullable(virtualRouterAsn), Optional.ToList(virtualRouterIPs), Optional.ToNullable(allowBranchToBranchTraffic), Optional.ToNullable(preferredRoutingGateway), Optional.ToNullable(hubRoutingPreference), virtualRouterAutoScaleConfiguration.Value, rawData);
        }

        VirtualHubData IModelJsonSerializable<VirtualHubData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualHubData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualHubData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualHubData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualHubData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualHubData IModelSerializable<VirtualHubData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VirtualHubData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualHubData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualHubData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualHubData"/> to convert. </param>
        public static implicit operator RequestContent(VirtualHubData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualHubData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualHubData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualHubData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
