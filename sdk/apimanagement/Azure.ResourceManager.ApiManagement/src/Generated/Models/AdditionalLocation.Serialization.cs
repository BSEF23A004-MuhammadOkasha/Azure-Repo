// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AdditionalLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("sku");
            writer.WriteObjectValue(Sku);
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicIPAddressId))
            {
                writer.WritePropertyName("publicIpAddressId");
                writer.WriteStringValue(PublicIPAddressId);
            }
            if (Optional.IsDefined(VirtualNetworkConfiguration))
            {
                writer.WritePropertyName("virtualNetworkConfiguration");
                writer.WriteObjectValue(VirtualNetworkConfiguration);
            }
            if (Optional.IsDefined(DisableGateway))
            {
                writer.WritePropertyName("disableGateway");
                writer.WriteBooleanValue(DisableGateway.Value);
            }
            writer.WriteEndObject();
        }

        internal static AdditionalLocation DeserializeAdditionalLocation(JsonElement element)
        {
            AzureLocation location = default;
            ApiManagementServiceSkuProperties sku = default;
            Optional<IList<string>> zones = default;
            Optional<IReadOnlyList<IPAddress>> publicIPAddresses = default;
            Optional<IReadOnlyList<IPAddress>> privateIPAddresses = default;
            Optional<string> publicIPAddressId = default;
            Optional<VirtualNetworkConfiguration> virtualNetworkConfiguration = default;
            Optional<Uri> gatewayRegionalUri = default;
            Optional<bool> disableGateway = default;
            Optional<PlatformVersion> platformVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    sku = ApiManagementServiceSkuProperties.DeserializeApiManagementServiceSkuProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("publicIPAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddress.Parse(item.GetString()));
                    }
                    publicIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("privateIPAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddress.Parse(item.GetString()));
                    }
                    privateIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("publicIpAddressId"))
                {
                    publicIPAddressId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualNetworkConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    virtualNetworkConfiguration = VirtualNetworkConfiguration.DeserializeVirtualNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("gatewayRegionalUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gatewayRegionalUri = null;
                        continue;
                    }
                    gatewayRegionalUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disableGateway"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableGateway = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("platformVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    platformVersion = new PlatformVersion(property.Value.GetString());
                    continue;
                }
            }
            return new AdditionalLocation(location, sku, Optional.ToList(zones), Optional.ToList(publicIPAddresses), Optional.ToList(privateIPAddresses), publicIPAddressId.Value, virtualNetworkConfiguration.Value, gatewayRegionalUri.Value, Optional.ToNullable(disableGateway), Optional.ToNullable(platformVersion));
        }
    }
}
