// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class GatewayCustomDomainResourceList
    {
        internal static GatewayCustomDomainResourceList DeserializeGatewayCustomDomainResourceList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AppPlatformGatewayCustomDomainData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformGatewayCustomDomainData> array = new List<AppPlatformGatewayCustomDomainData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformGatewayCustomDomainData.DeserializeAppPlatformGatewayCustomDomainData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GatewayCustomDomainResourceList(Optional.ToList(value), nextLink.Value);
        }
    }
}
