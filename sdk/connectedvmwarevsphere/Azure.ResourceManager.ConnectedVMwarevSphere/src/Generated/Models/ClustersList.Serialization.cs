// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    internal partial class ClustersList
    {
        internal static ClustersList DeserializeClustersList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            IReadOnlyList<VMwareClusterData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<VMwareClusterData> array = new List<VMwareClusterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareClusterData.DeserializeVMwareClusterData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ClustersList(nextLink.Value, value);
        }
    }
}
