// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class IPv6Config
    {
        internal static IPv6Config DeserializeIPv6Config(JsonElement element)
        {
            Optional<string> ipAddress = default;
            Optional<int> prefixLength = default;
            Optional<string> gateway = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prefixLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    prefixLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("gateway"))
                {
                    gateway = property.Value.GetString();
                    continue;
                }
            }
            return new IPv6Config(ipAddress.Value, Optional.ToNullable(prefixLength), gateway.Value);
        }
    }
}
