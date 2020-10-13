// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class SecurityRule : IUtf8JsonSerializable
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
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(SourcePortRange))
            {
                writer.WritePropertyName("sourcePortRange");
                writer.WriteStringValue(SourcePortRange);
            }
            if (Optional.IsDefined(DestinationPortRange))
            {
                writer.WritePropertyName("destinationPortRange");
                writer.WriteStringValue(DestinationPortRange);
            }
            if (Optional.IsDefined(SourceAddressPrefix))
            {
                writer.WritePropertyName("sourceAddressPrefix");
                writer.WriteStringValue(SourceAddressPrefix);
            }
            if (Optional.IsCollectionDefined(SourceAddressPrefixes))
            {
                writer.WritePropertyName("sourceAddressPrefixes");
                writer.WriteStartArray();
                foreach (var item in SourceAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceApplicationSecurityGroups))
            {
                writer.WritePropertyName("sourceApplicationSecurityGroups");
                writer.WriteStartArray();
                foreach (var item in SourceApplicationSecurityGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DestinationAddressPrefix))
            {
                writer.WritePropertyName("destinationAddressPrefix");
                writer.WriteStringValue(DestinationAddressPrefix);
            }
            if (Optional.IsCollectionDefined(DestinationAddressPrefixes))
            {
                writer.WritePropertyName("destinationAddressPrefixes");
                writer.WriteStartArray();
                foreach (var item in DestinationAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationApplicationSecurityGroups))
            {
                writer.WritePropertyName("destinationApplicationSecurityGroups");
                writer.WriteStartArray();
                foreach (var item in DestinationApplicationSecurityGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourcePortRanges))
            {
                writer.WritePropertyName("sourcePortRanges");
                writer.WriteStartArray();
                foreach (var item in SourcePortRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPortRanges))
            {
                writer.WritePropertyName("destinationPortRanges");
                writer.WriteStartArray();
                foreach (var item in DestinationPortRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Access))
            {
                writer.WritePropertyName("access");
                writer.WriteStringValue(Access.Value.ToString());
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Direction))
            {
                writer.WritePropertyName("direction");
                writer.WriteStringValue(Direction.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SecurityRule DeserializeSecurityRule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> description = default;
            Optional<SecurityRuleProtocol> protocol = default;
            Optional<string> sourcePortRange = default;
            Optional<string> destinationPortRange = default;
            Optional<string> sourceAddressPrefix = default;
            Optional<IList<string>> sourceAddressPrefixes = default;
            Optional<IList<ApplicationSecurityGroup>> sourceApplicationSecurityGroups = default;
            Optional<string> destinationAddressPrefix = default;
            Optional<IList<string>> destinationAddressPrefixes = default;
            Optional<IList<ApplicationSecurityGroup>> destinationApplicationSecurityGroups = default;
            Optional<IList<string>> sourcePortRanges = default;
            Optional<IList<string>> destinationPortRanges = default;
            Optional<SecurityRuleAccess> access = default;
            Optional<int> priority = default;
            Optional<SecurityRuleDirection> direction = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            protocol = new SecurityRuleProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourcePortRange"))
                        {
                            sourcePortRange = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("destinationPortRange"))
                        {
                            destinationPortRange = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceAddressPrefix"))
                        {
                            sourceAddressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceAddressPrefixes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            sourceAddressPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("sourceApplicationSecurityGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationSecurityGroup> array = new List<ApplicationSecurityGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(item));
                            }
                            sourceApplicationSecurityGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("destinationAddressPrefix"))
                        {
                            destinationAddressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("destinationAddressPrefixes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            destinationAddressPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("destinationApplicationSecurityGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationSecurityGroup> array = new List<ApplicationSecurityGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(item));
                            }
                            destinationApplicationSecurityGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("sourcePortRanges"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            sourcePortRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("destinationPortRanges"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            destinationPortRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("access"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            access = new SecurityRuleAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("priority"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("direction"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            direction = new SecurityRuleDirection(property0.Value.GetString());
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
            return new SecurityRule(id.Value, name.Value, etag.Value, description.Value, Optional.ToNullable(protocol), sourcePortRange.Value, destinationPortRange.Value, sourceAddressPrefix.Value, Optional.ToList(sourceAddressPrefixes), Optional.ToList(sourceApplicationSecurityGroups), destinationAddressPrefix.Value, Optional.ToList(destinationAddressPrefixes), Optional.ToList(destinationApplicationSecurityGroups), Optional.ToList(sourcePortRanges), Optional.ToList(destinationPortRanges), Optional.ToNullable(access), Optional.ToNullable(priority), Optional.ToNullable(direction), Optional.ToNullable(provisioningState));
        }
    }
}
