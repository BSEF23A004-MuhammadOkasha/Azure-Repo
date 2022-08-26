// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppSubvolumeMetadata
    {
        internal static NetAppSubvolumeMetadata DeserializeNetAppSubvolumeMetadata(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> path = default;
            Optional<string> parentPath = default;
            Optional<long> size = default;
            Optional<long> bytesUsed = default;
            Optional<string> permissions = default;
            Optional<DateTimeOffset> creationTimeStamp = default;
            Optional<DateTimeOffset> accessedTimeStamp = default;
            Optional<DateTimeOffset> modifiedTimeStamp = default;
            Optional<DateTimeOffset> changedTimeStamp = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("path"))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parentPath"))
                        {
                            parentPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            size = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesUsed"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bytesUsed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("permissions"))
                        {
                            permissions = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTimeStamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessedTimeStamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modifiedTimeStamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            modifiedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changedTimeStamp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            changedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetAppSubvolumeMetadata(id, name, type, systemData.Value, path.Value, parentPath.Value, Optional.ToNullable(size), Optional.ToNullable(bytesUsed), permissions.Value, Optional.ToNullable(creationTimeStamp), Optional.ToNullable(accessedTimeStamp), Optional.ToNullable(modifiedTimeStamp), Optional.ToNullable(changedTimeStamp), provisioningState.Value);
        }
    }
}
