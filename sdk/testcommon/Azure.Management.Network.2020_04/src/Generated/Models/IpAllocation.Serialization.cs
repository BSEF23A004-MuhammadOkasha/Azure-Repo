// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class IpAllocation : IUtf8JsonSerializable
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
            if (Optional.IsDefined(TypePropertiesType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TypePropertiesType.Value.ToString());
            }
            if (Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix");
                writer.WriteStringValue(Prefix);
            }
            if (Optional.IsDefined(PrefixLength))
            {
                if (PrefixLength != null)
                {
                    writer.WritePropertyName("prefixLength");
                    writer.WriteNumberValue(PrefixLength.Value);
                }
                else
                {
                    writer.WriteNull("prefixLength");
                }
            }
            if (Optional.IsDefined(PrefixType))
            {
                writer.WritePropertyName("prefixType");
                writer.WriteStringValue(PrefixType.Value.ToString());
            }
            if (Optional.IsDefined(IpamAllocationId))
            {
                writer.WritePropertyName("ipamAllocationId");
                writer.WriteStringValue(IpamAllocationId);
            }
            if (Optional.IsCollectionDefined(AllocationTags))
            {
                writer.WritePropertyName("allocationTags");
                writer.WriteStartObject();
                foreach (var item in AllocationTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IpAllocation DeserializeIpAllocation(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<SubResource> subnet = default;
            Optional<SubResource> virtualNetwork = default;
            Optional<IpAllocationType> type0 = default;
            Optional<string> prefix = default;
            Optional<int?> prefixLength = default;
            Optional<IPVersion> prefixType = default;
            Optional<string> ipamAllocationId = default;
            Optional<IDictionary<string, string>> allocationTags = default;
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subnet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            subnet = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualNetwork"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualNetwork = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            type0 = new IpAllocationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("prefix"))
                        {
                            prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("prefixLength"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                prefixLength = null;
                                continue;
                            }
                            prefixLength = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("prefixType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            prefixType = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipamAllocationId"))
                        {
                            ipamAllocationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allocationTags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            allocationTags = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IpAllocation(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, subnet.Value, virtualNetwork.Value, Optional.ToNullable(type0), prefix.Value, Optional.ToNullable(prefixLength), Optional.ToNullable(prefixType), ipamAllocationId.Value, Optional.ToDictionary(allocationTags));
        }
    }
}
