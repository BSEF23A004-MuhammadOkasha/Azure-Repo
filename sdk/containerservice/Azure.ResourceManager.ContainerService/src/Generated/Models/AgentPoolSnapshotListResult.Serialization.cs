// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class AgentPoolSnapshotListResult
    {
        internal static AgentPoolSnapshotListResult DeserializeAgentPoolSnapshotListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AgentPoolSnapshotData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AgentPoolSnapshotData> array = new List<AgentPoolSnapshotData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AgentPoolSnapshotData.DeserializeAgentPoolSnapshotData(item));
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
            return new AgentPoolSnapshotListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
