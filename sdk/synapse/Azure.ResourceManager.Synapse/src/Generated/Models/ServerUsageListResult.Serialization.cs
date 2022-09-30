// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class ServerUsageListResult
    {
        internal static ServerUsageListResult DeserializeServerUsageListResult(JsonElement element)
        {
            IReadOnlyList<ServerUsage> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ServerUsage> array = new List<ServerUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServerUsage.DeserializeServerUsage(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ServerUsageListResult(value, nextLink.Value);
        }
    }
}
