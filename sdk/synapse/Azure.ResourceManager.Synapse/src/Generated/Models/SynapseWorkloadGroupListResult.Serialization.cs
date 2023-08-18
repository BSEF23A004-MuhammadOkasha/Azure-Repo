// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseWorkloadGroupListResult
    {
        internal static SynapseWorkloadGroupListResult DeserializeSynapseWorkloadGroupListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<SynapseWorkloadGroupData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseWorkloadGroupData> array = new List<SynapseWorkloadGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseWorkloadGroupData.DeserializeSynapseWorkloadGroupData(item));
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
            return new SynapseWorkloadGroupListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
