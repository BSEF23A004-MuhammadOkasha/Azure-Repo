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
    internal partial class ServiceRegistryResourceList
    {
        internal static ServiceRegistryResourceList DeserializeServiceRegistryResourceList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<AppPlatformServiceRegistryData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformServiceRegistryData> array = new List<AppPlatformServiceRegistryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformServiceRegistryData.DeserializeAppPlatformServiceRegistryData(item));
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
            return new ServiceRegistryResourceList(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
