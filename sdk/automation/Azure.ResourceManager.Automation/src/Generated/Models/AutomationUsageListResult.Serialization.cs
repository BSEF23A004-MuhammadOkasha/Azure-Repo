// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class AutomationUsageListResult
    {
        internal static AutomationUsageListResult DeserializeAutomationUsageListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AutomationUsage>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AutomationUsage> array = new List<AutomationUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomationUsage.DeserializeAutomationUsage(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AutomationUsageListResult(Optional.ToList(value));
        }
    }
}
