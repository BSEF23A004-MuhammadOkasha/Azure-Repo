// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class AutomationWebhookListResult
    {
        internal static AutomationWebhookListResult DeserializeAutomationWebhookListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<AutomationWebhookData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AutomationWebhookData> array = new List<AutomationWebhookData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomationWebhookData.DeserializeAutomationWebhookData(item));
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
            return new AutomationWebhookListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
