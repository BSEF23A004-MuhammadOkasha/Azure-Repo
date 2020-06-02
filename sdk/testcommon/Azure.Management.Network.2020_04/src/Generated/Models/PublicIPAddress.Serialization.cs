// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PublicIPAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Zones != null)
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (PublicIPAllocationMethod != null)
            {
                writer.WritePropertyName("publicIPAllocationMethod");
                writer.WriteStringValue(PublicIPAllocationMethod.Value.ToString());
            }
            if (PublicIPAddressVersion != null)
            {
                writer.WritePropertyName("publicIPAddressVersion");
                writer.WriteStringValue(PublicIPAddressVersion.Value.ToString());
            }
            if (IpConfiguration != null)
            {
                writer.WritePropertyName("ipConfiguration");
                writer.WriteObjectValue(IpConfiguration);
            }
            if (DnsSettings != null)
            {
                writer.WritePropertyName("dnsSettings");
                writer.WriteObjectValue(DnsSettings);
            }
            if (DdosSettings != null)
            {
                writer.WritePropertyName("ddosSettings");
                writer.WriteObjectValue(DdosSettings);
            }
            if (IpTags != null)
            {
                writer.WritePropertyName("ipTags");
                writer.WriteStartArray();
                foreach (var item in IpTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IpAddress != null)
            {
                writer.WritePropertyName("ipAddress");
                writer.WriteStringValue(IpAddress);
            }
            if (PublicIPPrefix != null)
            {
                writer.WritePropertyName("publicIPPrefix");
                writer.WriteObjectValue(PublicIPPrefix);
            }
            if (IdleTimeoutInMinutes != null)
            {
                writer.WritePropertyName("idleTimeoutInMinutes");
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (ResourceGuid != null)
            {
                writer.WritePropertyName("resourceGuid");
                writer.WriteStringValue(ResourceGuid);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PublicIPAddress DeserializePublicIPAddress(JsonElement element)
        {
            PublicIPAddressSku sku = default;
            string etag = default;
            IList<string> zones = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            IPAllocationMethod? publicIPAllocationMethod = default;
            IPVersion? publicIPAddressVersion = default;
            IPConfiguration ipConfiguration = default;
            PublicIPAddressDnsSettings dnsSettings = default;
            DdosSettings ddosSettings = default;
            IList<IpTag> ipTags = default;
            string ipAddress = default;
            SubResource publicIPPrefix = default;
            int? idleTimeoutInMinutes = default;
            string resourceGuid = default;
            ProvisioningState? provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = PublicIPAddressSku.DeserializePublicIPAddressSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publicIPAllocationMethod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAllocationMethod = new IPAllocationMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddressVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipConfiguration = IPConfiguration.DeserializeIPConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = PublicIPAddressDnsSettings.DeserializePublicIPAddressDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ddosSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ddosSettings = DdosSettings.DeserializeDdosSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipTags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IpTag> array = new List<IpTag>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IpTag.DeserializeIpTag(item));
                                }
                            }
                            ipTags = array;
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicIPPrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPPrefix = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("idleTimeoutInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PublicIPAddress(id, name, type, location, tags, sku, etag, zones, publicIPAllocationMethod, publicIPAddressVersion, ipConfiguration, dnsSettings, ddosSettings, ipTags, ipAddress, publicIPPrefix, idleTimeoutInMinutes, resourceGuid, provisioningState);
        }
    }
}
