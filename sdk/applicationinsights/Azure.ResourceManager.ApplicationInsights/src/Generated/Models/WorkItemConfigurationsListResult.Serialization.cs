// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    internal partial class WorkItemConfigurationsListResult
    {
        internal static WorkItemConfigurationsListResult DeserializeWorkItemConfigurationsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<WorkItemConfiguration>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkItemConfiguration> array = new List<WorkItemConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkItemConfiguration.DeserializeWorkItemConfiguration(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new WorkItemConfigurationsListResult(Core.Optional.ToList(value));
        }
    }
}
