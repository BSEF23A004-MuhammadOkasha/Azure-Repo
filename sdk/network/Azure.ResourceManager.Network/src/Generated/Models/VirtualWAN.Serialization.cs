// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualWAN : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
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
            if (Optional.IsDefined(DisableVpnEncryption))
            {
                writer.WritePropertyName("disableVpnEncryption");
                writer.WriteBooleanValue(DisableVpnEncryption.Value);
            }
            if (Optional.IsDefined(AllowBranchToBranchTraffic))
            {
                writer.WritePropertyName("allowBranchToBranchTraffic");
                writer.WriteBooleanValue(AllowBranchToBranchTraffic.Value);
            }
            if (Optional.IsDefined(AllowVnetToVnetTraffic))
            {
                writer.WritePropertyName("allowVnetToVnetTraffic");
                writer.WriteBooleanValue(AllowVnetToVnetTraffic.Value);
            }
            if (Optional.IsDefined(TypePropertiesType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TypePropertiesType);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualWAN DeserializeVirtualWAN(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<bool> disableVpnEncryption = default;
            Optional<IReadOnlyList<SubResource>> virtualHubs = default;
            Optional<IReadOnlyList<SubResource>> vpnSites = default;
            Optional<bool> allowBranchToBranchTraffic = default;
            Optional<bool> allowVnetToVnetTraffic = default;
            Optional<OfficeTrafficCategory> office365LocalBreakoutCategory = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> type0 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("disableVpnEncryption"))
                        {
                            disableVpnEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("virtualHubs"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            virtualHubs = array;
                            continue;
                        }
                        if (property0.NameEquals("vpnSites"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            vpnSites = array;
                            continue;
                        }
                        if (property0.NameEquals("allowBranchToBranchTraffic"))
                        {
                            allowBranchToBranchTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowVnetToVnetTraffic"))
                        {
                            allowVnetToVnetTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("office365LocalBreakoutCategory"))
                        {
                            office365LocalBreakoutCategory = new OfficeTrafficCategory(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualWAN(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, Optional.ToNullable(disableVpnEncryption), Optional.ToList(virtualHubs), Optional.ToList(vpnSites), Optional.ToNullable(allowBranchToBranchTraffic), Optional.ToNullable(allowVnetToVnetTraffic), Optional.ToNullable(office365LocalBreakoutCategory), Optional.ToNullable(provisioningState), type0.Value);
        }
    }
}
