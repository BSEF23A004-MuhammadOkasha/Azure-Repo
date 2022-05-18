// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnSiteLinkData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkProperties))
            {
                writer.WritePropertyName("linkProperties");
                writer.WriteObjectValue(LinkProperties);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress");
                writer.WriteStringValue(IPAddress);
            }
            if (Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn");
                writer.WriteStringValue(Fqdn);
            }
            if (Optional.IsDefined(BgpProperties))
            {
                writer.WritePropertyName("bgpProperties");
                writer.WriteObjectValue(BgpProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnSiteLinkData DeserializeVpnSiteLinkData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<ResourceIdentifier> id = default;
            Optional<VpnLinkProviderProperties> linkProperties = default;
            Optional<string> ipAddress = default;
            Optional<string> fqdn = default;
            Optional<VpnLinkBgpSettings> bgpProperties = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("linkProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            linkProperties = VpnLinkProviderProperties.DeserializeVpnLinkProviderProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fqdn"))
                        {
                            fqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bgpProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bgpProperties = VpnLinkBgpSettings.DeserializeVpnLinkBgpSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnSiteLinkData(id.Value, etag.Value, name.Value, type.Value, linkProperties.Value, ipAddress.Value, fqdn.Value, bgpProperties.Value, Optional.ToNullable(provisioningState));
        }
    }
}
